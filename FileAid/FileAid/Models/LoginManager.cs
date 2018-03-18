using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileAid.Models {
    public static class LoginManager {
        public static List<Login> GetLogins() {
            List<Login> allLogins = DAL.LoginManagerDAL.GetLogins();
            return allLogins;
        }

        public static Login GetMostRecentLogin(int userID) {
            Login specific = DAL.LoginManagerDAL.GetMostRecentLogin(userID);
            return specific;
        }

        public static Login AddLogin(int userID) {
            int newID = DAL.LoginManagerDAL.AddLogin(userID);
            if (newID != -999) {
                return GetMostRecentLogin(userID) ;
            } else {
                return null;
            }
        }
    }
}
