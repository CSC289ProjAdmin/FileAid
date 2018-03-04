using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;

namespace FileAid.DAL {
    public static class Db {
        public static object ExecuteScalar(string commandText, SqlParameter[] sqlParams) {
            return MSSQL.SqlHelper.ExecuteScalar(GetConnectionString(),
                CommandType.Text, commandText, sqlParams);
        }

        public static object ExecuteScalar(string commandText) {
            // pass through to overload providing null for the set of SqlParameters
            return ExecuteScalar(commandText, null);
        }

        public static SqlDataReader ExecuteReader(string commandText, SqlParameter[] sqlParams) {
            return MSSQL.SqlHelper.ExecuteReader(GetConnectionString(),
                CommandType.Text, commandText, sqlParams);
        }

        public static SqlDataReader ExecuteReader(string commandText) {
            // pass through to overload providing null for the set of SqlParameters
            return ExecuteReader(commandText, null);
        }

        public static int ExecuteNonQuery(string commandText, SqlParameter[] sqlParams) {
            return MSSQL.SqlHelper.ExecuteNonQuery(GetConnectionString(),
                CommandType.Text, commandText, sqlParams);
        }

        public static int ExecuteNonQuery(string commandText) {
            // pass through to overload providing null for the set of SqlParameters
            return ExecuteNonQuery(commandText, null);
        }

        public static DataSet ExecuteDataset(string commandText, SqlParameter[] sqlParams) {
            return MSSQL.SqlHelper.ExecuteDataset(GetConnectionString(),
                CommandType.Text, commandText, sqlParams);
        }

        public static DataSet ExecuteDataset(string commandText) {
            // pass through to overload providing null for the set of SqlParameters
            return ExecuteDataset(commandText, null);
        }

        public static List<T> ReadQuery<T>(string commandText, SqlParameter[] sqlParams) {
            List<T> result = new List<T>();
            using (SqlDataReader rdr = ExecuteReader(commandText, sqlParams)) {
                if (rdr.HasRows) {
                    while (rdr.Read()) {
                        // Create object of correct type
                        var i = Activator.CreateInstance<T>();
                        // Get list of type's properties
                        PropertyInfo[] props = i.GetType().GetProperties();
                        foreach (PropertyInfo info in props) {
                            Type type = info.PropertyType;
                            // Assign value to property if column in table row has matching name and a value
                            if (!DBNull.Value.Equals(rdr[info.Name])) {
                                info.SetValue(i, Convert.ChangeType(rdr[info.Name], type), null);
                            }
                        }
                        result.Add(i);
                    }
                } else {
                    return null;
                }
            }
            return result;
        }

        public static List<T> ReadQuery<T>(string commandText) {
            // pass through to overload providing null for the set of SqlParameters
            return ReadQuery<T>(commandText, null);
        }

        private static string GetConnectionString() {
            return ConfigurationManager.ConnectionStrings["FileAidDBConnectionString"].ConnectionString;
        }
    }
}
