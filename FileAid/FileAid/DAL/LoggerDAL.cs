using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileAid.Models;
using System.Data.SqlClient;

namespace FileAid.DAL {
    public class LoggerDAL {
        public static bool LogToDb(Event e) {
            List<SqlParameter> args = new List<SqlParameter>();
            args.Add(new SqlParameter("@EventTypeID", e.EventTypeID));
            args.Add(new SqlParameter("@EventDate", e.OccurredOn));
            args.Add(new SqlParameter("@Description", e.Description));
            args.Add(new SqlParameter("@Initial", e.Initial));
            args.Add(new SqlParameter("@New", e.New));

            args.Add(new SqlParameter("@FileID", (e.FileID != -999 ? e.FileID.ToString() : "null") ));
            args.Add(new SqlParameter("@LinkID", (e.LinkID != -999 ? e.LinkID.ToString() : "null") ));
            args.Add(new SqlParameter("@ReportID", (e.ReportID != -999 ? e.ReportID.ToString() : "null") ));
            args.Add(new SqlParameter("@ReminderID", (e.ReminderID != -999 ? e.ReminderID.ToString() : "null") ));
            args.Add(new SqlParameter("@BatchID", (e.BatchID != -999 ? e.BatchID.ToString() : "null") ));
            args.Add(new SqlParameter("@UserID", (e.UserID != -999 ? e.UserID.ToString() : "null") ));
            args.Add(new SqlParameter("@LoginID", (e.LoginID != -999 ? e.LoginID.ToString() : "null") ));
            args.Add(new SqlParameter("@PermID", (e.PermID != -999 ? e.PermID.ToString() : "null") ));
            args.Add(new SqlParameter("@ConfigID", (e.ConfigID != -999 ? e.ConfigID.ToString() : "null") ));

            string insert = "Insert Into Events (EventTypeID, dEvent, sEventDescription, sInitial, sNew, " +
                "FileID, LinkID, ReportID, ReminderID, BatchID, UserID, LoginID, PermID, ConfigID) " +
                "Values (@EventTypeID, @EventDate, @Description, @Initial, @New, " +
                "@FileID, @LinkID, @ReportID, @ReminderID, @BatchID, @UserID, @LoginID, @PermID, @ConfigID); " +
                "Select Convert(int, Scope_Identity());";
            int newID = (int)Db.ExecuteScalar(insert, args.ToArray());
            bool wasAdded = (newID > 0);
            return wasAdded;
        }
    }
}
