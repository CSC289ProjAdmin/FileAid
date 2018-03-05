﻿using System;
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

        public static bool VerifyCredentials(int userID, string username, string password) {
            if (userID <= 0) return false; // not required but prevents an unnecessary db call
            List<SqlParameter> args = new List<SqlParameter>();
            args.Add(new SqlParameter("@UserID", userID));
            args.Add(new SqlParameter("@Name", username));
            args.Add(new SqlParameter("@Password", password));
            string select = "Select Count(*) From Users " +
                "Where UserID = @UserID And dUserDeleted Is Null " +
                "And sUserName = @Name And sPassword = @Password;";
            bool matches = ((int)Db.ExecuteScalar(select, args.ToArray()) == 1);
            return matches;
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

        public static void Disable(int userID) {
            if (userID <= 0) return; // not required but prevents an unnecessary db call
            List<SqlParameter> args = new List<SqlParameter>();
            args.Add(new SqlParameter("@UserID", userID));
            // Only set disable date if not already set (is null)
            string update = "Update Users Set dUserDisabled = GetDate(), dUserUpdated = GetDate() " +
                "Where UserID = @UserID And dUserDeleted Is Null and dUserDisabled Is Null;";
            int modifiedRows = (int)Db.ExecuteNonQuery(update, args.ToArray());
        }

        public static void Enable(int userID) {
            if (userID <= 0) return; // not required but prevents an unnecessary db call
            List<SqlParameter> args = new List<SqlParameter>();
            args.Add(new SqlParameter("@UserID", userID));
            // Only clear disable date if it exists (is not null)
            string update = "Update Users Set dUserDisabled = null, dUserUpdated = GetDate() " +
                "Where UserID = @UserID And dUserDeleted Is Null and dUserDisabled Is Not Null;";
            int modifiedRows = (int)Db.ExecuteNonQuery(update, args.ToArray());
        }

        public static void ResetPassword(int userID) {
            if (userID <= 0) return; // not required but prevents an unnecessary db call
            List<SqlParameter> args = new List<SqlParameter>();
            args.Add(new SqlParameter("@UserID", userID));
            string update = "Update Users Set sPassword = 'DEFAULT', dUserUpdated = GetDate() " +
                "Where UserID = @UserID And dUserDeleted Is Null";
            int modifiedRows = (int)Db.ExecuteNonQuery(update, args.ToArray());
        }

        public static void ChangePassword(int userID, string newPassword) {
            if (userID <= 0) return; // not required but prevents an unnecessary db call
            List<SqlParameter> args = new List<SqlParameter>();
            args.Add(new SqlParameter("@UserID", userID));
            args.Add(new SqlParameter("@Password", newPassword));
            string update = "Update Users Set sPassword = @Password, dUserUpdated = GetDate() " +
                "Where UserID = @UserID And dUserDeleted Is Null";
            int modifiedRows = (int)Db.ExecuteNonQuery(update, args.ToArray());
        }

        public static bool VerifyPasswordRequirements(string password) {
            // 8+ characters, 1+ digit, 1+ uppercase, 1+ symbol in *&%$#@
            bool hasLength = password.Length >= 8;
            bool hasDigit = password.Any(char.IsDigit);
            bool hasCap = password.Any(char.IsUpper);
            bool hasSymbol = password.IndexOfAny("*&%$#@".ToArray()) > -1;
            bool isValid = false;
            if (hasLength && hasDigit && hasCap && hasSymbol) isValid = true;
            return isValid;
        }
    }
}
