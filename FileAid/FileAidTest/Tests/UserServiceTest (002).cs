using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileAid.Models;

namespace FileAidTest.Tests {
    [TestClass]
    public class UserServiceTest {
        [TestMethod]
        public void FindTest() {

            // Test Parameters
            string adminUser = "Admin";
            string userUser = "User";
            string guestUser = "Guest";

            // Find user: Admin
            User user = null;
            user = UserService.Find(adminUser);
            Assert.IsNotNull(user);
            Assert.AreEqual(adminUser, user.Username);

            // find user: User
            user = null;
            user = UserService.Find(userUser);
            Assert.IsNotNull(user);
            Assert.AreEqual(userUser, user.Username);

            // find user: Guest
            user = null;
            user = UserService.Find(guestUser);
            Assert.IsNotNull(user);
            Assert.AreEqual(guestUser, user.Username);

        }

        [TestMethod]
        public void VerifyCredentialsTest() {

            // Test Parameters
            string userUser = "User";
            string password = "UserPassword1*";

            // Find user
            User user = UserService.Find(userUser);
            Assert.IsNotNull(user);

            // Set password
            Assert.IsTrue(UserService.ChangePassword(user, password));

            // Verify Credentials
            bool credentialsVerified = false;
            credentialsVerified = UserService.VerifyCredentials(user, password);
            Assert.IsTrue(credentialsVerified);

        }

        [TestMethod]
        public void IncrementFailuresTest() {

            // Test Parameters
            string userUser = "User";
            int failures = 0;

            // Get current failures for user
            User user = UserService.Find(userUser);
            Assert.IsNotNull(user);
            failures = user.LoginFailures;

            // Increment login failures for user
            UserService.IncrementFailures(user);
            Assert.AreEqual(failures + 1, user.LoginFailures);

        }

        [TestMethod]
        public void ClearFailuresTest() {

            // Test Parameters
            string userUser = "User";

            // Get current failures for user
            User user = UserService.Find(userUser);
            Assert.IsNotNull(user);

            // Increment login failures for user
            UserService.IncrementFailures(user);
            Assert.IsTrue(user.LoginFailures > 0);

            // Clear login failures for user
            UserService.ClearFailures(user);
            Assert.AreEqual(0, user.LoginFailures);

        }

        [TestMethod]
        public void LockOutTest() {

            // Test Parameters
            string userUser = "User";            

            // Clear lockout state for user
            User user = UserService.Find(userUser);
            Assert.IsNotNull(user);
            bool lockedOutState = UserService.IsLockedOut(user);
            UserService.Unlock(user);
            Assert.IsFalse(UserService.IsLockedOut(user));

            // Lock out user
            UserService.LockOut(user);
            Assert.IsTrue(UserService.IsLockedOut(user));

            // Restore lock out state for user
            if(!lockedOutState)
            {
                UserService.LockOut(user);
            }

        }

        [TestMethod]
        public void IsLockedOutTest() {

            // Test Parameters
            string userUser = "User";

            // Clear lockout state for user
            User user = UserService.Find(userUser);
            Assert.IsNotNull(user);
            bool lockedOutState = UserService.IsLockedOut(user);
            UserService.Unlock(user);

            // Verify is locked out when not locked
            Assert.IsFalse(UserService.IsLockedOut(user));

            // Verify is locked out when locked
            UserService.LockOut(user);
            Assert.IsTrue(UserService.IsLockedOut(user));

            // Restore lock out state for user
            if (!lockedOutState)
            {
                UserService.Unlock(user);
            }

        }

        [TestMethod]
        public void UnlockTest() {

            // Test Parameters
            string userUser = "User";

            // Clear lockout state for user
            User user = UserService.Find(userUser);
            Assert.IsNotNull(user);
            bool lockedOutState = UserService.IsLockedOut(user);
            UserService.Unlock(user);

            // Lock the user
            UserService.LockOut(user);
            Assert.IsTrue(UserService.IsLockedOut(user));

            // Unlock the user
            UserService.Unlock(user);
            Assert.IsFalse(UserService.IsLockedOut(user));

            // Restore lock out state for user
            if (!lockedOutState)
            {
                UserService.LockOut(user);
            }

        }

        [TestMethod]
        public void DisableTest() {

            // Test Parameters
            string userUser = "User";

            // Clear disabled state for user
            User user = UserService.Find(userUser);
            Assert.IsNotNull(user);
            bool disabledState = UserService.IsDisabled(user);
            UserService.Enable(user);

            // Verify is enabled
            Assert.IsFalse(UserService.IsDisabled(user));

            // Verify disabled state is set
            UserService.Disable(user);
            Assert.IsTrue(UserService.IsDisabled(user));

            // Restore disabled state for user
            if (!disabledState)
            {
                UserService.Enable(user);
            }

        }

        [TestMethod]
        public void EnableTest() {

            // Test Parameters
            string userUser = "User";

            // Clear disabled state for user
            User user = UserService.Find(userUser);
            Assert.IsNotNull(user);
            bool disabledState = UserService.IsDisabled(user);
            UserService.Disable(user);

            // Verify is disabled
            Assert.IsTrue(UserService.IsDisabled(user));

            // Verify enabled state is set
            UserService.Enable(user);
            Assert.IsFalse(UserService.IsDisabled(user));

            // Restore disabled state for user
            if (!disabledState)
            {
                UserService.Enable(user);
            }

        }

        [TestMethod]
        public void ResetPasswordTest() {

            // Test Parameters
            string userUser = "User";
            string password = "UserPassword1*";

            // Find user
            User user = UserService.Find(userUser);
            Assert.IsNotNull(user);

            // Set password
            Assert.IsTrue(UserService.ChangePassword(user, password));

            // Verify Credentials
            bool credentialsVerified = false;
            credentialsVerified = UserService.VerifyCredentials(user, password);
            Assert.IsTrue(credentialsVerified);

            // Reset Password
            UserService.ResetPassword(user);
            Assert.IsFalse(UserService.VerifyCredentials(user,password));
            Assert.IsTrue(UserService.VerifyCredentials(user, ""));

        }

        [TestMethod]
        public void ChangePasswordTest() {

            // Test Parameters
            string userUser = "User";
            string password = "UserPassword1*";

            // Find user
            User user = UserService.Find(userUser);
            Assert.IsNotNull(user);

            // Reset Password
            UserService.ResetPassword(user);
            Assert.IsTrue(UserService.VerifyCredentials(user, ""));

            // Change password
            Assert.IsTrue(UserService.ChangePassword(user, password));

            // Verify Credentials
            bool credentialsVerified = false;
            credentialsVerified = UserService.VerifyCredentials(user, password);
            Assert.IsTrue(credentialsVerified);

        }
    }
}
