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
    // This class is a wrapper for the Microsoft Data Application Block "SqlHelper" class
    // which further simplifies running Sql commands against the database.
    // There are 5 basic uses:
    // ExecuteScalar(query [, sqlParameters])
    // -- Returns single value (as type object; cast accordingly).
    // -- E.g. Can be used to get SCOPE_IDENTITY after an insert
    // string insertGetID = "Insert Into TableName (columns) Values (vals); Select Convert(int, Scope_Identity());";
    //  int newID = (int)Db.ExecuteScalar(insertGetID);

    // ExecuteReader(query [, sqlParameters])
    // -- Returns SqlDataReader containing rows from query
    // -- Be sure to close the reader when done to also close its connection
    // using (SqlDataReader rdr = Db.ExecuteReader(selectQuery))
    // { /* process rows */ }

    // ExecuteNonQuery(query [, sqlParameters])
    // -- Returns number of rows affected by query (e.g. UPDATE command)
    // int modified = (int)Db.ExecuteNonQuery(updateCommand);

    // ExecuteDataset(query [, sqlParameters])
    // -- Returns dataset result of query
    // Dataset ds = Db.ExecuteDataset(selectQuery);

    // ReadQuery<T>(query [, sqlParameters])
    // -- Uses Reflection to turn query result into a List<T> of desired objects.
    // -- Class must have properties which match column names returned by query.
    // -- Handy way to turn a table into a List of objects.
    // string selectQuery = "Select UserID, sUserName As Username, sPassword As Password From Users";
    // List<User> users = Db.ReadQuery<User>(selectQuery);
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

        private static T Cast<T>(T target, object source) {
            return (T)source;
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
                                if (type.IsEnum) {
                                    Type enumType = type.GetEnumUnderlyingType();
                                    info.SetValue(i, Cast(Activator.CreateInstance(enumType), rdr[info.Name]));
                                } else {
                                    info.SetValue(i, Convert.ChangeType(rdr[info.Name], type), null);
                                }
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
            //return ConfigurationManager.ConnectionStrings["FileAid.Properties.Settings.Setting"].ConnectionString;
        }
    }
}
