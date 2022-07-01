using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace SAP_Task_List_Maker 
{
    // Create a editing contorl that overrides enter
    public class MeaspointEditingControl : DataGridViewTextBoxEditingControl
    {
        
        /// <summary>
        /// Constructor method
        /// </summary>
        public MeaspointEditingControl()
        {
            WordWrap  = true;
            AllowDrop = true;
        }

        /// <summary>
        /// Stops wierd bug where everything goes black on first edit of cell
        /// </summary>
        public override void PrepareEditingControlForEdit(bool selectAll)
        {
            Refresh();
            base.PrepareEditingControlForEdit(false);
        }
    }

    public class MeaspointCell : DataGridViewTextBoxCell
    {
        // List of measurements on this cell
        public List<int> Attached = new();

        public override Type EditType
        {
            get 
            { 
                return typeof(MeaspointEditingControl); 
            }
        }
    }

    /// <summary>
    /// Template class for LongText column
    /// </summary>
    public class MeaspointCol : DataGridViewColumn
    {
        public MeaspointCol()
        {
            CellTemplate = new MeaspointCell();
        }
    }
}

