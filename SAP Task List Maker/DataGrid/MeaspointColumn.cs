using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace SAP_Task_List_Maker 
{
    // Create a editing contorl that overrides enter
    public class MeaspointEditingControl : TasklistEditingControl
    {
        
        /// <summary>
        /// Constructor method
        /// </summary>
        public MeaspointEditingControl()
        {
        }
    }

    public class MeaspointCell : TasklistCell
    {
        // List of measurements on this cell
        public List<int> Attached = new();

        // Context menu
        private ContextMenuStrip MeasMenu = new ContextMenuStrip();

        public MeaspointCell()
        {
            // Build context menu
            ToolStripMenuItem Edit = new("Edit Measurements");
            ToolStripMenuItem Clear = new("Clear Measurements");

            // Add to context menu
            MeasMenu.Items.Add(Edit);
            MeasMenu.Items.Add(Clear);

            // Add events to menu items
            Edit.MouseDown  += new(EditMenu_MouseDown);
            Clear.MouseDown += new(ClearMenu_MouseDown);

            // Add icons to menu
            Edit.Image  = Properties.Resources.Pencil;
            Clear.Image = Properties.Resources.Clear;
        }

        protected override void OnMouseClick(DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                MeasMenu.Show(new Point(Control.MousePosition.X, Control.MousePosition.Y));

            base.OnMouseClick(e);
        }

        public override Type EditType
        {
            get 
            { 
                return typeof(MeaspointEditingControl); 
            }
        }

        protected override void Paint(Graphics graphics, Rectangle clipBounds, Rectangle cellBounds, int rowIndex, DataGridViewElementStates cellState, object value, object formattedValue, string errorText, DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle, DataGridViewPaintParts paintParts)
        {

            base.Paint(graphics, clipBounds, cellBounds, rowIndex, cellState, value, formattedValue, errorText, cellStyle, advancedBorderStyle, paintParts);
        }

        private void EditMenu_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void ClearMenu_MouseDown(object sender, MouseEventArgs e)
        {

        }
    }

    /// <summary>
    /// Template class for LongText column
    /// </summary>
    public class MeaspointCol : TasklistColumn
    {
        public MeaspointCol()
        {
            CellTemplate = new MeaspointCell();
        }
    }
}

