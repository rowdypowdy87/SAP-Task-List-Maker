﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using SAPFEWSELib;
using Microsoft.SharePoint.Client;
using System.Security;
using System.Net;

namespace SAP_Task_List_Maker
{
    public struct TASKLISTNAMES
    {
        public string Header;
        public string Operations;
        public string Components;
        public string PRT;
        public string LongText;
    }

    // Structure to hold measurements for the collective entry list
    public struct CEL_ENTRY
    {
        public string               Operation;
        public string               SubOperation;
        public string               MeasPosition;
        public MobilityMeasurement  MeasureDetails;
    }

    public class ImportExport
    {
        // Global variables
        private readonly MainWindow      WinParent;
        private readonly AUTOSAP         Session;
        private readonly ExcelDataTables TableManager;
        public List<CEL_ENTRY> CEL                          = new List<CEL_ENTRY>();

        /// <summary>
        /// Contsructor method
        /// </summary>
        /// <param name="rWinParent">WinParent window from which this instance is created </param>
        public ImportExport(MainWindow rWinParent)
        {
            WinParent    = rWinParent;
            Session      = new AUTOSAP(WinParent);
            TableManager = new ExcelDataTables();
        }


        public bool DownloadFromSharePoint(string Link, string SavePath)
        {
            using (ClientContext ClientCtx = new ClientContext("https://uglltd.sharepoint.com/sites/fs/"))
            {
                ExceptionHandlingScope scope = new ExceptionHandlingScope(ClientCtx);

                // Variables
                Microsoft.SharePoint.Client.File    FileToDownload;

                using (scope.StartScope())
                { 
                    using (scope.StartTry())
                    { 
                        // Set default credentials
                        Microsoft.SharePoint.Client.List List = ClientCtx.Web.Lists.GetByTitle("Administration Library");
                        Microsoft.SharePoint.Client.ListItem Items = List.GetItemById("FSDS-25-511");

                        ClientCtx.Load(List);
                        ClientCtx.Load(Items);

                        ClientCtx.ExecuteQuery();
                    }

                    using (scope.StartCatch())
                    {
                        Debug.Print(scope.ErrorMessage);
                        Debug.Print(scope.ServerErrorValue);
                    }


                    // Get binary data
                    //var FileInfo = Microsoft.SharePoint.Client.File.OpenBinaryDirect(ClientCtx, FileToDownload.ServerRelativeUrl);

                    // Save locally
                    //using var File = System.IO.File.Create(SavePath);
                    //FileInfo.Stream.CopyTo(File);
                }
            };

            return true;
        }

