using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace SAP_Task_List_Maker 
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Create local data path
            Global.CreateContentFolders();

            Debug.Print(Global.DocPath);

            // Standard startup
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
        }
    }
}
