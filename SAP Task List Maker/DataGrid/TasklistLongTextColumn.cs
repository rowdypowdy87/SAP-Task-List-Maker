using System;
using System.Drawing;
using System.Windows.Forms;

namespace SAP_Task_List_Maker 
{
    // Create a editing contorl that overrides enter
    public class TasklistLongTextEditingControl : TasklistEditingControl
    {
        public TasklistLongTextEditingControl()
        {
            WordWrap = true;
        }

        public override void PrepareEditingControlForEdit(bool selectAll)
        {
            base.PrepareEditingControlForEdit(selectAll);
        }

        public override bool EditingControlWantsInputKey(Keys keyData, bool dataGridViewWantsInputKey)
        {
            switch (keyData & Keys.KeyCode)
            {
                case Keys.Enter:
                    // Don't let the DataGridView handle the Enter key.
                    return true;
                default:
                    break;
            }

            return base.EditingControlWantsInputKey(keyData, dataGridViewWantsInputKey);
        }

        // Override keydown event
        protected override void OnKeyDown(KeyEventArgs e)
        {
            switch (e.KeyCode & Keys.KeyCode)
            {
                case Keys.Enter:
                    int     oldSelectionStart   = SelectionStart;
                    string  currentText         = Text;

                    Text = String.Format("{0}{1}{2}",
                                         currentText[0..SelectionStart],
                                         Environment.NewLine,
                                         currentText[(SelectionStart + SelectionLength)..]);

                    SelectionStart = oldSelectionStart + Environment.NewLine.Length;
                    break;

                default:
                    break;
            }

            base.OnKeyDown(e);
        }
    }

    public class TasklistLongTextBoxCell : TasklistCell
    {
        
        public override Type EditType
        {
            get
            {
                return typeof(TasklistLongTextEditingControl);
            }
        }
    }

    /// <summary>
    /// Template class for LongText column
    /// </summary>
    public class TasklistLongTextColumn : TasklistColumn
    {
        public TasklistLongTextColumn()
        {
            CellTemplate = new TasklistLongTextBoxCell();
        }
    }
}

