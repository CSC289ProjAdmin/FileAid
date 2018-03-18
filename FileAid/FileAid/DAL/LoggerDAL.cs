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
            args.Add(new SqlParameter("@Description", e.Description));

            args.Add(new SqlParameter("@Initial", (string.IsNullOrEmpty(e.Initial) ? DBNull.Value : (object)e.Initial) ));
            args.Add(new SqlParameter("@New", (string.IsNullOrEmpty(e.New) ? DBNull.Value : (object)e.New) ));

            args.Add(new SqlParameter("@FileID", (e.FileID != -999 ? (object)e.FileID : DBNull.Value) ));
            args.Add(new SqlParameter("@LinkID", (e.LinkID != -999 ? (object)e.LinkID : DBNull.Value) ));
            args.Add(new SqlParameter("@ReportID", (e.ReportID != -999 ? (object)e.ReportID : DBNull.Value) ));
            args.Add(new SqlParameter("@ReminderID", (e.ReminderID != -999 ? (object)e.ReminderID : DBNull.Value) ));
            args.Add(new SqlParameter("@BatchID", (e.BatchID != -999 ? (object)e.BatchID : DBNull.Value) ));
            args.Add(new SqlParameter("@UserID", (e.UserID != -999 ? (object)e.UserID: DBNull.Value) ));
            args.Add(new SqlParameter("@LoginID", (e.LoginID != -999 ? (object)e.LoginID: DBNull.Value) ));
            args.Add(new SqlParameter("@PermID", (e.PermID != -999 ? (object)e.PermID: DBNull.Value) ));
            args.Add(new SqlParameter("@ConfigID", (e.ConfigID != -999 ? (object)e.ConfigID: DBNull.Value) ));

            string insert =
                "Insert Into Events (EventTypeID, dEvent, sEventDescription, sInitial, sNew, " +
                "FileID, LinkID, ReportID, ReminderID, BatchID, UserID, " +
                "LoginID, PermID, ConfigID, dEventCreated, dEventUpdated) " +
                "Values (@EventTypeID, GetDate(), @Description, @Initial, @New, " +
                "@FileID, @LinkID, @ReportID, @ReminderID, @BatchID, @UserID, " +
                "@LoginID, @PermID, @ConfigID, GetDate(), GetDate()); " +
                "Select Convert(int, Scope_Identity());";
            bool wasWritten = false;
            try {
                int newID = (int)Db.ExecuteScalar(insert, args.ToArray());
                wasWritten = (newID > 0);
            } catch (SqlException) {
                //wasWritten = false;
            }
            return wasWritten;
        }
    }
}
