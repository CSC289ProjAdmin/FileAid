using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileAid.Models;
using System.Data.SqlClient;

namespace FileAid.DAL {
    public static class ConfigManagerDAL {
        public static Configs GetConfigs() {
            string select = "Select ConfigID, iUpdateTimer As UpdateTimerInMinutes, " +
                "bShowInactive As ShowInactive, bUpdateMode As InUpdateMode " +
                ", sMasterPath As MasterPath " + 
                "From Configurations Where dConfigDeleted Is Null; " ;
            List<Configs> results = Db.ReadQuery<Configs>(select);
            if (results != null) {
                return results[0];
            } else {
                return null;
            }
        }

        public static bool UpdateConfigs(Configs c) {
            if (c.ConfigID <= 0) return false;
            List<SqlParameter> args = new List<SqlParameter>();
            args.Add(new SqlParameter("@ConfigID", c.ConfigID));
            args.Add(new SqlParameter("@Timer", c.UpdateTimerInMinutes));
            args.Add(new SqlParameter("@Inactive", c.ShowInactive));
            args.Add(new SqlParameter("@Updating", c.InUpdateMode));
            args.Add(new SqlParameter("@Folder", c.MasterPath));
            string update = "Update Configurations Set dConfigUpdated = GetDate(), " +
                "iUpdateTimer = @Timer, bShowInactive = @Inactive, bUpdateMode = @Updating " +
                ", sMasterPath = @Folder " +
                "Where dConfigDeleted Is Null And ConfigID = @ConfigID";
            int modifiedRows = (int)Db.ExecuteNonQuery(update, args.ToArray());
            bool wasUpdated = (modifiedRows == 1);
            return wasUpdated;
        }
    }
}
