using System;
using System.Windows.Forms;

namespace SAP_Task_List_Maker
{
    public partial class InputTasklistNumber : Form
    {
        // Global variables
        public bool Cancel = false;

        /// <summary>
        /// Constructor method
        /// </summary>
        public InputTasklistNumber()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Close the form and continue
        /// </summary>
        private void OkButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Cancel the download
        /// </summary>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Cancel = true;
        }
    }
}
