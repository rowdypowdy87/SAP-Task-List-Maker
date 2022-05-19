using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAP_Task_List_Maker
{
    public partial class MainWindow : Form
    {
        // Global variables
        public ImportExport   ImportExportManager;
        public MeasController MeasurementManager;
        

        /// <summary>
        /// Contructor method
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();

            ImportExportManager = new(this);
            MeasurementManager  = new(this);
        }

        /// <summary>
        /// Set status progress on Main Window
        /// </summary>
        /// <param name="StatusText">Status text</param>
        /// <param name="Prog">Progress amount</param>
        public void SetStatusProgress(string StatusText, int Prog)
        {
            if(Prog <= 0) 
                StatusProgressBar.Visible = false;
            else
            { 
                StatusProgressBar.Visible   = true;
                StatusProgressBar.Value     = Prog;
            }

            StatusTextLabel.Text    = StatusText;
        }

        private void importFromSapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImportExportManager.ImportFromSAP();
        }

        private void importMEasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MeasurementManager.LoadMeasurements("11338714");
        }

        /// <summary>
        /// Update measurement point data on click
        /// </summary>
        private void MeasTree_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if(e.Node.Text[..1] == "[")
            {
                MobilityMeasurement MeasureToDisplay = MeasurementManager.GetExistingMeasurement(e.Node.Index);

                MPDescriptionTextBox.Text   = MeasureToDisplay.Description;
                MPPositionTextBox.Text      = MeasureToDisplay.Position;
                MPCharNameComboBox.Text     = MeasureToDisplay.CharCode;
                MPCodeGroupComboBox.Text    = MeasureToDisplay.CodeGroup;
                MPDecimalTextBox.Text       = MeasureToDisplay.Decimals;
                MPUpperLimitTextBox.Text    = MeasureToDisplay.UpperLimit;
                MPLowerLimitTextBox.Text    = MeasureToDisplay.LowerLimit; 
                MPTargetTextTextBox.Text    = MeasureToDisplay.TargetText;
                MPTargetValueTextBox.Text   = MeasureToDisplay.TargetValue;
            }
        }

#region BODY DATA GRID EVENTS

        /// <summary>
        /// Turn off the annoynig tooltips for every cell
        /// </summary>
        private void DGVBody_MouseEnter(object sender, EventArgs e)
        {
            DGVBody.ShowCellToolTips = false;
        }

        /// <summary>
        /// Shows context menu when you right click the row headers
        /// </summary>
        private void DGVBody_RowHeaderClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                BodyDGVContextMenu.Show(MousePosition);
        }

        /* Context menu events */

        /// <summary>
        /// Inserts a new row above the current selected row
        /// </summary>
        private void InsertAboveMenu_Click(object sender, EventArgs e)
        {
            // Check we have a row selected
            if (DGVBody.SelectedRows.Count == 0)
            { 
                MsgBoxs.MsgBox_Warning("Please select a row to insert a new row");
                return;
            }

            // Insert row above
            if (DGVBody.SelectedRows.Count == 1)
                DGVBody.Rows.Insert(DGVBody.SelectedRows[0].Index, new DataGridViewRow());
            else
                MsgBoxs.MsgBox_Warning("Please select a single row to insert a new row");
        }

        /// <summary>
        /// Inserts a new row below the current selected row
        /// </summary>
        private void InsertBelowMenu_Click(object sender, EventArgs e)
        {
            // Check we have a row selected
            if (DGVBody.SelectedRows.Count == 0)
            {
                MsgBoxs.MsgBox_Warning("Please select a row to insert a new row");
                return;
            }

            // Insert row above
            if (DGVBody.SelectedRows.Count == 1)
            { 
                // Check if we are at the last row
                if (DGVBody.SelectedRows[0].Index + 1 > DGVBody.Rows.Count - 1)
                    DGVBody.Rows.Add();
                else
                    DGVBody.Rows.Insert(DGVBody.SelectedRows[0].Index + 1, new DataGridViewRow());
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
            if (DGVBody.SelectedRows.Count == 0)
            {
                MsgBoxs.MsgBox_Warning("Please select a row to delete");
                return;
            }

            // Remove the rows
            foreach (DataGridViewRow r in DGVBody.SelectedRows)
            {
                r.Dispose();
            }
            
        }

        /// <summary>
        /// Stop SHIFT+SPACE selecting a whole row
        /// </summary>
        private void DGVBody_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            DGVBody.SelectionMode = DataGridViewSelectionMode.CellSelect;
        }

        /// <summary>
        /// Stop SHIFT+SPACE selecting a whole row
        /// </summary>
        private void DGVBody_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DGVBody.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;
        }

        /// <summary>
        /// Paint nice borders
        /// </summary>
        private void DGVBody_CellPaint(object sender, DataGridViewCellPaintingEventArgs e)
        {
            //Draw only grid content cells not ColumnHeader cells nor RowHeader cells
            if (e.ColumnIndex > -1 & e.RowIndex > -1)
            {
                //Pen for selected cell borders
                using var selectedPen = new Pen(Color.FromArgb(136, 0, 21), 5);

                //Draw selected cells here
                if (DGVBody[e.ColumnIndex, e.RowIndex].Selected)
                {
                    //Paint all parts except borders.
                    e.Paint(e.ClipBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.Border);

                    //Draw selected cells border here
                    e.Graphics.DrawRectangle(selectedPen, new Rectangle(e.CellBounds.Left + 2, e.CellBounds.Top + 2, e.CellBounds.Width - 4, e.CellBounds.Height - 4));

                    //Handled painting for this cell, Stop default rendering.
                    e.Handled = true;
                }
            }
        }

        #endregion


    }
}
