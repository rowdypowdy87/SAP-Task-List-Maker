using System;
using System.Drawing;
using System.Windows.Forms;

namespace SAP_Task_List_Maker 
{
    /// <summary>
    /// Main parent template for cells in data grid - TaskList
    /// </summary>
    public class TasklistEditingControl : DataGridViewTextBoxEditingControl
    {
        public TasklistEditingControl()
        {
            WordWrap = true;
        }

        /// <summary>
        /// Stops wierd bug where everything goes black on first edit of cell
        /// </summary>
        public override void PrepareEditingControlForEdit(bool selectAll)
        {
            Invalidate(true);
            base.PrepareEditingControlForEdit(selectAll);
        }

        /// <summary>
        /// Re-draw 
        /// </summary>
        protected override void InitLayout()
        {
            base.InitLayout();
            Invalidate(true);
        }
    }

    public class TasklistCell : DataGridViewTextBoxCell
    {
        // Shrink the content editing panel
        public override Rectangle PositionEditingPanel(Rectangle cellBounds, Rectangle cellClip, DataGridViewCellStyle cellStyle, bool singleVerticalBorderAdded, bool singleHorizontalBorderAdded, bool isFirstDisplayedColumn, bool isFirstDisplayedRow)
        {
            cellBounds.Inflate(-2, -2);

            return base.PositionEditingPanel(cellBounds, cellClip, cellStyle, singleVerticalBorderAdded, singleHorizontalBorderAdded, isFirstDisplayedColumn, isFirstDisplayedRow);
        }

        public override Type EditType
        {
            get 
            { 
                return typeof(TasklistEditingControl); 
            }
        }
    }

    /// <summary>
    /// Template class for LongText column
    /// </summary>
    public class TasklistColumn : DataGridViewColumn
    {
        public TasklistColumn()
        {
            CellTemplate = new TasklistCell();
        }
    }
}

