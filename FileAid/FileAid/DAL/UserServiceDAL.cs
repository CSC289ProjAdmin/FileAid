using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileAid.Models;

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

        public static void IncrementFailures(User u) {
            // stub
        }

        public static void ClearFailures(User u) {
            // stub
        }

        public static void LockOut(User u) {
            // stub
        }

        public static bool IsLockedOut(User u) {
            // stub
            return true;
        }

        public static void Unlock(User u) {
            // stub
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
