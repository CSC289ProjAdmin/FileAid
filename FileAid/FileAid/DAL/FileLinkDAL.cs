using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileAid.Models;
using System.Data.SqlClient;

namespace FileAid.DAL {
    public static class FileLinkDAL {
        public static List<TrackedFile> GetFiles(int linkMemoID) {
            if (linkMemoID <= 0) return null; // not required but prevents an unnecessary db call
            // Get list of all files belonging to this link/group
            string select = "Select TrackedFiles.FileID, sFileName As Filename, sFileExt As FileExtension, " +
                "sFilePath As FilePath, iSizeInBytes As FileSize, dFileModified As ModifiedOn, " +
                "dFileCreated As CreatedOn, sFileMemo As FileMemo, " +
                "dTrackingDisabled As TrackingDisabledOn, ReminderID From TrackedFiles " +
                "Inner Join FileLinks On TrackedFiles.FileID = FileLinks.FileID " +
                "Where dTrackDeleted Is Null " +
                "And dLinkDeleted Is Null And LinkMemoID = @LinkMemoID ";
            List<SqlParameter> args = new List<SqlParameter>();
            args.Add(new SqlParameter("@LinkMemoID", linkMemoID));
            return Db.ReadQuery<TrackedFile>(select, args.ToArray());
        }

        public static void Join(int linkMemoID, int memberFileID) {
            if (linkMemoID <= 0 || memberFileID <= 0) return;
            List<SqlParameter> args = new List<SqlParameter>();
            args.Add(new SqlParameter("@FileID", memberFileID));
            args.Add(new SqlParameter("@LinkMemoID", linkMemoID));
            // Prevent a file from being added to any group it is already in
            string select = "Select Count(*) As ExistingLinks From FileLinks " +
                "Where FileID = @FileID And LinkMemoID = @LinkMemoID And dLinkDeleted Is Null";
            bool alreadyInGroup = ((int)Db.ExecuteScalar(select, args.ToArray()) > 0);
            if (!alreadyInGroup) {
                // Add file to the group
                string insert = "Insert Into FileLinks (FileID, LinkMemoID, dLinkCreated, dLinkUpdated) " +
                    "Values (@FileID, @LinkMemoID, GetDate(), GetDate());" +
                    "Select Convert(int, Scope_Identity());";
                int newID = (int)Db.ExecuteScalar(insert, args.ToArray());
            }
        }

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

        public static void RemoveFiles(int linkMemoID, List<int> exMemberFileIDs) {
            if (linkMemoID <= 0) return; // not required but prevents an unnecessary db call
            List<SqlParameter> args = new List<SqlParameter>();
            args.Add(new SqlParameter("@LinkMemoID", linkMemoID));
            string idList = string.Join(",", exMemberFileIDs.ToArray());
            string update = "Update FileLinks Set dLinkUpdated = GetDate(), dLinkDeleted = GetDate() " +
                "Where dLinkDeleted is Null And LinkMemoID = @LinkMemoID And FileID In (" +
                idList + ");";
            int modifiedRows = (int)Db.ExecuteNonQuery(update, args.ToArray());
            RemoveLinkIfEmpty(linkMemoID);
        }

        private static void RemoveLinkIfEmpty(int linkMemoID) {
            List<SqlParameter> args = new List<SqlParameter>();
            args.Add(new SqlParameter("@LinkMemoID", linkMemoID));
            string select = "Select Count(*) From FileLinks Where dLinkDeleted Is Null " +
                "And LinkMemoID = @LinkMemoID";
            bool isEmpty = ((int)Db.ExecuteScalar(select, args.ToArray()) == 0);
            if (isEmpty) {
                string update = "Update LinkMemos Set dMemoUpdated = GetDate(), dMemoDeleted = GetDate() " +
                    "Where LinkMemoID = @LinkMemoID And dMemoDeleted Is Null";
                int modifiedRows = (int)Db.ExecuteNonQuery(update, args.ToArray());
            }
        }
    }
}
