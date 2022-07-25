using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SAP_Task_List_Maker
{
    public enum UNDO_ITEM_TYPE
    {
        Cell = 0,
        Row = 1,
        Col = 2
    };

    public enum UNDO_ITEM_ACTION
    {
        Delete = 0,
        Insert = 1
    };

    public struct UNDO_ACTION
    {
        public UNDO_ITEM_ACTION     Action;
        public UNDO_ITEM_TYPE       Type;
        public DataGridViewRow      Row;
        public DataGridViewCell     Cell;
        public string               Value;
        public string               PreviousValue;
        public int                  Index;
    }

    /// <summary>
    /// Template DGV for the tool
    /// </summary>
    public class Tasklist : DataGridView
    { 
        private ContextMenuStrip                MyContextMenuStrip;
        public  bool                            AllowRowMods = true;
        public  Pen                             BackgroundPen, GridLinePen, BorderOuter, BorderInner, BorderFrame;
        public  Brush                           InsideBrush;
        public  DataGridViewCellStyle           CellStyle, ColCellStyle;
        public  Undo                            UndoController;
        public  MainWindow ParentWindow;

        /// <summary>
        /// Contructor
        /// </summary>
        public Tasklist()
        {
            // Set undo controller
            UndoController = new(this);

            // Set colors of lines
            BackgroundPen   = new(BackColor, 1); 
            BorderFrame     = new(Color.White, 1);
            GridLinePen     = new(Color.FromArgb(212, 212, 212), 1);
            BorderOuter     = new(Color.FromArgb(31, 78, 120), 1);
            BorderInner     = new(Color.FromArgb(48, 120, 186), 1);
            InsideBrush     = new SolidBrush(Color.FromArgb(221, 235, 247));
            AllowDrop       = true;

            CellStyle = new()
            {
                Font                = new("Calibri", 9.0f, FontStyle.Regular),
                ForeColor           = Color.Black,
                BackColor           = Color.White,
                WrapMode            = DataGridViewTriState.True,
                Padding             = new Padding(10,10,10,10),
                SelectionBackColor  = Color.White
                
            };

            ColCellStyle = new()
            {
                Font = new("Calibri", 9.0f, FontStyle.Bold),
                SelectionForeColor = Color.Black,
                SelectionBackColor = Color.Gray,
                ForeColor = Color.Black,
                BackColor = Color.Gray,
                WrapMode = DataGridViewTriState.True
              
            };

            ColumnHeadersDefaultCellStyle = ColCellStyle;
            DefaultCellStyle              = CellStyle;
            
            AutoSizeRowsMode              = DataGridViewAutoSizeRowsMode.AllCells;
            EditMode                      = DataGridViewEditMode.EditProgrammatically;

            ColumnHeadersHeight = 50;

            // Build context menu
            ToolStripMenuItem Insert    = new("Insert");
            ToolStripMenuItem Above     = new("Above");
            ToolStripMenuItem Below     = new("Below");
            ToolStripMenuItem Cut       = new("Cut");
            ToolStripMenuItem Copy      = new("Copy");
            ToolStripMenuItem Paste     = new("Paste");
            ToolStripMenuItem Delete    = new("Delete");
            MyContextMenuStrip          = new();

            MyContextMenuStrip.Items.AddRange(new ToolStripItem[] { Insert, Cut, Copy, Paste, Delete });
            Insert.DropDownItems.AddRange(new ToolStripItem[] { Above, Below });

            // Add events - context
            Above.MouseDown     += new(InsertAboveMenu_Click);
            Below.MouseDown     += new(InsertBelowMenu_Click);
            Delete.MouseDown    += new(DeleteRowMenu_Click);
            // Add events
            CellBeginEdit       += new(TL_CellBeginEdit);
            CellEndEdit         += new(TL_CellEndEdit);
            MouseEnter          += new(TL_MouseEnter);
            RowHeaderMouseClick += new(TL_RowHeaderClick);

            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint, true);    
        }

        /// <summary>
        /// Sets main window handle
        /// </summary>
        /// <param name="P"></param>
        public void SetParent(MainWindow P)
        {
            ParentWindow = P;
        }

        /// <summary>
        /// Make double click edit the cell
        /// </summary>
        protected override void OnCellDoubleClick(DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex > -1 & e.RowIndex > -1)
                 BeginEdit(false);
        }

        /// <summary>
        /// Make F2 make current cell go into edit mode
        /// </summary>
        protected override void OnKeyDown(KeyEventArgs e)
        {
            // F2 makes cell go into edit mode
            switch (e.KeyCode)
            {
                // Start edit mode
                case Keys.F2:
                    
                    if (!IsCurrentCellInEditMode)
                        BeginEdit(false);
                    else
                        EndEdit();

                    e.Handled = true;
                    break;

                // Delete key
                case Keys.Delete:

                    if (SelectedCells.Count > 0)
                    { 
                        // Scan through each cellk
                        foreach (DataGridViewCell c in SelectedCells)
                        { 
                            if (c.Value != null)
                            {
                                UNDO_ACTION Action = new()
                                {
                                    Action      = UNDO_ITEM_ACTION.Delete,
                                    Cell        = c,
                                    Type        = UNDO_ITEM_TYPE.Cell,
                                    Value       = c.Value.ToString()
                                };

                                //Multiple cells selected
                                UndoController.CreateUndoAction(Action);

                                c.Value = "";
                            }
                        }
   
                    }

                    // Add to undo/redo stack
                    UndoController.AddUndoActions();

                    break;

                // Undo action
                case Keys.Z:
                    if (ModifierKeys == Keys.Control) UndoController.DoUndo();
                    break;

                // Redo action
                case Keys.Y:
                    if (ModifierKeys == Keys.Control) UndoController.DoRedo();
                    break;

                default:
                    base.OnKeyDown(e);
                    break;
            }  
        }

        /// <summary>
        /// Make edit stop on leaving of cell
        /// </summary>
        /// <param name="e"></param>
        protected override void OnCellLeave(DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex > -1 & e.RowIndex > -1) 
                EndEdit();
        }

        /// <summary>
        /// Turn off the annoynig tooltips for every cell
        /// </summary>
        private void TL_MouseEnter(object sender, EventArgs e)
        {
            ShowCellToolTips = false;
        }

        /// <summary>
        /// Shows context menu when you right click the row headers
        /// </summary>
        private void TL_RowHeaderClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && AllowRowMods)
            { 
                if (SelectedRows.Count <= 0)
                { 
                    MyContextMenuStrip.Items[1].Enabled = false;
                    MyContextMenuStrip.Items[2].Enabled = false;
                    MyContextMenuStrip.Items[3].Enabled = false;
                    MyContextMenuStrip.Items[4].Enabled = false;
                }
                else
                {
                    MyContextMenuStrip.Items[1].Enabled = true;
                    MyContextMenuStrip.Items[2].Enabled = true;
                    MyContextMenuStrip.Items[3].Enabled = true;
                    MyContextMenuStrip.Items[4].Enabled = true;
                }
                MyContextMenuStrip.Show(MousePosition);
            }
        }

        /* Context menu events */

        /// <summary>
        /// Inserts a new row above the current selected row
        /// </summary>
        private void InsertAboveMenu_Click(object sender, EventArgs e)
        {
            // Check we have a row selected
            if (SelectedRows.Count == 0)
            {
                MsgBoxs.MsgBox_Warning("Please select a row to insert a new row");
                return;
            }

            // Insert row above
            if (SelectedRows.Count == 1)
                Rows.Insert(SelectedRows[0].Index, new DataGridViewRow());
            else
                MsgBoxs.MsgBox_Warning("Please select a single row to insert a new row");
        }

        /// <summary>
        /// Inserts a new row below the current selected row
        /// </summary>
        private void InsertBelowMenu_Click(object sender, EventArgs e)
        {
            // Check we have a row selected
            if (SelectedRows.Count == 0)
            {
                MsgBoxs.MsgBox_Warning("Please select a row to insert a new row");
                return;
            }

            // Insert row above
            if (SelectedRows.Count == 1)
            {
                // Check if we are at the last row
                if (SelectedRows[0].Index + 1 > Rows.Count - 1)
                    Rows.Add();
                else
                    Rows.Insert(SelectedRows[0].Index + 1, new DataGridViewRow());
            }
            else
                MsgBoxs.MsgBox_Warning("Please select a single row to insert a new row");
        }

        /// <summary>
        /// Delete selected rows
        /// </summary>
        private void DeleteRowMenu_Click(object sender, EventArgs e)
        {
            // Check we have a row selected
            if (SelectedRows.Count == 0)
            {
                MsgBoxs.MsgBox_Warning("Please select a row to delete");
                return;
            }

            // Remove the rows
            foreach (DataGridViewRow Row in SelectedRows)
            {
                // Create undo action
                UndoController.CreateUndoAction(new UNDO_ACTION()
                {
                    Action  = UNDO_ITEM_ACTION.Delete,
                    Row     = Row,
                    Type    = UNDO_ITEM_TYPE.Row,
                    Index   = Row.Index
                });

                // Remove actual row
                Rows.Remove(Row);
            }

            // Add to undo stack
            UndoController.AddUndoActions();

        }

        /// <summary>
        /// Stop SHIFT+SPACE selecting a whole row
        /// </summary>
        private void TL_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            // Redraw the cell
            Invalidate(true);

            SelectionMode = DataGridViewSelectionMode.CellSelect;

            // Create a new undo action
            if (CurrentCell.Value != null)
            {
                //Multiple cells selected
                UndoController.CreateUndoAction(new UNDO_ACTION()
                {
                    Action      = UNDO_ITEM_ACTION.Delete,
                    Cell        = CurrentCell,
                    Type        = UNDO_ITEM_TYPE.Cell,
                    Value       = CurrentCell.Value.ToString()
                });

                // Add to undo stack
                UndoController.AddUndoActions();
            }
        }

        /// <summary>
        /// Stop SHIFT+SPACE selecting a whole row
        /// </summary>
        private void TL_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;
        }

        /// <summary>
        /// Paint nice borders and stuff
        /// </summary>
        protected override void OnCellPainting(DataGridViewCellPaintingEventArgs e)
        { 
            //Draw only grid content cells not ColumnHeader cells nor RowHeader cells
            if (e.ColumnIndex > -1 & e.RowIndex > -1)
            {
                // Draw measurement point cell
                var topLeftPoint        = new Point(e.CellBounds.Left, e.CellBounds.Top);
                var topRightPoint       = new Point(e.CellBounds.Right - 1, e.CellBounds.Top);
                var bottomRightPoint    = new Point(e.CellBounds.Right - 1, e.CellBounds.Bottom - 1);
                var bottomleftPoint     = new Point(e.CellBounds.Left, e.CellBounds.Bottom - 1);

                // Paint bg
                e.PaintBackground(e.ClipBounds, true);

                //Draw selected cells here
                if (this[e.ColumnIndex, e.RowIndex].Selected)
                {
                    e.Graphics.FillRectangle(InsideBrush,
                                                e.CellBounds.Left,
                                                e.CellBounds.Top,
                                                e.CellBounds.Width,
                                                e.CellBounds.Height);

                    // Darker outer
                    e.Graphics.DrawRectangle(BorderOuter,
                                                e.CellBounds.Left,
                                                e.CellBounds.Top,
                                                e.CellBounds.Width - 1,
                                                e.CellBounds.Height - 1);
                    // Mid inner
                    e.Graphics.DrawRectangle(BorderInner,
                                                e.CellBounds.Left + 1,
                                                e.CellBounds.Top + 1,
                                                e.CellBounds.Width - 3,
                                                e.CellBounds.Height - 3);

                    // Highlight
                    e.Graphics.DrawRectangle(BorderFrame,
                                                e.CellBounds.Left + 2,
                                                e.CellBounds.Top + 2,
                                                e.CellBounds.Width - 5,
                                                e.CellBounds.Height - 5);

                    // Paint content
                    if (this[e.ColumnIndex, e.RowIndex].GetType() != typeof(MeaspointCell)) 
                        e.PaintContent(e.CellBounds);

                    //Handled painting for this cell, Stop default rendering.
                    e.Handled = true;
                }
                else if (this[e.ColumnIndex, e.RowIndex].IsInEditMode)
                {
                    // Draw background
                    e.Graphics.FillRectangle(new SolidBrush(Color.White), e.CellBounds);

                    // Darker outer
                    e.Graphics.DrawRectangle(BorderOuter,
                                                e.CellBounds.Left,
                                                e.CellBounds.Top,
                                                e.CellBounds.Width - 1,
                                                e.CellBounds.Height - 1);
                    // Mid inner
                    e.Graphics.DrawRectangle(BorderInner,
                                                e.CellBounds.Left + 1,
                                                e.CellBounds.Top + 1,
                                                e.CellBounds.Width - 3,
                                                e.CellBounds.Height - 3);

                    // Highlight
                    e.Graphics.DrawRectangle(BorderFrame,
                                                e.CellBounds.Left + 2,
                                                e.CellBounds.Top + 2,
                                                e.CellBounds.Width - 5,
                                                e.CellBounds.Height - 5);

                    //Handled painting for this cell, Stop default rendering.
                    e.Handled = true;
                }
                //Draw non-selected cells here
                else if (!this[e.ColumnIndex, e.RowIndex].Selected)
                {
                    if (this[e.ColumnIndex, e.RowIndex].GetType() != typeof(MeaspointCell))
                            e.Paint(e.ClipBounds, DataGridViewPaintParts.All);

                    //Top border of first row cells should be in background color
                    if (e.RowIndex == 0)
                        e.Graphics.DrawLine(BackgroundPen, topLeftPoint, topRightPoint);

                    //Left border of first column cells should be in background color
                    if (e.ColumnIndex == 0)
                        e.Graphics.DrawLine(BackgroundPen, topLeftPoint, bottomleftPoint);

                    //Bottom border of last row cells should be in gridLine color
                    if (e.RowIndex == RowCount - 1)
                        e.Graphics.DrawLine(GridLinePen, bottomRightPoint, bottomleftPoint);
                    else  //Bottom border of non-last row cells should be in background color
                        e.Graphics.DrawLine(BackgroundPen, bottomRightPoint, bottomleftPoint);

                    //Right border of last column cells should be in gridLine color
                    if (e.ColumnIndex == ColumnCount - 1)
                        e.Graphics.DrawLine(GridLinePen, bottomRightPoint, topRightPoint);
                    else //Right border of non-last column cells should be in background color
                        e.Graphics.DrawLine(BackgroundPen, bottomRightPoint, topRightPoint);

                    //Top border of non-first row cells should be in gridLine color, and they should be drawn here after right border
                    if (e.RowIndex > 0)
                        e.Graphics.DrawLine(GridLinePen, topLeftPoint, topRightPoint);

                    //Left border of non-first column cells should be in gridLine color, and they should be drawn here after bottom border
                    if (e.ColumnIndex > 0)
                        e.Graphics.DrawLine(GridLinePen, topLeftPoint, bottomleftPoint);

                    //We handled painting for this cell, Stop default rendering.
                    e.Handled = true;
                }

                // Paint contents of cell for measurement column
                if (this[e.ColumnIndex, e.RowIndex].GetType() == typeof(MeaspointCell))
                {
                    // Variables
                    Font          MeasFont = new("Segeo UI", 8.0f, FontStyle.Regular);
                    MeaspointCell cell     = (MeaspointCell)this[e.ColumnIndex, e.RowIndex];

                    if (cell.Attached.Count > 0)
                    {
                        for (int i = 0; i < cell.Attached.Count; i++)
                        {

                            // Info variables
                            MobilityMeasurement Cur                 = ParentWindow.MeasurementManager.GetMeasurement(cell.Attached[i]);
                            int                 StrHeight           = (int)e.Graphics.MeasureString(Cur.Description, MeasFont).Height;
                            int                 IconX, IconY, 
                                                SpX, SpY;
                            Image               Icon                = Properties.Resources.MeasurePointSmall;

                            // Set base positions
                            SpX     = 5;
                            SpY     = StrHeight + SpX;
                            IconX   = e.CellBounds.X + 3;
                            IconY   = e.CellBounds.Y + 13;


                            e.Graphics.DrawImage(Icon, new Point(IconX, IconY - (StrHeight/2) + (i * SpY) - 2));

                            if (Cur.Position != "")
                                TextRenderer.DrawText(e.Graphics, 
                                                      $"{Cur.Position} - {Cur.Description}", 
                                                      MeasFont, 
                                                      new Point(IconX + 20, IconY - (StrHeight/2) + (i * SpY)), Color.Black);
                            else
                                TextRenderer.DrawText(e.Graphics,
                                                      $"{Cur.Description}",
                                                      MeasFont,
                                                      new Point(IconX + 20, IconY - (StrHeight/2) + (i * SpY)), Color.Black);
                        }
                    }
                }
            }
        }

        public MeaspointCell CurrentDragCell = null;

        /// <summary>
        /// Handle data being dragged
        /// </summary>
        /// <param name="e"></param>
        protected override void OnDragDrop(DragEventArgs e)
        {
            if (CurrentDragCell != null)
            { 
                Debug.Print("Dropped event trigger");

                if (e.Data.GetDataPresent(typeof(int)))
                {
                    // Get data
                    int ToAdd = (int)e.Data.GetData(typeof(int));

                    if (ToAdd > -1)
                    {
                        // Drop data
                        CurrentDragCell.Attached.Add(ToAdd);
                        Debug.Print("Dropped in cell");

                        // Clear data
                        e.Data.SetData(-1);

                        Refresh();
                    }
                }
            }
        }

        /// <summary>
        /// Override drag over event
        /// </summary>
        /// <param name="e"></param>
        protected override void OnDragOver(DragEventArgs e)
        {
            // Find where mouse is pointing
            Point grvScreenLocation = PointToScreen(Location);

            // Check for cell hit
            HitTestInfo hit = HitTest(MousePosition.X - grvScreenLocation.X + Left,
                                      MousePosition.Y - grvScreenLocation.Y + Top);

            // Check for measurement poitn cells
            if (hit.ColumnIndex > -1 & hit.RowIndex > -1)
            { 
                if (this[hit.ColumnIndex, hit.RowIndex].GetType() == typeof(MeaspointCell))
                {
                    e.Effect        = DragDropEffects.Copy;
                    CurrentDragCell = (MeaspointCell)this[hit.ColumnIndex, hit.RowIndex];
                }
                else
                {
                    e.Effect        = DragDropEffects.None;
                    CurrentDragCell = null;
                } 
            }
        }
    }

    // Undo helper
    public class Undo
    {
        // Amount to hold in memory
        private const int UndoRedoLimit = 20;

        // Undo / Redo stacks
        private Stack<List<UNDO_ACTION>> UndoStack = new();
        private Stack<List<UNDO_ACTION>> RedoStack = new();

        // List to hold actions until push event
        public List<UNDO_ACTION> Actions = new();

        // Parent
        public Tasklist Parent;

        /// <summary>
        /// Constructpr method
        /// </summary>
        /// <param name="Par">Parent tasklist</param>
        public Undo(Tasklist Par)
        {
            Parent = Par; 
        }

        /// <summary>
        /// Creates a new undo action and adds to internal list
        /// </summary>
        /// <param name="details"></param>
        public void CreateUndoAction(UNDO_ACTION details)
        {
            Actions.Add(details);
        }

        /// <summary>
        /// Adds all actions in the list currently to the stack 
        /// then clears the list
        /// </summary>
        public void AddUndoActions()
        {
            if (UndoStack.Count < UndoRedoLimit)
            { 
                List<UNDO_ACTION> list = new List<UNDO_ACTION>();

                for(int i = 0; i < Actions.Count; i++)
                { 
                    list.Add(Actions[i]);
                }

                UndoStack.Push(list);
            }

            Actions.Clear();
        }

        /// <summary>
        /// Do undo from stack
        /// </summary>
        public void DoUndo()
        {
            if (UndoStack.Count > 0)
            {

                // Get action list
                List<UNDO_ACTION> ToDo = UndoStack.Pop();
                List<UNDO_ACTION> ReDo = new();

                // One action
                if (ToDo.Count == 1)
                {
                    // Type of components
                    switch (ToDo[0].Type)
                    {
                        case UNDO_ITEM_TYPE.Cell:

                            // ToDo to perform
                            switch (ToDo[0].Action)
                            {
                                case UNDO_ITEM_ACTION.Delete: 
                                    // Build redo struct
                                    UNDO_ACTION New = new()
                                    {
                                        Action          = UNDO_ITEM_ACTION.Delete,
                                        Type            = UNDO_ITEM_TYPE.Cell,
                                        Cell            = ToDo[0].Cell,
                                        PreviousValue   = Parent[ToDo[0].Cell.ColumnIndex, ToDo[0].Cell.RowIndex].Value.ToString()
                                    };

                                    // Undo
                                    Parent[ToDo[0].Cell.ColumnIndex, ToDo[0].Cell.RowIndex].Value = ToDo[0].Value; 
                                    // Add to redo queue
                                    ReDo.Add(New);
                                    break;

                            }

                            break;

                        case UNDO_ITEM_TYPE.Row:

                            // ToDo to perform
                            switch (ToDo[0].Action)
                            {
                                case UNDO_ITEM_ACTION.Delete:
                                    Parent.Rows.Insert(ToDo[0].Index, ToDo[0].Row); 
                                    break;
                            }

                            break;
                    }

                }
                // Multiple ToDo
                else if (ToDo.Count > 1)
                {
                    for (int i = 0; i < ToDo.Count; i++)
                    {
                        // Type of components
                        switch (ToDo[i].Type)
                        {
                            case UNDO_ITEM_TYPE.Cell:

                                // ToDo to perform
                                switch (ToDo[i].Action)
                                {
                                    case UNDO_ITEM_ACTION.Delete:
                                        // Build redo struct
                                        UNDO_ACTION New = new()
                                        {
                                            Action          = UNDO_ITEM_ACTION.Delete,
                                            Type            = UNDO_ITEM_TYPE.Cell,
                                            Cell            = ToDo[i].Cell,
                                            PreviousValue   = Parent[ToDo[i].Cell.ColumnIndex, ToDo[i].Cell.RowIndex].Value.ToString()
                                        };

                                        // Undo action
                                        Parent[ToDo[i].Cell.ColumnIndex, ToDo[i].Cell.RowIndex].Value = ToDo[i].Value;
                                        // Add to redo queue
                                        ReDo.Add(New);  
                                        break;
                                }

                                break;

                            case UNDO_ITEM_TYPE.Row:

                                // ToDo to perform
                                switch (ToDo[i].Action)
                                {
                                    case UNDO_ITEM_ACTION.Delete: 
                                        Parent.Rows.Insert(ToDo[i].Index, ToDo[i].Row); 
                                        break;
                                }

                                break;
                        }
                    }
                }

                // Add to re-do
                RedoStack.Push(ReDo);
            }
        }

        public void DoRedo()
        {
            if (RedoStack.Count > 0)
            {
                // Get action list
                List<UNDO_ACTION> ToDo = RedoStack.Pop();

                // One action
                if (ToDo.Count == 1)
                {
                    // Type of components
                    switch (ToDo[0].Type)
                    {
                        case UNDO_ITEM_TYPE.Cell:

                            // ToDo to perform
                            switch (ToDo[0].Action)
                            {
                                case UNDO_ITEM_ACTION.Delete:
                                    Parent[ToDo[0].Cell.ColumnIndex, ToDo[0].Cell.RowIndex].Value = ToDo[0].PreviousValue;
                                    break;

                            }

                            break;

                        case UNDO_ITEM_TYPE.Row:

                            // ToDo to perform
                            switch (ToDo[0].Action)
                            {
                                case UNDO_ITEM_ACTION.Delete:
                                    Parent.Rows.Insert(ToDo[0].Index, ToDo[0].Row);
                                    break;
                            }

                            break;
                    }

                }
                // Multiple ToDo
                else if (ToDo.Count > 1)
                {
                    for (int i = 0; i < ToDo.Count; i++)
                    {
                        // Type of components
                        switch (ToDo[i].Type)
                        {
                            case UNDO_ITEM_TYPE.Cell:

                                // ToDo to perform
                                switch (ToDo[i].Action)
                                {
                                    case UNDO_ITEM_ACTION.Delete:
                                        Parent[ToDo[i].Cell.ColumnIndex, ToDo[i].Cell.RowIndex].Value = ToDo[i].PreviousValue;
                                        break;
                                }

                                break;

                            case UNDO_ITEM_TYPE.Row:

                                // ToDo to perform
                                switch (ToDo[i].Action)
                                {
                                    case UNDO_ITEM_ACTION.Delete:
                                        Parent.Rows.Insert(ToDo[i].Index, ToDo[i].Row);
                                        break;
                                }

                                break;
                        }
                    }
                }
            }
        }
    }
}
