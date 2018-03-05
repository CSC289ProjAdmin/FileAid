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

        public static void RemoveFiles(List<int> exMemberFileIDs) {
            // stub
        }

        public static void RemoveFiles(int reminderID, List<int> exMemberFileIDs) {
            if (reminderID <= 0) return; // not required but prevents an unnecessary db call
            List<SqlParameter> args = new List<SqlParameter>();
            args.Add(new SqlParameter("@ReminderID", reminderID));
            string idList = string.Join(",", exMemberFileIDs.ToArray());
            string update = "Update TrackedFiles Set ReminderID = null " +
                "Where dTrackDeleted Is Null And ReminderID = @ReminderID";
            int modifiedRows = (int)Db.ExecuteNonQuery(update, args.ToArray());
/*
            RemoveReminderIfEmpty(reminderID);
*/
        }

        private static void RemoveReminderIfEmpty(int reminderID) {
            List<SqlParameter> args = new List<SqlParameter>();
            args.Add(new SqlParameter("@ReminderID", reminderID));
/*
            string select = "Select Count(*) From FileLinks Where dLinkDeleted Is Null " +
                "And LinkMemoID = @LinkMemoID";
            bool isEmpty = ((int)Db.ExecuteScalar(select, args.ToArray()) == 0);
            if (isEmpty) {
                string update = "Update LinkMemos Set dMemoUpdated = GetDate(), dMemoDeleted = GetDate() " +
                    "Where LinkMemoID = @LinkMemoID And dMemoDeleted Is Null";
                int modifiedRows = (int)Db.ExecuteNonQuery(update, args.ToArray());
            }
*/
        }

        public static void Resolve() {
            // stub
        }

        public static void Push() {
            // stub
        }

        public static void UpdateMemo(string newMemo) {
            // stub
        }

        public static void RemoveMemo() {
            // stub
        }
    }
}
