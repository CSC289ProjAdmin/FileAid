using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileAid.Models;
using System.Data.SqlClient;

namespace FileAid.DAL {
    public static class LoginManagerDAL {
        public static List<Login> GetLogins() {
            string select = "Select LoginID, UserID, dLogin As OccurredOn " +
                "From Logins Where dLoginDeleted Is Null;";
            return Db.ReadQuery<Login>(select);
        }

        public static Login GetLogin(int loginID) {
            if (loginID <= 0) return null;
            List<SqlParameter> args = new List<SqlParameter>();
            args.Add(new SqlParameter("@LoginID", loginID));
            string select = "Select LoginID, UserID, dLogin As OccurredOn " +
                "From Logins Where dLoginDeleted Is Null And LoginID = @LoginID;";
            List<Login> results = Db.ReadQuery<Login>(select, args.ToArray());
            if (results != null) {
                return results[0];
            } else {
                return null;
            }
        }

        public static int AddLogin(int userID) {
            List<SqlParameter> args = new List<SqlParameter>();
            args.Add(new SqlParameter("@UserID", userID));
            string insert = "Insert Into Logins (UserID, dLogin, dLoginCreated, dLoginUpdated) " +
                "Values (@UserID, GetDate(), GetDate(), GetDate()); " +
                "Select Convert(int, Scope_Identity());";
            int newID = -999;
            try {
                newID = (int)Db.ExecuteScalar(insert, args.ToArray());
            } catch (SqlException) {
            }
            return newID;
        }
    }
}
