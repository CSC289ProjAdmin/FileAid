using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using FileAid.Models;

namespace FileAidTest.Tests {
    [TestClass]
    public class LoginManagerTest {
        [TestMethod]
        public void GetLoginsTest()
        {
            // Test Parameters
            const int adminId = 1, userId = 2, guestId = 3;
            int loginsCount = 0;

            // Get current logins
            List<Login> logins = LoginManager.GetLogins();
            loginsCount = logins == null ? 0 : logins.Count;

            // Add a login for Admin, User, and Guest
            LoginManager.AddLogin(adminId);
            LoginManager.AddLogin(userId);
            LoginManager.AddLogin(guestId);

            // Get logins
            logins = LoginManager.GetLogins();

            // Verify logins were added
            Assert.AreEqual(loginsCount + 3, logins.Count);

        }

        [TestMethod]
        public void GetMostRecentLoginTest()
        {
            // Test Parameters
            const int adminId = 1, userId = 2;

            // Add a login for Admin
            LoginManager.AddLogin(adminId);

            // Get most recent Admin login
            Login login = LoginManager.GetMostRecentLogin(adminId);

            // Verify the login was returned for the correct user
            Assert.AreEqual(adminId, login.UserID);

            // Verify the login occurred within the last minute
            Assert.IsTrue(login.OccurredOn > DateTime.Now.AddMinutes(-1));

            // Add a login for User
            LoginManager.AddLogin(userId);

            // Get most recent User login
            login = LoginManager.GetMostRecentLogin(userId);

            // Verify the login was returned for the correct user
            Assert.AreEqual(userId, login.UserID);

            // Verify the login occurred within the last minute
            Assert.IsTrue(login.OccurredOn > DateTime.Now.AddMinutes(-1));

        }

        [TestMethod]
        public void AddLoginTest()
        {
            // Test Parameters
            const int adminId = 1, userId = 2, guestId = 3;
            int loginsCount = 0;

            // Get current logins
            List<Login> logins = LoginManager.GetLogins();
            loginsCount = logins == null ? 0 : logins.Count;

            // Add a login for Admin, User, and Guest
            LoginManager.AddLogin(adminId);
            LoginManager.AddLogin(userId);
            LoginManager.AddLogin(guestId);

            // Get logins
            logins = LoginManager.GetLogins();

            // Verify logins were added
            Assert.AreEqual(loginsCount + 3, logins.Count);

        }
    }
}
