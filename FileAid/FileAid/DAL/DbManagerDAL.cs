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
                backupConn.ConnectionString = 
                    ConfigurationManager.ConnectionStrings["FileAidDBConnectionString"].ConnectionString; ;
                backupConn.Open();

                using (SqlCommand backupcomm = new SqlCommand()) {
                    backupcomm.Connection = backupConn;
                    backupcomm.CommandText = @"BACKUP DATABASE FileAidDB TO DISK='c:\FileAidDB.bak'";
                    backupcomm.ExecuteNonQuery();
                }
                backupConn.Close();
            }
        }

        public static void Restore(string srcName) {
            // stub
        }
    }
}
