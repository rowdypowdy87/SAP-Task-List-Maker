﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace SAP_Task_List_Maker
{
    public partial class InputCEL : Form
    {
        public struct _LIST
        {
            public string Name;
            public string Tab;
            public string EQ;
        }

        private readonly ExcelDataTables        ImportManager   = new ExcelDataTables();
        private readonly List<_LIST>            ImportList      = new List<_LIST>();
        private readonly List<_LIST>            EqList          = new List<_LIST>();
        private readonly MainWindow             ParentWindow;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="Par">Main window handle</param>
        public InputCEL(MainWindow Par)
        {
            InitializeComponent();

            ParentWindow = Par;
            
            // Position in centre of parent window
            int X    = ParentWindow.Left + (ParentWindow.Width / 2)  - (Width / 2);
            int Y    = ParentWindow.Top  + (ParentWindow.Height / 2) - (Height / 2);
            Location = PointToClient(new Point(X, Y));
            TopMost  = true;
            
        }

        /// <summary>
        /// Load CEL data
        /// </summary>
        private void InputCEL_Load(object sender, EventArgs e)
        {
            ParentWindow.SetStatusProgress("Initializing CEL & Equipment data bases... (please wait)", 25);

            // Open excel data table
            DataTable CELs = ImportManager.ConvertExcelToDataTable(@"\\prod.local\SharedData\AUWA22\Data\SITE MANAGEMENT SYSTEMS\SAP MANAGEMENT SYSTEMS\TOOL DATABASES\1002_CollectiveEntryLists.xlsm", "REGISTER");

            // Check for success
            if (CELs != null)
            {
                for (int i = 0; i < CELs.Rows.Count; i++)
                {
                    // Build structure to add to global list
                    _LIST ToAdd = new _LIST()
                    {
                        Name = CELs.Rows[i][0].ToString(),
                        Tab  = CELs.Rows[i][1].ToString(),
                        EQ   = CELs.Rows[i][2].ToString()
                    };

                    // Add to global list
                    ImportList.Add(ToAdd);

                    CELListCB.Items.Add(ToAdd.Name);
                }

                // Free memory
                CELs.Dispose();
            }

            // Open excel data table
            DataTable EQs = ImportManager.ConvertExcelToDataTable(@"\\prod.local\SharedData\AUWA22\Data\SITE MANAGEMENT SYSTEMS\SAP MANAGEMENT SYSTEMS\TOOL DATABASES\1002_GeneralInputs.xlsx", "TEMPLATES");

            // Check for success
            if (EQs != null)
            {
                for (int i = 0; i < EQs.Rows.Count; i++)
                {
                    // Build structure to add to global list
                    _LIST ToAdd = new _LIST()
                    {
                        Name = EQs.Rows[i][0].ToString(),
                        EQ = EQs.Rows[i][1].ToString(),
                    };

                    // Add to global list
                    EqList.Add(ToAdd);
                }

                // Free memory
                EQs.Dispose();
            }
        }

        /// <summary>
        /// Do the import
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImportButton_Click(object sender, EventArgs e)
        {
            ParentWindow.SetStatusProgress("Importing selected entry list..", 50);

            // Open excel data table
            DataTable CELs = ImportManager.ConvertExcelToDataTable(@"\\prod.local\SharedData\AUWA22\Data\SITE MANAGEMENT SYSTEMS\SAP MANAGEMENT SYSTEMS\TOOL DATABASES\1002_CollectiveEntryLists.xlsm", ImportList[CELListCB.SelectedIndex].Tab);

            string EqNumber = "";

            // Find equipment number
            for(int i = 0; i < EqList.Count; i++)
            {
                if (EqList[i].Name == ImportList[CELListCB.SelectedIndex].EQ)
                    EqNumber = EqList[i].EQ;
            }

            // Verify we got an equipment number
            if (EqNumber == "")
            {
                EqNumber = Microsoft.VisualBasic.Interaction.InputBox("Please enter the template equipment number");

                if(EqNumber == "")
                    return;
            }

            if(ParentWindow.TasklistData)
                ParentWindow.SetStatusProgress("Importing template equipment", 70);
            else
                ParentWindow.SetStatusProgress("Importing template equipment", 90);

            // Load measurements
            switch (ParentWindow.MeasurementManager.LoadMeasurements(EqNumber))
            {
                case SAPERROR.SAP_NOT_CONNECTED: MsgBoxs.MsgBox_Error("Please ensure SAP is running to continue"); break;
                case SAPERROR.NONE: ParentWindow.EQData = true; break;
            }

            // Check for success
            if (CELs != null)
            {
                // Add entry list into tool
                for (int i = 0; i < CELs.Rows.Count;i++)
                {
                    string Pos  = CELs.Rows[i][0].ToString();
                    string Sort = CELs.Rows[i][2].ToString();
                    string Desc = CELs.Rows[i][1].ToString();

                    // Add to the CEL data grid
                    ParentWindow.DGVCEL.Rows.Add (new string[]{ Pos, Desc, Sort });

                    // Add measures to tasklist
                    if (ParentWindow.TasklistData)
                    {
                        string Op, SubOp, Chk;

                        Chk     = Sort.Substring(4,2);
                        Op      = Sort.Substring(0, 4);

                        if (Chk != "--")
                            SubOp   = Sort.Substring(5, 4);
                        else
                            SubOp   = "";

                        // Cycle through tasklist and add measurements
                        for(int ii = 0; ii < ParentWindow.DGVBody.Rows.Count; ii++)
                        {
                            string TLOp  = ParentWindow.DGVBody[0, ii].Value.ToString();
                            string TLSop = ParentWindow.DGVBody[1, ii].Value.ToString();

                            if (TLOp == Op && TLSop == SubOp)
                            {
                                MeaspointCell Cell = (MeaspointCell)ParentWindow.DGVBody[7,ii];

                                Cell.Attached.Add(ParentWindow.MeasurementManager.GetMeasureByName(Pos,Desc));
                            }
                        }
                    }
                }

                ParentWindow.CELData = true;

                if (!ParentWindow.TasklistData)
                    MsgBoxs.MsgBox_Normal("No tasklist loaded, to match measurements to tasklist use the Add CEL Measures to Tasklist menu item in Control menu");

                // Free memory and close
                CELs.Dispose();
                ParentWindow.SetStatusProgress("", 0);
                Close();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

}
