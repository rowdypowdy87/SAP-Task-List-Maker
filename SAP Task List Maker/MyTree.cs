using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace SAP_Task_List_Maker
{
    public class MyTree : TreeView
    {
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams parms = base.CreateParams;
                parms.Style |= 0x80;  // Turn on TVS_NOTOOLTIPS 
                return parms;
            }
        }
    }
}
