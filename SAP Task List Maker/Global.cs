using System;
using System.IO;

namespace SAP_Task_List_Maker
{
    /// <summary>
    /// Static class to hold all global variables
    /// </summary>
    public static class Global
    {
        public static readonly string AppDataPath   = $"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\\SAP_TaskListManager\\";
        public static readonly string DocPath       = $"{Environment.GetEnvironmentVariable("USERPROFILE")}\\Documents\\SAP\\SAP_TaskListManager\\";

        public static void CreateContentFolders()
        {
            if (!Directory.Exists(AppDataPath))     
                Directory.CreateDirectory(AppDataPath);
            if (!Directory.Exists(DocPath))         
                Directory.CreateDirectory(DocPath);
        }

    }
}