        /// <summary>
        /// Import data from SAP to memory with use input
        /// </summary>
        public void ImportFromSAP(string TasklistGroup, string TasklistCounter)
        {
            // Vars
            const int WaitTime = 3000;

            // Set status
            WinParent.SetStatusProgress("Initializing files...", 10);

            // Build tasklist name structure
            TASKLISTNAMES TasklistNames = new TASKLISTNAMES()
            {
                Header          = $"{TasklistGroup}{TasklistCounter}HEADER",
                Operations      = $"{TasklistGroup}{TasklistCounter}OPERATIONS",
                Components      = $"{TasklistGroup}{TasklistCounter}COMPONENTS",
                PRT             = $"{TasklistGroup}{TasklistCounter}PRTS",
                LongText        = $"{TasklistGroup}{TasklistCounter}LONGTEXTS"
            };

            // Create the files
            if (!System.IO.File.Exists($"{Global.DocPath}{TasklistNames.Header}"))       System.IO.File.Create($"{Global.DocPath}{TasklistNames.Header}");
            if (!System.IO.File.Exists($"{Global.DocPath}{TasklistNames.Operations}"))   System.IO.File.Create($"{Global.DocPath}{TasklistNames.Operations}");
            if (!System.IO.File.Exists($"{Global.DocPath}{TasklistNames.Components}"))   System.IO.File.Create($"{Global.DocPath}{TasklistNames.Components}");
            if (!System.IO.File.Exists($"{Global.DocPath}{TasklistNames.PRT}"))          System.IO.File.Create($"{Global.DocPath}{TasklistNames.PRT}");
            if (!System.IO.File.Exists($"{Global.DocPath}{TasklistNames.LongText}"))     System.IO.File.Create($"{Global.DocPath}{TasklistNames.LongText}");

            // Enter SAP
            if (Session.GetSession())
            {
                // Set status
                WinParent.SetStatusProgress("Starting ZCS_TASKLIST", 0);
                // Start tasklist transaction
                Session.StartTransaction("ZCS_TASKLIST");
                // Push select data button
                Session.GetButton("btn[13]").Press();
                // Check general tasklist
                Session.GetCheckBox("PN_IHAN").Selected = true;
                // Enter tasklist group
                Session.GetCTextField("PN_PLNNR-LOW").Text = TasklistGroup;
                // Enter tasklist counter
                Session.GetTextField("PN_PLNAL-LOW").Text = TasklistCounter;
                // Press F8
                Session.SendVKey(8);

                // Set status
                WinParent.SetStatusProgress("Exporting header file", 20);

                // Export header file
                Session.GetFormById("wnd[0]/usr/tabsTS_TASKLIST/tabpHEAD/ssubTAB_HEADER_SA:SAPMZPM01_TASKLIST_MASS:0110/cntlCC_TL_HEADER/shellcont/shell").PressToolbarButton("XLS_EXP");
                Thread.Sleep(WaitTime);

                // Enter file path
                Session.GetFormById("wnd[1]/usr/ctxtDY_PATH").Text = Global.DocPath;
                Session.GetFormById("wnd[1]/usr/ctxtDY_FILENAME").Text = TasklistNames.Header;
                Session.GetFormById("wnd[1]/tbar[0]/btn[0]").Press();

                while (Session.GetActiveWindow().Type != "GuiMainWindow")
                {
                    if (Session.GetActiveWindow().Text == "Select file to export task list header") Session.GetFormById("wnd[1]/tbar[0]/btn[0]").Press();
                    if (Session.GetActiveWindow().Text == "File already exists") Session.GetFormById("wnd[1]/usr/btnBUTTON_1").Press();
                    if (Session.GetActiveWindow().Text == "Information") Session.GetFormById("wnd[1]/tbar[0]/btn[0]").Press();

                    Thread.Sleep(WaitTime);
                }

                Thread.Sleep(WaitTime);

                // Goto operations tab
                Session.GetTab("OPER").Select();
                Thread.Sleep(WaitTime);

                // Set status
                WinParent.SetStatusProgress("Exporting operation file", 40);

                // Export operations file
                ((GuiGridView)Session.GetFormById("wnd[0]/usr/tabsTS_TASKLIST/tabpOPER/ssubTAB_OPER_SA:SAPMZPM01_TASKLIST_MASS:0120/cntlCC_TL_OPER/shellcont/shell")).PressToolbarButton("XLS_EXP");
                Thread.Sleep(WaitTime);

                // Enter file path
                Session.GetFormById("wnd[1]/usr/ctxtDY_PATH").Text = Global.DocPath;
                Session.GetFormById("wnd[1]/usr/ctxtDY_FILENAME").Text = TasklistNames.Operations;
                Session.GetFormById("wnd[1]/tbar[0]/btn[0]").Press();

                while (Session.GetActiveWindow().Type != "GuiMainWindow")
                {
                    if (Session.GetActiveWindow().Text == "Select file to export task list operation") Session.GetFormById("wnd[1]/tbar[0]/btn[0]").Press();
                    if (Session.GetActiveWindow().Text == "File already exists") Session.GetFormById("wnd[1]/usr/btnBUTTON_1").Press();
                    if (Session.GetActiveWindow().Text == "Information") Session.GetFormById("wnd[1]/tbar[0]/btn[0]").Press();

                    Thread.Sleep(WaitTime);
                }

                Thread.Sleep(WaitTime);

                // Goto components tab
                Session.GetTab("COMP").Select();
                Thread.Sleep(WaitTime);

                // Set status
                WinParent.SetStatusProgress("Exporting components file", 60);

                // Export operations file
                Session.GetFormById("wnd[0]/usr/tabsTS_TASKLIST/tabpCOMP/ssubTAB_COMP_SA:SAPMZPM01_TASKLIST_MASS:0130/cntlCC_TL_COMP/shellcont/shell").PressToolbarButton("XLS_EXP");
                Thread.Sleep(WaitTime);

                // Enter file path
                Session.GetFormById("wnd[1]/usr/ctxtDY_PATH").Text = Global.DocPath;
                Session.GetFormById("wnd[1]/usr/ctxtDY_FILENAME").Text = TasklistNames.Components;
                Session.GetFormById("wnd[1]/tbar[0]/btn[0]").Press();

                while (Session.GetActiveWindow().Type != "GuiMainWindow")
                {
                    if (Session.GetActiveWindow().Text == "Select file to export task list component") Session.GetFormById("wnd[1]/tbar[0]/btn[0]").Press();
                    if (Session.GetActiveWindow().Text == "File already exists") Session.GetFormById("wnd[1]/usr/btnBUTTON_1").Press();
                    if (Session.GetActiveWindow().Text == "Information") Session.GetFormById("wnd[1]/tbar[0]/btn[0]").Press();

                    Thread.Sleep(WaitTime);
                }

                Thread.Sleep(WaitTime);

                // Goto PRTs tab
                Session.GetTab("PRTS").Select();
                Thread.Sleep(WaitTime);

                // Set status
                WinParent.SetStatusProgress("Exporting document attachments file", 80);

                // Export prt file
                Session.GetFormById("wnd[0]/usr/tabsTS_TASKLIST/tabpPRTS/ssubTAB_PRTS_SA:SAPMZPM01_TASKLIST_MASS:0140/cntlCC_TL_PRTS/shellcont/shell").PressToolbarButton("XLS_EXP");
                Thread.Sleep(WaitTime);

                // Enter file path
                Session.GetFormById("wnd[1]/usr/ctxtDY_PATH").Text = Global.DocPath;
                Session.GetFormById("wnd[1]/usr/ctxtDY_FILENAME").Text = TasklistNames.PRT;
                Session.GetFormById("wnd[1]/tbar[0]/btn[0]").Press();

                while (Session.GetActiveWindow().Type != "GuiMainWindow")
                {
                    if (Session.GetActiveWindow().Text == "Select file to export task list document attachment") Session.GetFormById("wnd[1]/tbar[0]/btn[0]").Press();
                    if (Session.GetActiveWindow().Text == "File already exists") Session.GetFormById("wnd[1]/usr/btnBUTTON_1").Press();
                    if (Session.GetActiveWindow().Text == "Information") Session.GetFormById("wnd[1]/tbar[0]/btn[0]").Press();

                    Thread.Sleep(WaitTime);
                }

                Thread.Sleep(WaitTime);

                // Goto long text tab
                Session.GetTab("LTEXT").Select();
                Thread.Sleep(WaitTime);

                // Set status
                WinParent.SetStatusProgress("Exporting long texts file", 95);

                // Export operations file
                Session.GetFormById("wnd[0]/usr/tabsTS_TASKLIST/tabpLTEXT/ssubTAB_LTEXT_SA:SAPMZPM01_TASKLIST_MASS:0150/cntlCC_TL_LTEXT/shellcont/shell").PressToolbarButton("XLS_EXP");
                Thread.Sleep(WaitTime);

                // Enter file path
                Session.GetFormById("wnd[1]/usr/ctxtDY_PATH").Text = Global.DocPath;
                Session.GetFormById("wnd[1]/usr/ctxtDY_FILENAME").Text = TasklistNames.LongText;
                Session.GetFormById("wnd[1]/tbar[0]/btn[0]").Press();

                while (Session.GetActiveWindow().Type != "GuiMainWindow")
                {
                    if (Session.GetActiveWindow().Text == "Select file to export task list long texts") Session.GetFormById("wnd[1]/tbar[0]/btn[0]").Press();
                    if (Session.GetActiveWindow().Text == "File already exists") Session.GetFormById("wnd[1]/usr/btnBUTTON_1").Press();
                    if (Session.GetActiveWindow().Text == "Information") Session.GetFormById("wnd[1]/tbar[0]/btn[0]").Press();

                    Thread.Sleep(WaitTime);
                }

                // End trasaction
                Session.EndTransaction();

                // Sleep to let file memory settle
                Thread.Sleep(WaitTime);

                // Set status
                WinParent.SetStatusProgress("Importing tasklist.....", 0);

                // Import
                ImportFromExcelFile(Global.DocPath, TasklistNames);

                // Set status
                WinParent.SetStatusProgress("", 0);
            }
            else
            {
                MsgBoxs.MsgBox_Error("SAP Connection not found, please ensure SAP is running.");
                return;
            }
        }

