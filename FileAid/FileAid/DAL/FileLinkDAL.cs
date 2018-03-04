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

            // Prevent a file from being added to a group it is already in
            string select = "Select Count(*) As ExistingLinks From FileLinks " +
                "Where FileID = @FileID And LinkMemoID = @LinkMemoID And dLinkDeleted Is Null";
            bool alreadyInGroup = ((int)Db.ExecuteScalar(select, args.ToArray()) > 0);
            if (!alreadyInGroup) {
                string insert = "Insert Into FileLinks (FileID, LinkMemoID, dLinkCreated, dLinkUpdated) "+
                    "Values (@FileID, @LinkMemoID, GetDate(), GetDate());" +
                    "Select Convert(int, Scope_Identity());";
                int newID = (int)Db.ExecuteScalar(insert, args.ToArray());
                if (!(newID > 0)) {
                    throw new Exception();
                }
            }
        }

        public static void UpdateMemo(string newMemo) {
            // stub
        }

        public static void RemoveMemo() {
            // stub
        }

        public static void RemoveFiles(List<int> exMemberFileIDs) {
            // stub
        }
    }
}
