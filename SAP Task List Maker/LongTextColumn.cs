using System;
using System.Windows.Forms;

namespace SAP_Task_List_Maker 
{
    // Create a editing contorl that overrides enter
    public class LongTextEditingControl : DataGridViewTextBoxEditingControl
    {
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
                    int oldSelectionStart = SelectionStart;
                    string currentText = Text;

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

    public class LongTextBoxCell : DataGridViewTextBoxCell
    {
        public override Type EditType
        {
            get
            {
                return typeof(LongTextEditingControl);
            }
        }
    }

    /// <summary>
    /// Template class for LongText column
    /// </summary>
    public class LongTextColumn : DataGridViewColumn
    {
        public LongTextColumn()
        {
            CellTemplate = new LongTextBoxCell();
        }
    }
}

