using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileAid.Models;

namespace FileAidTest.Tests
{
    [TestClass]
    public class PermissionsManagerTest
    {
        [TestMethod]
        public void GetPermissionSetTest()
        {
            // Test Parameters            
            string userUser = "User";

            // Find User
            User user = UserService.Find(userUser);
            Assert.IsNotNull(user);

            // Get the permissions for user
            Permissions perm = PermissionsManager.GetPermissionSet(user.UserID);

            // Verify permissions were returned
            Assert.IsNotNull(perm);
        }

        [TestMethod]
        public void UpdatePermissionSetTest()
        {
            // Test Parameters            
            string userUser = "User";

            // Find User
            User user = UserService.Find(userUser);
            Assert.IsNotNull(user);

            // Get initial permissions for user
            Permissions initialPerm = PermissionsManager.GetPermissionSet(user.UserID);

            // Modifiy the initial permissions to a separate object
            Permissions p = new Permissions()
                {
                    BackupDb = !initialPerm.BackupDb,
                    BatchScan = !initialPerm.BatchScan,
                    ChangeAdminPass = !initialPerm.ChangeAdminPass,
                    ChangeGuestPass = !initialPerm.ChangeGuestPass,
                    ChangeUserPass = !initialPerm.ChangeUserPass,
                    DbMgmt = !initialPerm.DbMgmt,
                    EnableGuest = !initialPerm.EnableGuest,
                    EnableUser = !initialPerm.EnableUser,
                    LoginMgmt = !initialPerm.LoginMgmt,
                    PermID = initialPerm.PermID,
                    ProgramSetup = !initialPerm.ProgramSetup,
                    ResetDb = !initialPerm.ResetDb,
                    ResetGuestPass = !initialPerm.ResetGuestPass,
                    ResetUserPass = !initialPerm.ResetUserPass,
                    RestoreDb = !initialPerm.RestoreDb,
                    RestrictGuest = !initialPerm.RestrictGuest,
                    UnlockGuest = !initialPerm.UnlockGuest,
                    UnlockUser = !initialPerm.UnlockUser
                };

            // Verify the objects are different
            Assert.IsFalse(ComparePermissionObjs(initialPerm,p));

            // Set the modified permissions for user
            PermissionsManager.UpdatePermissionSet(p);

            // Get the users permissions after the permission set
            Permissions modifiedPerm = PermissionsManager.GetPermissionSet(user.UserID);

            // Verify the retrieved permissions match the modified permissions that were set
            Assert.IsTrue(ComparePermissionObjs(modifiedPerm, p));

            // Set the initial permissions back for user
            PermissionsManager.UpdatePermissionSet(initialPerm);
        }

        bool ComparePermissionObjs(Permissions a, Permissions b)
        {
            bool areEqual = false;

            if(a.PermID == b.PermID &&
                a.ChangeAdminPass == b.ChangeAdminPass &&
                a.ChangeGuestPass == b.ChangeGuestPass &&
                a.ChangeUserPass == b.ChangeUserPass &&
                a.EnableGuest == b.EnableGuest &&
                a.EnableUser == b.EnableUser &&
                a.ResetGuestPass == b.ResetGuestPass &&
                a.ResetUserPass == b.ResetUserPass &&
                a.UnlockGuest == b.UnlockGuest &&
                a.UnlockUser == b.UnlockUser &&
                a.RestrictGuest == b.RestrictGuest &&
                a.ResetDb == b.ResetDb &&
                a.BackupDb == b.BackupDb &&
                a.RestoreDb == b.RestoreDb &&
                a.BatchScan == b.BatchScan &&
                a.ProgramSetup == b.ProgramSetup &&
                a.LoginMgmt == b.LoginMgmt &&
                a.DbMgmt == b.DbMgmt
             )
            {
                areEqual = true;
            }

            return areEqual;
        }
    }
}
