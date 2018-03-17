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
            List<SqlParameter> args = new List<SqlParameter>();
            args.Add(new SqlParameter("@Name", username));
            string select = "Select UserID, sUserName As Username, RoleID, iFailures As LoginFailures, " +
                "dLockedOut As LockedOutOn, dUserDisabled As DisabledOn From Users " +
                "Where sUserName = @Name Collate SQL_Latin1_General_CP1_CS_AS And dUserDeleted Is Null;";
            List<User> results = Db.ReadQuery<User>(select, args.ToArray());
            if (results != null) {
                return results[0];
            } else {
                return null;
            }
        }

        public static bool VerifyCredentials(string username, string password) {
            List<SqlParameter> args = new List<SqlParameter>();
            args.Add(new SqlParameter("@Name", username));
            args.Add(new SqlParameter("@Password", password));
            string select = "Select Count(*) From Users " +
                "Where dUserDeleted Is Null And sUserName = @Name Collate SQL_Latin1_General_CP1_CS_AS " +
                "And sPassword = @Password Collate SQL_Latin1_General_CP1_CS_AS;";
            bool matches = ((int)Db.ExecuteScalar(select, args.ToArray()) == 1);
            return matches;
        }

        public static bool IncrementFailures(int userID) {
            if (userID <= 0) return false; // not required but prevents an unnecessary db call
            List<SqlParameter> args = new List<SqlParameter>();
            args.Add(new SqlParameter("@UserID", userID));
            string update = "Update Users Set iFailures = iFailures + 1, dUserUpdated = GetDate() " +
                "Where UserID = @UserID And dUserDeleted Is Null;";
            int modifiedRows = (int)Db.ExecuteNonQuery(update, args.ToArray());
            bool wasIncremented = (modifiedRows == 1);
            return wasIncremented;
        }

        public static bool ClearFailures(int userID) {
            if (userID <= 0) return false; // not required but prevents an unnecessary db call
            List<SqlParameter> args = new List<SqlParameter>();
            args.Add(new SqlParameter("@UserID", userID));
            string update = "Update Users Set iFailures = 0, dUserUpdated = GetDate() " +
                "Where UserID = @UserID And dUserDeleted Is Null And iFailures <> 0;";
            int modifiedRows = (int)Db.ExecuteNonQuery(update, args.ToArray());
            bool wasCleared = (modifiedRows == 1);
            return wasCleared;
        }

        public static bool LockOut(int userID) {
            if (userID <= 0) return false; // not required but prevents an unnecessary db call
            List<SqlParameter> args = new List<SqlParameter>();
            args.Add(new SqlParameter("@UserID", userID));
            // Only set lockout date if not already set (is null)
            string update = "Update Users Set dLockedOut = GetDate(), dUserUpdated = GetDate() " +
                "Where UserID = @UserID And dUserDeleted Is Null and dLockedOut Is Null;";
            int modifiedRows = (int)Db.ExecuteNonQuery(update, args.ToArray());
            bool wasLockedOut = (modifiedRows == 1);
            return wasLockedOut;
        }

        public static bool Unlock(int userID) {
            if (userID <= 0) return false; // not required but prevents an unnecessary db call
            List<SqlParameter> args = new List<SqlParameter>();
            args.Add(new SqlParameter("@UserID", userID));
            // Only clear lockout date if it exists (is not null)
            string update = "Update Users Set dLockedOut = null, dUserUpdated = GetDate() " +
                "Where UserID = @UserID And dUserDeleted Is Null and dLockedOut Is Not Null;";
            int modifiedRows = (int)Db.ExecuteNonQuery(update, args.ToArray());
            bool wasUnlocked = (modifiedRows == 1);
            return wasUnlocked;
        }

        public static bool Disable(int userID) {
            if (userID <= 0) return false; // not required but prevents an unnecessary db call
            List<SqlParameter> args = new List<SqlParameter>();
            args.Add(new SqlParameter("@UserID", userID));
            // Only set disable date if not already set (is null)
            string update = "Update Users Set dUserDisabled = GetDate(), dUserUpdated = GetDate() " +
                "Where UserID = @UserID And dUserDeleted Is Null and dUserDisabled Is Null;";
            int modifiedRows = (int)Db.ExecuteNonQuery(update, args.ToArray());
            bool wasDisabled = (modifiedRows == 1);
            return wasDisabled;
        }

        public static bool Enable(int userID) {
            if (userID <= 0) return false; // not required but prevents an unnecessary db call
            List<SqlParameter> args = new List<SqlParameter>();
            args.Add(new SqlParameter("@UserID", userID));
            // Only clear disable date if it exists (is not null)
            string update = "Update Users Set dUserDisabled = null, dUserUpdated = GetDate() " +
                "Where UserID = @UserID And dUserDeleted Is Null and dUserDisabled Is Not Null;";
            int modifiedRows = (int)Db.ExecuteNonQuery(update, args.ToArray());
            bool wasEnabled = (modifiedRows == 1);
            return wasEnabled;
        }

        public static bool ResetPassword(int userID) {
            if (userID <= 0) return false; // not required but prevents an unnecessary db call
            List<SqlParameter> args = new List<SqlParameter>();
            args.Add(new SqlParameter("@UserID", userID));
            string update = "Update Users Set sPassword = 'DEFAULT', dUserUpdated = GetDate() " +
                "Where UserID = @UserID And dUserDeleted Is Null";
            int modifiedRows = (int)Db.ExecuteNonQuery(update, args.ToArray());
            bool wasReset = (modifiedRows == 1);
            return wasReset;
        }

        public static bool ChangePassword(int userID, string newPassword) {
            if (userID <= 0) return false; // not required but prevents an unnecessary db call
            List<SqlParameter> args = new List<SqlParameter>();
            args.Add(new SqlParameter("@UserID", userID));
            args.Add(new SqlParameter("@Password", newPassword));
            string update = "Update Users Set sPassword = @Password, dUserUpdated = GetDate() " +
                "Where UserID = @UserID And dUserDeleted Is Null";
            int modifiedRows = (int)Db.ExecuteNonQuery(update, args.ToArray());
            bool wasChanged = (modifiedRows == 1);
            return wasChanged;
        }
    }
}
