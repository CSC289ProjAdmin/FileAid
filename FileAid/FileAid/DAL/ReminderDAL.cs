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

        public static bool Join(int reminderID, int memberFileID) {
            if (reminderID <= 0 || memberFileID <= 0) return false;
            List<SqlParameter> args = new List<SqlParameter>();
            args.Add(new SqlParameter("@FileID", memberFileID));
            args.Add(new SqlParameter("@ReminderID", reminderID));
            // Prevent a file from being assigned any reminder it already has
            // or if it has an unresolved reminder.  Deleted and resolved reminders are ok to change.
            string select = "Select Count(*) As ExistingReminder From TrackedFiles " +
                "Where FileID = @FileID And dTrackDeleted Is Null " +
                "And (ReminderID = @ReminderID Or ReminderID = (" +
                "Select ReminderID From Reminders Where Reminders.ReminderID = TrackedFiles.ReminderID " +
                "And dReminderDeleted Is Null And dResolved Is Null ));";
            bool alreadyHasReminder = ((int)Db.ExecuteScalar(select, args.ToArray()) > 0);
            bool wasJoined = false;
            if (!alreadyHasReminder) {
                // Assign reminder to file
                string update = "Update TrackedFiles Set ReminderID = @ReminderID, dTrackUpdated = GetDate() " +
                    "Where FileID = @FileID And dTrackDeleted Is Null";
                int modifiedFiles = (int)Db.ExecuteNonQuery(update, args.ToArray());
                wasJoined = (modifiedFiles == 1);
            }
            return wasJoined;
        }

        public static bool RemoveFiles(int reminderID, List<int> exMemberFileIDs) {
            if (reminderID <= 0 || exMemberFileIDs == null || exMemberFileIDs.Count == 0) return false;
            List<SqlParameter> args = new List<SqlParameter>();
            args.Add(new SqlParameter("@ReminderID", reminderID));
            string idList = string.Join(",", exMemberFileIDs.ToArray());
            string update = "Update TrackedFiles Set ReminderID = null, dTrackUpdated = GetDate() " +
                "Where dTrackDeleted Is Null And ReminderID = @ReminderID " +
                "And FileID In (" + idList + ");";
            int modifiedRows = (int)Db.ExecuteNonQuery(update, args.ToArray());
            DeleteReminderIfUnused(reminderID);
            bool wereRemoved = (modifiedRows == exMemberFileIDs.Count);
            return wereRemoved;
        }

        private static bool DeleteReminderIfUnused(int reminderID) {
            List<SqlParameter> args = new List<SqlParameter>();
            args.Add(new SqlParameter("@ReminderID", reminderID));
            string select = "Select Count(*) From TrackedFiles Where dTrackDeleted Is Null " +
                "And ReminderID = @ReminderID";
            bool isUnused = ((int)Db.ExecuteScalar(select, args.ToArray()) == 0);
            bool wasDeleted = false;
            if (isUnused) {
                string update = "Update Reminders Set dReminderUpdated = GetDate(), dReminderDeleted = GetDate() " +
                    "Where ReminderID = @ReminderID And dReminderDeleted Is Null";
                int modifiedRows = (int)Db.ExecuteNonQuery(update, args.ToArray());
                wasDeleted = (modifiedRows == 1);
            }
            return wasDeleted;
        }

        public static bool Resolve(int reminderID) {
            if (reminderID <= 0) return false; // not required but prevents an unnecessary db call
            List<SqlParameter> args = new List<SqlParameter>();
            args.Add(new SqlParameter("@ReminderID", reminderID));
            string update = "Update Reminders Set dResolved = GetDate(), dReminderUpdated = GetDate() " +
                "Where ReminderID = @ReminderID And dResolved Is Null And dReminderDeleted Is Null";
            int modifiedRows = (int)Db.ExecuteNonQuery(update, args.ToArray());
            bool wasResolved = (modifiedRows == 1);
            return wasResolved;
        }

        public static bool Push(int reminderID) {
            //! Note: This DAL method only updates the database value. It does not Push to Outlook Calendar.
            if (reminderID <= 0) return false; // not required but prevents an unnecessary db call
            List<SqlParameter> args = new List<SqlParameter>();
            args.Add(new SqlParameter("@ReminderID", reminderID));
            string update = "Update Reminders Set dPushed = GetDate(), dReminderUpdated = GetDate() " +
                "Where ReminderID = @ReminderID And dPushed Is Null And dReminderDeleted Is Null";
            int modifiedRows = (int)Db.ExecuteNonQuery(update, args.ToArray());
            bool wasPushed = (modifiedRows == 1);
            return wasPushed;
        }

        public static bool UpdateMemo(int reminderID, string newMemo) {
            if (reminderID <= 0) return false; // not required but prevents an unnecessary db call
            List<SqlParameter>args = new List<SqlParameter>();
            args.Add(new SqlParameter("@ReminderID", reminderID));
            args.Add(new SqlParameter("@Memo", newMemo));
            string update = "Update Reminders Set sReminderMemo = @Memo, dReminderUpdated = GetDate() " +
                "Where ReminderID = @ReminderID And dReminderDeleted Is Null";
            int modifiedRows = (int)Db.ExecuteNonQuery(update, args.ToArray());
            bool wasUpdated = (modifiedRows == 1);
            return wasUpdated;
        }

        public static bool RemoveMemo(int reminderID) {
            if (reminderID <= 0) return false; // not required but prevents an unnecessary db call
            List<SqlParameter> args = new List<SqlParameter>();
            args.Add(new SqlParameter("@ReminderID", reminderID));
            string update = "Update Reminders Set sReminderMemo = null, dReminderUpdated = GetDate() " +
                "Where ReminderID = @ReminderID And dReminderDeleted Is Null";
            int modifiedRows = (int)Db.ExecuteNonQuery(update, args.ToArray());
            bool wasRemoved = (modifiedRows == 1);
            return wasRemoved;
        }
    }
}
