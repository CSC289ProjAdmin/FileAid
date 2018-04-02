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
            } catch (SqlException) {
                return false;
            }
            return true;
        }

        public static bool Restore(string srcName) {
            try {
                string setSingleUser = "Alter Database FileAidDB Set Single_User With Rollback Immediate;";
                Db.ExecuteNonQuery(setSingleUser);

                string restoreDb = "Use Master; Restore Database FileAidDB From Disk = '" + srcName + "' With Replace;";
                Db.ExecuteNonQuery(restoreDb);

                string setMultiUser = "Alter Database FileAidDB Set Multi_User;";
                Db.ExecuteNonQuery(setMultiUser);
            }
            catch (SqlException) {
                return false;
            }
            return true;
        }

        private static string Timestamp() {
            return DateTime.Now.ToString("yyyyMMdd_HHmmss");
        }
    }
}
