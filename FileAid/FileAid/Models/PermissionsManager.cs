using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileAid.Models {
    public static class PermissionsManager {
        public static Permissions GetPermissionSet(int userID) {
            Permissions userPerms = DAL.PermissionsManagerDAL.GetPermissionSet(userID);
            return userPerms;
        }

        public static bool UpdatePermissionSet(Permissions perms) {
            bool wasUpdated = DAL.PermissionsManagerDAL.UpdatePermissionSet(perms);
            return wasUpdated;
        }
    }
}
