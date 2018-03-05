using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileAid.Models;
using System.Data.SqlClient;

namespace FileAid.DAL {
    public static class UserServiceDAL {
        public static User Find(string username) {
            // stub
            return Db.ReadQuery<User>("stub")[0];
        }

        public static bool VerifyCredentials(User u) {
            // stub
            return false;
        }

        public static void IncrementFailures(int userID) {
            if (userID <= 0) return; // not required but prevents an unnecessary db call
            List<SqlParameter> args = new List<SqlParameter>();
            args.Add(new SqlParameter("@UserID", userID));
            string update = "Update Users Set iFailures = iFailures + 1, dUserUpdated = GetDate() " +
                "Where UserID = @UserID And dUserDeleted Is Null;";
            int modifiedRows = (int)Db.ExecuteNonQuery(update, args.ToArray());
        }

        public static void ClearFailures(int userID) {
            if (userID <= 0) return; // not required but prevents an unnecessary db call
            List<SqlParameter> args = new List<SqlParameter>();
            args.Add(new SqlParameter("@UserID", userID));
            string update = "Update Users Set iFailures = 0, dUserUpdated = GetDate() " +
                "Where UserID = @UserID And dUserDeleted Is Null And iFailures <> 0;";
            int modifiedRows = (int)Db.ExecuteNonQuery(update, args.ToArray());
        }

        public static void LockOut(int userID) {
            if (userID <= 0) return; // not required but prevents an unnecessary db call
            List<SqlParameter> args = new List<SqlParameter>();
            args.Add(new SqlParameter("@UserID", userID));
            // Only set lockout date if not already set (is null)
            string update = "Update Users Set dLockedOut = GetDate(), dUserUpdated = GetDate() " +
                "Where UserID = @UserID And dUserDeleted Is Null and dLockedOut Is Null;";
            int modifiedRows = (int)Db.ExecuteNonQuery(update, args.ToArray());
        }

        public static bool IsLockedOut(User u) {
            // stub
            return true;
        }

        public static void Unlock(int userID) {
            if (userID <= 0) return; // not required but prevents an unnecessary db call
            List<SqlParameter> args = new List<SqlParameter>();
            args.Add(new SqlParameter("@UserID", userID));
            // Only clear lockout date if it exists (is not null)
            string update = "Update Users Set dLockedOut = null, dUserUpdated = GetDate() " +
                "Where UserID = @UserID And dUserDeleted Is Null and dLockedOut Is Not Null;";
            int modifiedRows = (int)Db.ExecuteNonQuery(update, args.ToArray());
        }

        public static void Disable(User u) {
            // stub
        }

        public static void Enable(User u) {
            // stub
        }

        public static void ResetPassword(User u) {
            // stub
        }

        public static void ChangePassword(User u, string newPassword) {
            // stub
        }
    }
}
