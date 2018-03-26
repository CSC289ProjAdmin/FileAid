using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileAid.Models;
using System.Data.SqlClient;

namespace FileAid.DAL {
    public static class PermissionsManagerDAL {
        public static Permissions GetPermissionSet(int userID) {
            if (userID <= 0) return null;
            List<SqlParameter> args = new List<SqlParameter>();
            args.Add(new SqlParameter("@UserID", userID));
            string select = "Select Permissions.PermID, bChangeAdminPass As ChangeAdminPass, " + 
                "bChangeUserPass As ChangeUserPass, bChangeGuestPass As ChangeGuestPass, " +
                "bEnableUser As EnableUser, bEnableGuest As EnableGuest, bResetUserPass As ResetUserPass, " +
                // Typo on bResetGuessPass is deliberate until database column is renamed
                "bResetGuessPass As ResetGuestPass, bUnlockUser As UnlockUser, bUnlockGuest As UnlockGuest, " +
                "bRestrictGuest As RestrictGuest, bResetDb As ResetDb, bBackupDb As BackupDb, " + 
                "bRestoreDb As RestoreDb, bBatchScan As BatchScan, bProgramSetup As ProgramSetup, " +
                "bLoginMgmt As LoginMgmt, bDbMgmt As DbMgmt " +
                "From Permissions Inner Join Roles On Roles.PermID = Permissions.PermID " +
                "Inner Join Users On Users.RoleID = Roles.RoleID " + 
                "Where UserID = @UserID And dPermDeleted Is Null And dRoleDeleted Is Null And dUserDeleted Is Null; ";
            List<Permissions> results = Db.ReadQuery<Permissions>(select, args.ToArray());
            if (results != null) {
                return results[0];
            } else {
                return null;
            }
        }

        public static bool UpdatePermissionSet(Permissions perms) {
            if (perms.PermID <= 0) return false;
            List<SqlParameter> args = new List<SqlParameter>();
            args.Add(new SqlParameter("@PermID", perms.PermID));
            args.Add(new SqlParameter("@ChangeAdminPass", perms.ChangeAdminPass));
            args.Add(new SqlParameter("@ChangeUserPass", perms.ChangeUserPass));
            args.Add(new SqlParameter("@ChangeGuestPass", perms.ChangeGuestPass));
            args.Add(new SqlParameter("@EnableUser", perms.EnableUser));
            args.Add(new SqlParameter("@EnableGuest", perms.EnableGuest));
            args.Add(new SqlParameter("@ResetUserPass", perms.ResetUserPass));
            args.Add(new SqlParameter("@ResetGuestPass", perms.ResetGuestPass));
            args.Add(new SqlParameter("@UnlockUser", perms.UnlockUser));
            args.Add(new SqlParameter("@UnlockGuest", perms.UnlockGuest));
            args.Add(new SqlParameter("@RestrictGuest", perms.RestrictGuest));
            args.Add(new SqlParameter("@ResetDb", perms.ResetDb));
            args.Add(new SqlParameter("@BackupDb", perms.BackupDb));
            args.Add(new SqlParameter("@RestoreDb", perms.RestoreDb));
            args.Add(new SqlParameter("@BatchScan", perms.BatchScan));
            args.Add(new SqlParameter("@ProgramSetup", perms.ProgramSetup));
            args.Add(new SqlParameter("@LoginMgmt", perms.LoginMgmt));
            args.Add(new SqlParameter("@DbMgmt", perms.DbMgmt));
            string update = "Update Permissions Set dPermUpdated = GetDate(), " +
                "bChangeAdminPass = @ChangeAdminPass, bChangeUserPass = @ChangeUserPass, " +
                "bChangeGuestPass = @ChangeGuestPass, bEnableUser = @EnableUser, " +
                "bEnableGuest = @EnableGuest, bResetUserPass = @ResetUserPass, " +
                // Typo on bResetGuessPass is deliberate until database column is renamed
                "bResetGuessPass = @ResetGuestPass, bUnlockUser = @UnlockUser, " +
                "bUnlockGuest = @UnlockGuest, bRestrictGuest = @RestrictGuest, " +
                "bResetDb = @ResetDb, bBackupDb = @BackupDb, bRestoreDb = @RestoreDb, " +
                "bBatchScan = @BatchScan, bProgramSetup = @ProgramSetup, " +
                "bLoginMgmt = @LoginMgmt, bDbMgmt = @DbMgmt " +
                "Where PermID = @PermID And dPermDeleted Is Null; ";
            int modifiedRows = (int)Db.ExecuteNonQuery(update, args.ToArray());
            bool wasUpdated = (modifiedRows == 1);
            return wasUpdated;
        }
    }
}
