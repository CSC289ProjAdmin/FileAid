using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using FileAid.GUI;

namespace FileAid {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            /* NOTE: THIS SECTION IS TO BE ADDED / UNCOMMENTED BEFORE DEPLOYING */
            bool isFirstRun = System.Deployment.Application.ApplicationDeployment.CurrentDeployment.IsFirstRun;
            if (isFirstRun) {
                bool wasInitialized = InitFirstRun();
                MessageBox.Show(wasInitialized ? "Initialized FileAid database." : "Failed to initialize FileAid database.");
            }
            // */

            Application.Run(new FormFileAidDash());
        }

        static bool InitFirstRun() {
            // Backup clean database for safekeeping
            string destFolderName = System.Windows.Forms.Application.CommonAppDataPath;
            if (!destFolderName.EndsWith(@"\")) destFolderName += @"\";
            string filename = destFolderName + @"Data\FileAidDB_Reset.bak";
            System.IO.FileInfo fi = new System.IO.FileInfo(filename);
            if (fi.Exists) return false; // clean backup already exists
            try {
                string stopActivity = "Use Master; Alter Database FileAidDB Set Multi_User With Rollback Immediate;";
                DAL.Db.ExecuteNonQuery(stopActivity);
                System.Data.SqlClient.SqlConnection.ClearAllPools();
                string backupDb = "Backup Database FileAidDB To Disk = '" + filename + "' With Init";
                DAL. Db.ExecuteNonQuery(backupDb);
            }
            catch (System.Data.SqlClient.SqlException) {
                return false;
            }
            return true;
        }
    }
}
