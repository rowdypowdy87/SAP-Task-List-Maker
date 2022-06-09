using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace SAP_Task_List_Maker
{
    /// <summary>
    /// Template DGV for the tool
    /// </summary>
    public class Tasklist : DataGridView
    {
        private ContextMenuStrip MyContextMenuStrip;
        public  Color            CellSelectedColor_Border;
        public  bool             AllowRowMods = true;
        
        /// <summary>
        /// Contructor
        /// </summary>
        public Tasklist()
        {
            // Variables
            DataGridViewCellStyle DefaultStyle = new DataGridViewCellStyle()
            {
                SelectionBackColor  = Color.White,
                SelectionForeColor  = Color.Black,
                Alignment           = DataGridViewContentAlignment.MiddleLeft,
                BackColor           = SystemColors.Window,
                Font                = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point),
                ForeColor           = SystemColors.ControlText,
                WrapMode            = DataGridViewTriState.False
            };

            // Set properties
            DefaultCellStyle            = DefaultStyle;
            AllowUserToAddRows          = false;
            GridColor                   = Color.Gray;
            CellBorderStyle             = DataGridViewCellBorderStyle.None;
            CellSelectedColor_Border    = Color.FromArgb(48, 84, 150);
            GridColor                   = Color.LightGray;

            // Build context menu
            ToolStripMenuItem Insert    = new ToolStripMenuItem("Insert");
            ToolStripMenuItem Above     = new ToolStripMenuItem("Above");
            ToolStripMenuItem Below     = new ToolStripMenuItem("Below");
            ToolStripMenuItem Cut       = new ToolStripMenuItem("Cut");
            ToolStripMenuItem Copy      = new ToolStripMenuItem("Copy");
            ToolStripMenuItem Paste     = new ToolStripMenuItem("Paste");
            ToolStripMenuItem Delete    = new ToolStripMenuItem("Delete");
            MyContextMenuStrip          = new ContextMenuStrip();

            MyContextMenuStrip.Items.AddRange(new ToolStripItem[] { Insert, Cut, Copy, Paste, Delete });
            Insert.DropDownItems.AddRange(new ToolStripItem[] { Above, Below });

            // Add events - context
            Above.MouseDown     += new MouseEventHandler(InsertAboveMenu_Click);
            Below.MouseDown     += new MouseEventHandler(InsertBelowMenu_Click);
            Delete.MouseDown    += new MouseEventHandler(DeleteRowMenu_Click);
            // Add events
            CellBeginEdit       += new DataGridViewCellCancelEventHandler(TL_CellBeginEdit);
            CellEndEdit         += new DataGridViewCellEventHandler(TL_CellEndEdit);
            MouseEnter          += new EventHandler(TL_MouseEnter);
            RowHeaderMouseClick += new DataGridViewCellMouseEventHandler(TL_RowHeaderClick);
            CellPainting        += new DataGridViewCellPaintingEventHandler(TL_CellPaint);

            // use reflection to set doublebuffered property on datagridview
            typeof(Tasklist).InvokeMember(
             "DoubleBuffered",
             BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty,
             null,
             this,
             new object[] { true });
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
                MyContextMenuStrip.Show(MousePosition);
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
            foreach (DataGridViewRow r in SelectedRows)
            {
                r.Dispose();
            }

        }

        /// <summary>
        /// Stop SHIFT+SPACE selecting a whole row
        /// </summary>
        private void TL_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            SelectionMode = DataGridViewSelectionMode.CellSelect;
        }

        /// <summary>
        /// Stop SHIFT+SPACE selecting a whole row
        /// </summary>
        private void TL_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;
        }

        /// <summary>
        /// Paint nice borders
        /// </summary>
        private void TL_CellPaint(object sender, DataGridViewCellPaintingEventArgs e)
        {
            //Draw only grid content cells not ColumnHeader cells nor RowHeader cells
            if (e.ColumnIndex > -1 & e.RowIndex > -1)
            {
                //Pen for selected cell borders
                using var selectedPen   = new Pen(CellSelectedColor_Border, 3);

                //Draw selected cells here
                if (this[e.ColumnIndex, e.RowIndex].Selected)
                {
                    //Paint all parts except borders & background.
                    e.Paint(e.ClipBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.Border);

                    //Draw selected cells border here
                    e.Graphics.DrawRectangle(selectedPen, new Rectangle(e.CellBounds.Left + 1, e.CellBounds.Top + 1, e.CellBounds.Width - 3, e.CellBounds.Height - 3));

                    //Handled painting for this cell, Stop default rendering.
                    e.Handled = true;
                }
            }
        }

       /* protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);  
            base.OnPaint(e);

            Pen pen = new Pen(Color.Red, 2);

            int width = 0, height = 0;

            if (SelectedCells.Count > 1)
            {
                Rectangle CurrentCellRect = GetCellDisplayRectangle(SelectedCells[0].ColumnIndex, SelectedCells[0].RowIndex, false);
                
                for(int i = 0; i < SelectedCells.Count; i++)
                {
                    width  += SelectedCells[i].Size.Width;
                    height += SelectedCells[i].Size.Height;
                }

                Rectangle SelectRect = new(CurrentCellRect.X + 1, CurrentCellRect.Y + 1, width - 1, height - 1);

                e.Graphics.DrawRectangle(pen, SelectRect);

               
                //Rectangle R = GetCellRect();
                //e.Graphics.DrawRectangle(pen, R);


            }
        }
       */
    }
}
