using System;
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
            if (!Directory.Exists(Global.AppDataPath))
                Directory.CreateDirectory(Global.AppDataPath);

            // Standard startup
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
        }
    }
}
