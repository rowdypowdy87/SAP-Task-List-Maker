using System;

namespace SAP_Task_List_Maker
{
    /// <summary>
    /// Static class to hold all global variables
    /// </summary>
    public static class Global
    {
        public static readonly string AppDataPath = $"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\\SAP_TaskListManager\\";

    }
}
