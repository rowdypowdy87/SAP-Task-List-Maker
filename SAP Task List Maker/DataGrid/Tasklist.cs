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
            CellBorderStyle = DataGridViewCellBorderStyle.Single;
            
            DataGridViewCellStyle CellStyle = new DataGridViewCellStyle()
            {
                Font = new Font("Calibri", 9.0f, FontStyle.Regular),
                SelectionForeColor = Color.Black,
                SelectionBackColor = Color.PowderBlue,
                ForeColor = Color.Black,
                BackColor = Color.White,
                WrapMode = DataGridViewTriState.True
            };

            DataGridViewCellStyle ColCellStyle = new DataGridViewCellStyle()
            {
                Font = new Font("Calibri", 9.0f, FontStyle.Bold),
                SelectionForeColor = Color.Black,
                SelectionBackColor = Color.Gray,
                ForeColor = Color.Black,
                BackColor = Color.Gray,
                WrapMode = DataGridViewTriState.True
            };

            ColumnHeadersDefaultCellStyle = ColCellStyle;
            DefaultCellStyle              = CellStyle;

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

            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);    
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

       
       
    }
}
