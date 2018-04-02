using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileAid.Models;
using System.Data.SqlClient;
using System.Configuration;

namespace FileAid.DAL {
    public static class DbManagerDAL {
        public static void Reset() {
            // stub
        }

        public static bool Backup(string destFolderName) {
            try {
                string stopActivity = "Use Master; Alter Database FileAidDB Set Multi_User With Rollback Immediate;";
                Db.ExecuteNonQuery(stopActivity);
                SqlConnection.ClearAllPools();

                if (!destFolderName.EndsWith(@"\")) destFolderName += @"\";
                string filename = destFolderName + "FileAidDB_" + Timestamp() + ".bak";
                string backupDb = "Backup Database FileAidDB To Disk = '" + filename + "'";
                Db.ExecuteNonQuery(backupDb);
            }
            catch (SqlException) {
                return false;
            }
            return true;
        }

        public static void Restore(string srcName) {
            using (SqlConnection restoreConn = new SqlConnection()) {
                //restoreConn.ConnectionString = ConfigurationManager.ConnectionStrings["FileAidDBConnectionString"].ConnectionString;
                restoreConn.ConnectionString =
                ConfigurationManager.ConnectionStrings["FileAid.Properties.Settings.Setting"].ConnectionString;
                restoreConn.Open();
                using (SqlCommand restoreCmd = new SqlCommand()) {
                    string database = @"FileAidDB"; // need to get programmatically

                    string sqlStmt2 = string.Format("ALTER DATABASE [" + database + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
                    SqlCommand bu2 = new SqlCommand(sqlStmt2, restoreConn);
                    bu2.ExecuteNonQuery();

                    string backupname = @"C:\Temp\FileAidDB_20180401_210001.bak"; // Get from user and validate
                    string sqlStmt3 = "USE MASTER RESTORE DATABASE [" + database + "] FROM DISK='"
                        + backupname + "' WITH REPLACE;";
                    restoreCmd.Connection = restoreConn;
                    restoreCmd.CommandText = sqlStmt3;
                    restoreCmd.ExecuteNonQuery();

                    string sqlStmt4 = string.Format("ALTER DATABASE [" + database + "] SET MULTI_USER");
                    SqlCommand bu4 = new SqlCommand(sqlStmt4, restoreConn);
                    bu4.ExecuteNonQuery();
                }
            }
        }

        private static string Timestamp() {
            return DateTime.Now.ToString("yyyyMMdd_HHmmss");
        }
    }
}
