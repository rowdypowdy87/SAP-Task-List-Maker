using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace SAP_Task_List_Maker
{
    public partial class InputCEL : Form
    {
        public struct CEL_LIST
        {
            public string Name;
            public string Tab;
        }

        private readonly ExcelDataTables     ImportManager   = new ExcelDataTables();
        private readonly List<CEL_LIST>      ImportList      = new List<CEL_LIST>();
        private readonly MainWindow          ParentWindow;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="Par">Main window handle</param>
        public InputCEL(MainWindow Par)
        {
            InitializeComponent();

            ParentWindow = Par;
            
            // Position in centre of parent window
            Left = ParentWindow.Left + (ParentWindow.Width / 2) - (Width / 2);
            Top = ParentWindow.Top + (ParentWindow.Height / 2) - (Height / 2);
        }

        /// <summary>
        /// Load CEL data
        /// </summary>
        private void InputCEL_Load(object sender, EventArgs e)
        {
            // Open excel data table
            DataTable CELs = ImportManager.ConvertExcelToDataTable(@"https://uglltd.sharepoint.com/sites/fs/AdminLibrary/Forms/AllItems.aspx?id=%2Fsites%2Ffs%2FAdminLibrary%2FMobility%20Setup%20Tool%20Databases/1002_CollectiveEntryLists.xlsm", "REGISTER");

            // Check for success
            if (CELs != null)
            {
                for (int i = 0; i < CELs.Rows.Count; i++)
                {
                    // Build structure to add to global list
                    CEL_LIST ToAdd = new CEL_LIST()
                    {
                        Name = CELs.Rows[i][0].ToString(),
                        Tab = CELs.Rows[i][1].ToString(),
                    };

                    // Add to global list
                    ImportList.Add(ToAdd);

                    CELListCB.Items.Add(ToAdd.Name);
                }

                // Free memory
                CELs.Dispose();
            }
        }

        private void ImportButton_Click(object sender, EventArgs e)
        {
            // Open excel data table
            DataTable CELs = ImportManager.ConvertExcelToDataTable(@"https://uglltd.sharepoint.com/sites/fs/AdminLibrary/Forms/AllItems.aspx?id=%2Fsites%2Ffs%2FAdminLibrary%2FMobility%20Setup%20Tool%20Databases/1002_CollectiveEntryLists.xlsm", ImportList[CELListCB.SelectedIndex].Tab);

            // Check for success
            if (CELs != null)
            {
                // Add entry list into tool
                for (int i = 0; i < CELs.Rows.Count;i++)
                {
                    ParentWindow.DGVCEL.Rows.Add (new string[]{ CELs.Rows[i][0].ToString(),     // Position
                                                                CELs.Rows[i][1].ToString(),     // Desc
                                                                CELs.Rows[i][2].ToString() });  // Sort Order
                }

                // Free memory and close
                CELs.Dispose();
                Close();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
