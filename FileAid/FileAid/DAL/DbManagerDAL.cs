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

        public static void Backup(string destName) {
            //string master_ConnectionString = @"Data Source=(LocalDB)\ProjectsV13;Database=Master;Integrated Security=True;Connect Timeout=30;";
            string master_ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Database=Master;Integrated Security=True;Connect Timeout=30;";

            using (SqlConnection masterdbConn = new SqlConnection()) {
                masterdbConn.ConnectionString = master_ConnectionString;
                masterdbConn.Open();

                using (SqlCommand multiuser_rollback_dbcomm = new SqlCommand()) {
                    multiuser_rollback_dbcomm.Connection = masterdbConn;
                    multiuser_rollback_dbcomm.CommandText = @"ALTER DATABASE FileAidDB SET MULTI_USER WITH ROLLBACK IMMEDIATE";

                    multiuser_rollback_dbcomm.ExecuteNonQuery();
                }
                masterdbConn.Close();
            }

            SqlConnection.ClearAllPools();

            using (SqlConnection backupConn = new SqlConnection()) {
                //backupConn.ConnectionString = 
                    //ConfigurationManager.ConnectionStrings["FileAidDBConnectionString"].ConnectionString;
                backupConn.ConnectionString =
                    ConfigurationManager.ConnectionStrings["FileAid.Properties.Settings.Setting"].ConnectionString;
                backupConn.Open();

                using (SqlCommand backupcomm = new SqlCommand()) {
                    string backupname = @"C:\Temp\FileAidDB_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") +
                        ".bak";
                    backupcomm.Connection = backupConn;
                    backupcomm.CommandText = @"BACKUP DATABASE FileAidDB TO DISK='" +
                        backupname + "'";
                    backupcomm.ExecuteNonQuery();
                }
                backupConn.Close();
            }
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

                    string backupname = @"C:\Temp\FileAidDB.bak"; // Get from user and validate
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
    }
}