        /// <summary>
        /// Import data from SAP to memory
        /// </summary>
        public void ImportFromSAP()
        {
            // Vars
            string TasklistCounter, TasklistGroup;
            const  int WaitTime  = 3000;

            // Set status
            WinParent.SetStatusProgress("Initializing files...", 10);

            // Create tasklist info dialog
            InputTasklistNumber TasklistInfo = new InputTasklistNumber();

            // Show modal
            TasklistInfo.ShowDialog();

            // Check for cancel
            if (TasklistInfo.Cancel) return;

            // Get variables
            TasklistGroup   = TasklistInfo.TasklistGroup.Text;
            TasklistCounter = TasklistInfo.TasklistCounter.Text;

            // Build tasklist name structure
            TASKLISTNAMES TasklistNames = new TASKLISTNAMES()
            {
                Header          = $"{TasklistGroup}{TasklistCounter}HEADER",
                Operations      = $"{TasklistGroup}{TasklistCounter}OPERATIONS",
                Components      = $"{TasklistGroup}{TasklistCounter}COMPONENTS",
                PRT             = $"{TasklistGroup}{TasklistCounter}PRTS",
                LongText        = $"{TasklistGroup}{TasklistCounter}LONGTEXTS"
            };

            // Create the files
            if (!System.IO.File.Exists($"{Global.DocPath}{TasklistNames.Header}"))           System.IO.File.Create($"{Global.DocPath}{TasklistNames.Header}");
            if (!System.IO.File.Exists($"{Global.DocPath}{TasklistNames.Operations}"))       System.IO.File.Create($"{Global.DocPath}{TasklistNames.Operations}");
            if (!System.IO.File.Exists($"{Global.DocPath}{TasklistNames.Components}"))       System.IO.File.Create($"{Global.DocPath}{TasklistNames.Components}");
            if (!System.IO.File.Exists($"{Global.DocPath}{TasklistNames.PRT}"))              System.IO.File.Create($"{Global.DocPath}{TasklistNames.PRT}");
            if (!System.IO.File.Exists($"{Global.DocPath}{TasklistNames.LongText}"))         System.IO.File.Create($"{Global.DocPath}{TasklistNames.LongText}");

            // Enter SAP
            if (Session.GetSession())
            {
                // Set status
                WinParent.SetStatusProgress("Starting ZCS_TASKLIST", 0);
                // Start tasklist transaction
                Session.StartTransaction("ZCS_TASKLIST");
                // Push select data button
                Session.GetButton("btn[13]").Press();
                // Check general tasklist
                Session.GetCheckBox("PN_IHAN").Selected     = true;
                // Enter tasklist group
                Session.GetCTextField("PN_PLNNR-LOW").Text  = TasklistGroup;
                // Enter tasklist counter
                Session.GetTextField("PN_PLNAL-LOW").Text   = TasklistCounter;
                // Press F8
                Session.SendVKey(8);

                // Set status
                WinParent.SetStatusProgress("Exporting header file", 20);

                // Export header file
                Session.GetFormById("wnd[0]/usr/tabsTS_TASKLIST/tabpHEAD/ssubTAB_HEADER_SA:SAPMZPM01_TASKLIST_MASS:0110/cntlCC_TL_HEADER/shellcont/shell").PressToolbarButton("XLS_EXP");
                Thread.Sleep(WaitTime);

                // Enter file path
                Session.GetFormById("wnd[1]/usr/ctxtDY_PATH").Text      = Global.DocPath;
                Session.GetFormById("wnd[1]/usr/ctxtDY_FILENAME").Text  = TasklistNames.Header;
                Session.GetFormById("wnd[1]/tbar[0]/btn[0]").Press();

                while(Session.GetActiveWindow().Type != "GuiMainWindow")
                { 
                    if (Session.GetActiveWindow().Text == "Select file to export task list header")    Session.GetFormById("wnd[1]/tbar[0]/btn[0]").Press();
                    if (Session.GetActiveWindow().Text == "File already exists")                       Session.GetFormById("wnd[1]/usr/btnBUTTON_1").Press();
                    if (Session.GetActiveWindow().Text == "Information")                               Session.GetFormById("wnd[1]/tbar[0]/btn[0]").Press();

                    Thread.Sleep(WaitTime);
                }

                Thread.Sleep(WaitTime);

                // Goto operations tab
                Session.GetTab("OPER").Select();
                Thread.Sleep(WaitTime);

                // Set status
                WinParent.SetStatusProgress("Exporting operation file", 40);

                // Export operations file
                ((GuiGridView)Session.GetFormById("wnd[0]/usr/tabsTS_TASKLIST/tabpOPER/ssubTAB_OPER_SA:SAPMZPM01_TASKLIST_MASS:0120/cntlCC_TL_OPER/shellcont/shell")).PressToolbarButton("XLS_EXP");
                Thread.Sleep(WaitTime);

                // Enter file path
                Session.GetFormById("wnd[1]/usr/ctxtDY_PATH").Text = Global.DocPath;
                Session.GetFormById("wnd[1]/usr/ctxtDY_FILENAME").Text = TasklistNames.Operations;
                Session.GetFormById("wnd[1]/tbar[0]/btn[0]").Press();

                while (Session.GetActiveWindow().Type != "GuiMainWindow")
                {
                    if (Session.GetActiveWindow().Text == "Select file to export task list operation")  Session.GetFormById("wnd[1]/tbar[0]/btn[0]").Press();
                    if (Session.GetActiveWindow().Text == "File already exists")                        Session.GetFormById("wnd[1]/usr/btnBUTTON_1").Press();
                    if (Session.GetActiveWindow().Text == "Information")                                Session.GetFormById("wnd[1]/tbar[0]/btn[0]").Press();

                    Thread.Sleep(WaitTime);
                }

                Thread.Sleep(WaitTime);

                // Goto components tab
                Session.GetTab("COMP").Select();
                Thread.Sleep(WaitTime);

                // Set status
                WinParent.SetStatusProgress("Exporting components file", 60);

                // Export operations file
                Session.GetFormById("wnd[0]/usr/tabsTS_TASKLIST/tabpCOMP/ssubTAB_COMP_SA:SAPMZPM01_TASKLIST_MASS:0130/cntlCC_TL_COMP/shellcont/shell").PressToolbarButton("XLS_EXP");
                Thread.Sleep(WaitTime);

                // Enter file path
                Session.GetFormById("wnd[1]/usr/ctxtDY_PATH").Text = Global.DocPath;
                Session.GetFormById("wnd[1]/usr/ctxtDY_FILENAME").Text = TasklistNames.Components;
                Session.GetFormById("wnd[1]/tbar[0]/btn[0]").Press();

                while (Session.GetActiveWindow().Type != "GuiMainWindow")
                {
                    if (Session.GetActiveWindow().Text == "Select file to export task list component")  Session.GetFormById("wnd[1]/tbar[0]/btn[0]").Press();
                    if (Session.GetActiveWindow().Text == "File already exists")                        Session.GetFormById("wnd[1]/usr/btnBUTTON_1").Press();
                    if (Session.GetActiveWindow().Text == "Information")                                Session.GetFormById("wnd[1]/tbar[0]/btn[0]").Press();

                    Thread.Sleep(WaitTime);
                }

                Thread.Sleep(WaitTime);

                // Goto PRTs tab
                Session.GetTab("PRTS").Select();
                Thread.Sleep(WaitTime);

                // Set status
                WinParent.SetStatusProgress("Exporting document attachments file", 80);

                // Export prt file
                Session.GetFormById("wnd[0]/usr/tabsTS_TASKLIST/tabpPRTS/ssubTAB_PRTS_SA:SAPMZPM01_TASKLIST_MASS:0140/cntlCC_TL_PRTS/shellcont/shell").PressToolbarButton("XLS_EXP");
                Thread.Sleep(WaitTime);

                // Enter file path
                Session.GetFormById("wnd[1]/usr/ctxtDY_PATH").Text = Global.DocPath;
                Session.GetFormById("wnd[1]/usr/ctxtDY_FILENAME").Text = TasklistNames.PRT;
                Session.GetFormById("wnd[1]/tbar[0]/btn[0]").Press();

                while (Session.GetActiveWindow().Type != "GuiMainWindow")
                {
                    if (Session.GetActiveWindow().Text == "Select file to export task list document attachment")    Session.GetFormById("wnd[1]/tbar[0]/btn[0]").Press();
                    if (Session.GetActiveWindow().Text == "File already exists")                                    Session.GetFormById("wnd[1]/usr/btnBUTTON_1").Press();
                    if (Session.GetActiveWindow().Text == "Information")                                            Session.GetFormById("wnd[1]/tbar[0]/btn[0]").Press();

                    Thread.Sleep(WaitTime);
                }

                Thread.Sleep(WaitTime);

                // Goto long text tab
                Session.GetTab("LTEXT").Select();
                Thread.Sleep(WaitTime);

                // Set status
                WinParent.SetStatusProgress("Exporting long texts file", 95);

                // Export operations file
                Session.GetFormById("wnd[0]/usr/tabsTS_TASKLIST/tabpLTEXT/ssubTAB_LTEXT_SA:SAPMZPM01_TASKLIST_MASS:0150/cntlCC_TL_LTEXT/shellcont/shell").PressToolbarButton("XLS_EXP");
                Thread.Sleep(WaitTime);

                // Enter file path
                Session.GetFormById("wnd[1]/usr/ctxtDY_PATH").Text = Global.DocPath;
                Session.GetFormById("wnd[1]/usr/ctxtDY_FILENAME").Text = TasklistNames.LongText;
                Session.GetFormById("wnd[1]/tbar[0]/btn[0]").Press();

                while (Session.GetActiveWindow().Type != "GuiMainWindow")
                {
                    if (Session.GetActiveWindow().Text == "Select file to export task list long texts") Session.GetFormById("wnd[1]/tbar[0]/btn[0]").Press();
                    if (Session.GetActiveWindow().Text == "File already exists")                        Session.GetFormById("wnd[1]/usr/btnBUTTON_1").Press();
                    if (Session.GetActiveWindow().Text == "Information")                                Session.GetFormById("wnd[1]/tbar[0]/btn[0]").Press();

                    Thread.Sleep(WaitTime);
                }

                // End trasaction
                Session.EndTransaction();

                // Sleep to let file memory settle
                Thread.Sleep(WaitTime);

                // Set status
                WinParent.SetStatusProgress("Importing tasklist.....", 0);

                // Import
                ImportFromExcelFile(Global.DocPath, TasklistNames);

                // Set status
                WinParent.SetStatusProgress("", 0);
            }
                else
            {
                MsgBoxs.MsgBox_Error("SAP Connection not found, please ensure SAP is running.");
                return;
            }

            // Free memory
            TasklistInfo.Dispose();
        }

