using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileAid.Models {
    public static class UserService {
        public static User Find(string username) {
            // stub
            User dummy = new User();
            return dummy;
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
            return false;
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
