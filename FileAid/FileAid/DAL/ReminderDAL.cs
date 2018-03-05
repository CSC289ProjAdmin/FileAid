using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileAid.Models;
using System.Data.SqlClient;

namespace FileAid.DAL {
    public static class ReminderDAL {
        public static List<TrackedFile> GetFiles(int reminderID) {
            if (reminderID <= 0) return null; // not required but prevents an unnecessary db call
            // Get list of all files belonging to this Reminder
            List<SqlParameter> args = new List<SqlParameter>();
            args.Add(new SqlParameter("@ReminderID", reminderID));
            string select = "Select FileID, sFileName As Filename, sFileExt As FileExtension, " +
                "sFilePath As FilePath, iSizeInBytes As FileSize, dFileModified As ModifiedOn, " +
                "dFileCreated As CreatedOn, sFileMemo As FileMemo, " +
                "dTrackingDisabled As TrackingDisabledOn, TrackedFiles.ReminderID From TrackedFiles " +
                "Inner Join Reminders On TrackedFiles.ReminderID = Reminders.ReminderID " +
                "Where dTrackDeleted Is Null " +
                "And dReminderDeleted Is Null And TrackedFiles.ReminderID = @ReminderID ";
            return Db.ReadQuery<TrackedFile>(select, args.ToArray());
        }

        public static void RemoveFiles(int reminderID, List<int> exMemberFileIDs) {
            if (reminderID <= 0) return; // not required but prevents an unnecessary db call
            List<SqlParameter> args = new List<SqlParameter>();
            args.Add(new SqlParameter("@ReminderID", reminderID));
            string idList = string.Join(",", exMemberFileIDs.ToArray());
            string update = "Update TrackedFiles Set ReminderID = null, dTrackUpdated = GetDate() " +
                "Where dTrackDeleted Is Null And ReminderID = @ReminderID " +
                "And FileID In (" + idList + ");";
            int modifiedRows = (int)Db.ExecuteNonQuery(update, args.ToArray());
            RemoveReminderIfEmpty(reminderID);
        }

        private static void RemoveReminderIfEmpty(int reminderID) {
            List<SqlParameter> args = new List<SqlParameter>();
            args.Add(new SqlParameter("@ReminderID", reminderID));
            string select = "Select Count(*) From TrackedFiles Where dTrackDeleted Is Null " +
                "And ReminderID = @ReminderID";
            bool isEmpty = ((int)Db.ExecuteScalar(select, args.ToArray()) == 0);
            if (isEmpty) {
                string update = "Update Reminders Set dReminderUpdated = GetDate(), dReminderDeleted = GetDate() " +
                    "Where ReminderID = @ReminderID And dReminderDeleted Is Null";
                int modifiedRows = (int)Db.ExecuteNonQuery(update, args.ToArray());
            }
        }

        public static void Resolve(int reminderID) {
            if (reminderID <= 0) return; // not required but prevents an unnecessary db call
            List<SqlParameter> args = new List<SqlParameter>();
            args.Add(new SqlParameter("@ReminderID", reminderID));
            string update = "Update Reminders Set dResolved = GetDate() " +
                "Where ReminderID = @ReminderID And dResolved Is Null And dReminderDeleted Is Null";
            int modifiedRows = (int)Db.ExecuteNonQuery(update, args.ToArray());
        }

        public static void Push(int reminderID) {
            //! Note: This DAL method only updates the database value. It does not Push to Outlook Calendar.
            if (reminderID <= 0) return; // not required but prevents an unnecessary db call
            List<SqlParameter> args = new List<SqlParameter>();
            args.Add(new SqlParameter("@ReminderID", reminderID));
            string update = "Update Reminders Set dPushed = GetDate() " +
                "Where ReminderID = @ReminderID And dPushed Is Null And dReminderDeleted Is Null";
            int modifiedRows = (int)Db.ExecuteNonQuery(update, args.ToArray());
        }

        public static void UpdateMemo(int reminderID, string newMemo) {
            if (reminderID <= 0) return; // not required but prevents an unnecessary db call
            List<SqlParameter>args = new List<SqlParameter>();
            args.Add(new SqlParameter("@ReminderID", reminderID));
            args.Add(new SqlParameter("@Memo", newMemo));
            string update = "Update Reminders Set sReminderMemo = @Memo, dReminderUpdated = GetDate() " +
                "Where ReminderID = @ReminderID And dReminderDeleted Is Null";
            int modifiedRows = (int)Db.ExecuteNonQuery(update, args.ToArray());
        }

        public static void RemoveMemo() {
            // stub
        }
/*
        public static void UpdateMemo(int linkMemoID, string newMemo) {
            if (linkMemoID <= 0) return; // not required but prevents an unnecessary db call
            List<SqlParameter> args = new List<SqlParameter>();
            args.Add(new SqlParameter("@LinkMemoID", linkMemoID));
            args.Add(new SqlParameter("@Memo", newMemo));
            string update = "Update LinkMemos Set sLinkMemo = @Memo, dMemoUpdated = GetDate() " +
                "Where LinkMemoID = @LinkMemoID And dMemoDeleted Is Null";
            int modifiedRows = (int)Db.ExecuteNonQuery(update, args.ToArray());
        }

        public static void RemoveMemo(int linkMemoID) {
            if (linkMemoID <= 0) return; // not required but prevents an unnecessary db call
            List<SqlParameter> args = new List<SqlParameter>();
            args.Add(new SqlParameter("@LinkMemoID", linkMemoID));
            string update = "Update LinkMemos Set sLinkMemo = null, dMemoUpdated = GetDate() " +
                "Where LinkMemoID = @LinkMemoID And dMemoDeleted Is Null";
            int modifiedRows = (int)Db.ExecuteNonQuery(update, args.ToArray());
        }

*/
    }
}