        /// <summary>
        /// Imports data from Excel data file to memory
        /// </summary>
        public void ImportFromExcelFile(string FolderPath, TASKLISTNAMES TNames)
        {
            // Variables
            string    LongText;
            DataTable Import;

            // Tell method we are taking it from user
            if (FolderPath == null)
            { 
                // Create a new folder dialog browser
                using OpenFileDialog Dialog = new OpenFileDialog()
                {
                    Filter = "Excel Files (*.xlsx, *xlsm, *.xls)|*.xlsx; *.xlsm; .xls",
                    Title = "Select one of the Excel files you want to import"
                };
                // Show ze dialog for ze user
                Dialog.ShowDialog();
                // Get ze path from the dialog
                FolderPath = Path.GetDirectoryName(Dialog.FileName);
            }

            // Verify ze path
            if (FolderPath == null || FolderPath.Length == 0)
            {
                MsgBoxs.MsgBox_Error("Please select a folder path!");
                return;
            }
            // Check the data files exist
            if (!System.IO.File.Exists($"{FolderPath}{TNames.Header}"))
            {
                MsgBoxs.MsgBox_Error($"Cannot find the header file in location {FolderPath}");
                return;
            }

            if (!System.IO.File.Exists($"{FolderPath}{TNames.Operations}"))
            {
                MsgBoxs.MsgBox_Error($"Cannot find the operations file in location {FolderPath}");
                return;
            }

            if (!System.IO.File.Exists($"{FolderPath}{TNames.Components}"))
            {
                MsgBoxs.MsgBox_Error($"Cannot find the components file in location {FolderPath}");
                return;
            }

            if (!System.IO.File.Exists($"{FolderPath}{TNames.PRT}"))
            {
                MsgBoxs.MsgBox_Error($"Cannot find the document attachments file in location {FolderPath}");
                return;
            }

            if (!System.IO.File.Exists($"{FolderPath}{TNames.LongText}"))
            {
                MsgBoxs.MsgBox_Error($"Cannot find the long texts file in location {FolderPath}");
                return;
            }

            // Import data into memory and application
            Import = TableManager.ConvertExcelToDataTable($"{FolderPath}{TNames.Header}", 0);

            // Set data
            WinParent.DGVHeader.Rows.Add( new string[] { Import.Rows[0][0].ToString(),
                                                         Import.Rows[0][1].ToString(),
                                                         Import.Rows[0][2].ToString(),
                                                         Import.Rows[0][5].ToString(),
                                                         Import.Rows[0][4].ToString(),
                                                         Import.Rows[0][10].ToString() });
            // Clear table for next load
            Import.Clear();

            // Import operations data
            Import = TableManager.ConvertExcelToDataTable($"{FolderPath}{TNames.Operations}", 0);

            for (int i = 0; i < Import.Rows.Count; i++)
            {
                // Add a new row to body DGV
                WinParent.DGVBody.Rows.Add( new string[] { Import.Rows[i][2].ToString().Trim(),         // Operation    
                                                           Import.Rows[i][3].ToString().Trim(),         // Sub operation
                                                           Import.Rows[i][5].ToString().Trim(),         // Description
                                                           "",
                                                           Import.Rows[i][12].ToString().Trim(),        // Work
                                                           Import.Rows[i][13].ToString().Trim(),        // Unit
                                                           Import.Rows[i][15].ToString().Trim(), ""});  // People
 
            }

            // Clear table for next load
            Import.Clear();

            Import = TableManager.ConvertExcelToDataTable($"{FolderPath}{TNames.Components}", 0);

            for (int i = 0; i < Import.Rows.Count; i++)
            {
                WinParent.DGVComponents.Rows.Add(new string[] { Import.Rows[i][4].ToString(),
                                                                "",
                                                                Import.Rows[i][5].ToString(),
                                                                Import.Rows[i][6].ToString() });
            }

            Import.Clear();

            Import = TableManager.ConvertExcelToDataTable($"{FolderPath}\\{TNames.PRT}", 0);

            for (int i = 0; i < Import.Rows.Count; i++)
            {
                WinParent.DGVPRT.Rows.Add(new string[] { Import.Rows[i][2].ToString(),
                                                         Import.Rows[i][7].ToString(),
                                                         "" });
            }

            Import.Clear();

            // Import long text data
            Import = TableManager.ConvertExcelToDataTable($"{FolderPath}{TNames.LongText}", 0);

            for (int i = 0; i < Import.Rows.Count; i++)
            {
                LongText = Import.Rows[i][4].ToString();

                WinParent.DGVBody[3, i].Value = LongText.ReplaceLineEndings();
            }

            // Dispose of the table in memory
            Import.Dispose();

            // Get names of components and docs
            GetDocCompNames();
        }

