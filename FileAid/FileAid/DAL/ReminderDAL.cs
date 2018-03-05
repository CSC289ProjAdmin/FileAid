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
