using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileAid.Models;
using System.Data.SqlClient;

namespace FileAid.DAL {
    public static class TrackedFileDAL {
        public static List<FileLink> GetLinks(int fileID) {
            if (fileID <= 0) return null; // not required but prevents an unnecessary db call
            List<SqlParameter> args = new List<SqlParameter>();
            args.Add(new SqlParameter("@FileID", fileID));
            string select = "Select LM.LinkMemoID, sLinkMemo As LinkMemo " +
                "From LinkMemos LM Inner Join FileLinks FL On LM.LinkMemoID = FL.LinkMemoID " +
                "Where FileID = @FileID And dLinkDeleted Is Null And dMemoDeleted Is Null;";
            return Db.ReadQuery<FileLink>(select, args.ToArray());
        }

        public static Reminder GetReminder(int fileID) {
            if (fileID <= 0) return null; // not required but prevents an unnecessary db call
            List<SqlParameter> args = new List<SqlParameter>();
            args.Add(new SqlParameter("@FileID", fileID));
            string select = "Select R.ReminderID, sReminderName As Name, dDue As DueOn, " +
                "sReminderMemo As Memo, dResolved As ResolvedOn, dPushed As PushedOn " +
                "From Reminders R Inner Join TrackedFiles TF On R.ReminderID = TF.ReminderID " + 
                "Where dReminderDeleted Is Null And FileID = @FileID;";
            //! TODO: Handle nullable DateTimes
            List<Reminder> results = Db.ReadQuery<Reminder>(select, args.ToArray());
            if (results != null) {
                return results[0];
            } else {
                return null;
            }
        }

        public static bool UpdateMemo(int fileID, string newMemo) {
            if (fileID <= 0) return false; // not required but prevents an unnecessary db call
            List<SqlParameter> args = new List<SqlParameter>();
            args.Add(new SqlParameter("@FileID", fileID));
            args.Add(new SqlParameter("@Memo", newMemo));
            string update = "Update TrackedFiles Set sFileMemo = @Memo, dTrackUpdated = GetDate() " +
                "Where FileID = @FileID And dTrackDeleted Is Null";
            int modifiedRows = (int)Db.ExecuteNonQuery(update, args.ToArray());
            bool wasUpdated = (modifiedRows == 1);
            return wasUpdated;
        }

        public static bool RemoveMemo(int fileID) {
            if (fileID <= 0) return false; // not required but prevents an unnecessary db call
            List<SqlParameter> args = new List<SqlParameter>();
            args.Add(new SqlParameter("@FileID", fileID));
            string update = "Update TrackedFiles Set sFileMemo = null, dTrackUpdated = GetDate() " +
                "Where FileID = @FileID And dTrackDeleted Is Null";
            int modifiedRows = (int)Db.ExecuteNonQuery(update, args.ToArray());
            bool wasRemoved = (modifiedRows == 1);
            return wasRemoved;
        }

        public static List<Event> GetHistory(int fileID) {
            if (fileID <= 0) return null; // not required but prevents an unnecessary db call
            List<SqlParameter> args = new List<SqlParameter>();
            args.Add(new SqlParameter("@FileID", fileID));
            string select = "Select EventID, EventTypeID, dEvent As OccurredOn, " +
                "sEventDescription As Description, sInitial As Initial, sNew As New, " +
                "FileID, LinkID, ReportID, ReminderID, BatchID, UserID, LoginID, PermID, ConfigID " +
                "From Events Where FileID = @FileID And dEventDeleted Is Null;";
            //! TODO: ??Handle nullable ints
            return Db.ReadQuery<Event>(select, args.ToArray());
        }

        public static bool StopTracking(int fileID) {
            if (fileID <= 0) return false; // not required but prevents an unnecessary db call
            List<SqlParameter> args = new List<SqlParameter>();
            args.Add(new SqlParameter("@FileID", fileID));
            // Only update the tracking disabled date if it is not already set (is null)
            string update = "Update TrackedFiles Set dTrackingDisabled = GetDate(), dTrackUpdated = GetDate() " +
                "Where FileID = @FileID And dTrackDeleted Is Null And dTrackingDisabled Is Null;";
            int modifiedRows = (int)Db.ExecuteNonQuery(update, args.ToArray());
            bool wasStopped = (modifiedRows == 1);
            return wasStopped;
        }

        public static bool StartTracking(int fileID) {
            if (fileID <= 0) return false; // not required but prevents an unnecessary db call
            List<SqlParameter> args = new List<SqlParameter>();
            args.Add(new SqlParameter("@FileID", fileID));
            // Only remove the tracking disabled date if it exists (not null)
            string update = "Update TrackedFiles Set dTrackingDisabled = null, dTrackUpdated = GetDate() " +
                "Where FileID = @FileID And dTrackDeleted Is Null And dTrackingDisabled Is Not Null;";
            int modifiedRows = (int)Db.ExecuteNonQuery(update, args.ToArray());
            bool wasStarted = (modifiedRows == 1);
            return wasStarted;
        }
    }
}