        /// <summary>
        /// Gets names of components and PRTS
        /// </summary>
        public void GetDocCompNames()
        {
            // Get document descriptions
            if (Session.GetSession())
            {
                // Create string for clip board
                string ClipText = "";

                // Clear clipbioard
                Clipboard.Clear();

                // Set status
                WinParent.SetStatusProgress("Get component names.....", 90);

                // Add all doc numbers to memory
                for (int i = 0; i < WinParent.DGVPRT.Rows.Count; i++)
                    ClipText += $"{WinParent.DGVPRT[1, i].Value}{Environment.NewLine}";

                // Add to clipboard
                Clipboard.SetText(ClipText);

                Session.StartTransaction("CV04N");
                Session.GetButton("%_STDOKNR_%_APP_%-VALU_PUSH").Press();

                Session.GetFormById("wnd[1]").FindByName("btn[24]", "GuiButton").Press();
                Session.GetFormById("wnd[1]").SendVKey(8);

                Thread.Sleep(1000);

                Session.SendVKey(8);

                GuiGridView DocGrid = (GuiGridView)Session.GetFormById("wnd[0]/usr/cntlGRID1/shellcont/shell");

                // Cycle through GridView to find document names
                for(int i = 0; i < DocGrid.RowCount; i++)
                {
                    for(int ii = 0; ii < WinParent.DGVPRT.Rows.Count; ii++)
                    {
                        if (DocGrid.GetCellValue(i, DocGrid.ColumnOrder.ElementAt(1).ToString()) == WinParent.DGVPRT[1, ii].Value.ToString())
                        {
                            WinParent.DGVPRT[2, ii].Value = $"{DocGrid.GetCellValue(i, DocGrid.ColumnOrder.ElementAt(4))} - {DocGrid.GetCellValue(i, DocGrid.ColumnOrder.ElementAt(6))}";
                        }
                    }
                }

                // Clear clipbioard
                Clipboard.Clear();

                // Add all component numbers to memory
                for (int i = 0; i < WinParent.DGVComponents.Rows.Count; i++)
                    ClipText += $"{WinParent.DGVComponents[0, i].Value}{Environment.NewLine}";

                // Add to clipboard
                Clipboard.SetText(ClipText);

                Session.StartTransaction("IH09");
                Session.GetButton("%_MS_MATNR_%_APP_%-VALU_PUSH").Press();

                Session.GetFormById("wnd[1]").FindByName("btn[14]", "GuiButton").Press();
                Session.GetFormById("wnd[1]").FindByName("btn[24]", "GuiButton").Press();
                Session.GetFormById("wnd[1]").SendVKey(8);

                Thread.Sleep(1000);

                Session.GetCTextField("VARIANT").Text = "/FS_DEFAULT";

                Session.SendVKey(8);

                if (Session.GetSessionObj().Info.ScreenNumber == 1000)
                    return;

                if (Session.GetSessionObj().Info.ScreenNumber == 4004)
                {
                    WinParent.DGVComponents[1, 0].Value = Session.GetTextField("MAKT-MAKTX").Text;
                    WinParent.DGVComponents[3, 0].Value = Session.GetCTextField("MARA-MEINS").Text;
                }
                else
                { 
                    GuiGridView CompGrid = (GuiGridView)Session.GetFormById("wnd[0]/usr/cntlGRID1/shellcont/shell");

                    // Open layout boc
                    Session.GetButton("btn[32]").Press();

                    GuiGridView LayoutGrid = Session.GetFormById("wnd[1]").FindByName("CONTAINER1_LAYO", "GuiCustomControl").FindByName("shell", "GuiGridView");

                    // Find unit
                    bool Found = false;
                    for (int i = 0; i < LayoutGrid.RowCount -1; i++)
                    {
                        if (LayoutGrid.GetCellValue(i, LayoutGrid.ColumnOrder.ElementAt(0)).ToString() == "Base Unit of Measure")
                        {
                            LayoutGrid.SetCurrentCell(i, LayoutGrid.ColumnOrder.ElementAt(0));
                            Found = true;
                        }
                    }

                    // Set unit column to layout
                    if (Found)
                    {
                        Session.GetFormById("wnd[1]").FindByName("APP_WL_SING", "GuiButton").Press();
                        Thread.Sleep(1000);
                        Session.GetFormById("wnd[1]/tbar[0]/btn[0]").Press();
                        Thread.Sleep(1000);
                    }
                    else
                        MsgBoxs.MsgBox_Warning("Could not find unit column");

                    // Cycle through GridView to find component names
                    for (int i = 0; i < CompGrid.RowCount; i++)
                    {
                        for (int ii = 0; ii < WinParent.DGVComponents.Rows.Count; ii++)
                        {
                            if (CompGrid.GetCellValue(i, CompGrid.ColumnOrder.ElementAt(0)) == WinParent.DGVComponents[0, ii].Value.ToString())
                            {
                                WinParent.DGVComponents[1, ii].Value = $"{CompGrid.GetCellValue(i, CompGrid.ColumnOrder.ElementAt(1))}";
                                WinParent.DGVComponents[3, ii].Value = $"{CompGrid.GetCellValue(i, "MEINS")}";
                            }
                        }
                    }
                }
            }
        }


        /// <summary>
        /// Saves all data in memory to tasklist maker file
        /// </summary>
        public void SaveAsTasklistFile()
        {

        }

        /// <summary>
        /// Loads a tasklist maker file into memory
        /// </summary>
        /// <param name="FileName">File name and path</param>
        public void LoadTasklistFile(string FileName)
        {
            // Check extension of file
            if (Path.GetExtension(FileName).Equals(".tmf"))
            {

            }
            else
                MsgBoxs.MsgBox_Error($"{FileName} is not a valid Tasklist Maker File!");
            
        }
    }
}
