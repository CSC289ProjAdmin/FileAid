using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileAid.Models {
    public static class UserService {
        public static User Find(string username) {
            User specific = DAL.UserServiceDAL.Find(username);
            return specific;
        }

        public static bool VerifyCredentials(User u, string password) {
            // TODO: Encrypt given password before comparing to datastore
            // string encrypted = xxx.Encrypt(password);
            bool isValid = DAL.UserServiceDAL.VerifyCredentials(u.Username, password);
            return isValid;
        }

        public static bool IncrementFailures(User u) {
            bool wasIncremented = DAL.UserServiceDAL.IncrementFailures(u.UserID);
            if (wasIncremented) u.LoginFailures++;
            return wasIncremented;
        }

        public static bool ClearFailures(User u) {
            bool wasCleared = DAL.UserServiceDAL.ClearFailures(u.UserID);
            if (wasCleared) u.LoginFailures = 0;
            return wasCleared;
        }

        public static bool LockOut(User u) {
            bool wasLockedOut = DAL.UserServiceDAL.LockOut(u.UserID);
            if (wasLockedOut) u.LockedOutOn = DateTime.Now;
            return wasLockedOut;
        }

        public static bool IsLockedOut(User u) {
            bool isLockedOut = false;
            bool isLockTimerSet = (u.LockedOutOn > new DateTime()); // 01-01-0001
            if (isLockTimerSet) {
                TimeSpan timeDifference = DateTime.Now - u.LockedOutOn;
                isLockedOut = (timeDifference < TimeSpan.FromHours(1));
            }
            return isLockedOut;
        }

        public static bool Unlock(User u) {
            bool wasUnlocked = DAL.UserServiceDAL.Unlock(u.UserID);
            if (wasUnlocked) u.LockedOutOn = new DateTime(); // 01-01-0001
            return wasUnlocked;
        }

        public static bool Disable(User u) {
            bool wasDisabled = DAL.UserServiceDAL.Disable(u.UserID);
            if (wasDisabled) u.DisabledOn = DateTime.Now;
            return wasDisabled;
        }

        public static bool Enable(User u) {
            bool wasEnabled = DAL.UserServiceDAL.Enable(u.UserID);
            if (wasEnabled) u.DisabledOn = new DateTime(); // 01-01-0001
            return wasEnabled;
        }

        public static bool ResetPassword(User u) {
            bool wasReset = DAL.UserServiceDAL.ResetPassword(u.UserID);
            return wasReset;
        }

        public static bool ChangePassword(User u, string newPassword) {
            // TODO: Encrypt given password before updating datastore
            // string encrypted = xxx.Encrypt(newPassword);
            bool wasChanged = DAL.UserServiceDAL.ChangePassword(u.UserID, newPassword);
            return wasChanged;
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
