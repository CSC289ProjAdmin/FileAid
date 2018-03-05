using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileAid.Models;
using System.Data.SqlClient;

namespace FileAid.DAL {
    public static class TrackedFileDAL {
        public static TrackedFile GetInfo() {
            //stub
            return new TrackedFile();
        }

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

        public static void UpdateMemo(int fileID, string newMemo) {
            if (fileID <= 0) return; // not required but prevents an unnecessary db call
            List<SqlParameter> args = new List<SqlParameter>();
            args.Add(new SqlParameter("@FileID", fileID));
            args.Add(new SqlParameter("@Memo", newMemo));
            string update = "Update TrackedFiles Set sFileMemo = @Memo, dTrackUpdated = GetDate() " +
                "Where FileID = @FileID And dTrackDeleted Is Null";
            int modifiedRows = (int)Db.ExecuteNonQuery(update, args.ToArray());
        }

        public static void RemoveMemo(int fileID) {
            if (fileID <= 0) return; // not required but prevents an unnecessary db call
            List<SqlParameter> args = new List<SqlParameter>();
            args.Add(new SqlParameter("@FileID", fileID));
            string update = "Update TrackedFiles Set sFileMemo = null, dTrackUpdated = GetDate() " +
                "Where FileID = @FileID And dTrackDeleted Is Null";
            int modifiedRows = (int)Db.ExecuteNonQuery(update, args.ToArray());
        }

        public static List<Event> GetHistory() {
            //stub
            return Db.ReadQuery<Event>("stub");
        }

        public static void StopTracking() {
            // stub
        }

        public static void StartTracking() {
            // stub
        }
    }
}
