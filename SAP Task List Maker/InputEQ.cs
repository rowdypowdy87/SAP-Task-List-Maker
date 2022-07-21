using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace SAP_Task_List_Maker
{
    public partial class InputEQ : Form
    {
        public struct EQ_LIST
        {
            public string Name;
            public string Number;
        }

        private readonly ExcelDataTables     ImportManager   = new ExcelDataTables();
        private readonly List<EQ_LIST>       ImportList      = new List<EQ_LIST>();
        private readonly MainWindow          ParentWindow;
        public  string   ReturnNumber { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="Par">Main window handle</param>
        public InputEQ(MainWindow Par)
        {
            InitializeComponent();

            ParentWindow = Par;

            // Position in centre of parent window
            Left = ParentWindow.Left + (ParentWindow.Width / 2)  - (Width / 2);
            Top  = ParentWindow.Top  + (ParentWindow.Height / 2) - (Height / 2);
        }

        /// <summary>
        /// Load CEL data
        /// </summary>
        private void InputEQ_Load(object sender, EventArgs e)
        {
            // Open excel data table
            DataTable EQs = ImportManager.ConvertExcelToDataTable(@"https://uglltd.sharepoint.com/:x:/s/fs/EWUbDSrtQ_NIoHMdktH4FJEBcxBvqeRt1l-3oG2ZSEfIYg?e=CVQ5S1", "TEMPLATES");

            // Check for success
            if (EQs != null)
            {
                for (int i = 0; i < EQs.Rows.Count; i++)
                {
                    // Build structure to add to global list
                    EQ_LIST ToAdd = new EQ_LIST()
                    {
                        Name    = EQs.Rows[i][0].ToString(),
                        Number  = EQs.Rows[i][1].ToString(),
                    };

                    // Add to global list
                    ImportList.Add(ToAdd);

                    EQListCB.Items.Add(ToAdd.Name);
                }

                // Free memory
                EQs.Dispose();
            }
        }

        private void ImportButton_Click(object sender, EventArgs e)
        {
            ReturnNumber = ImportList[EQListCB.SelectedIndex].Number.ToString();
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            ReturnNumber = "";
            Close();
        }
    }
}
