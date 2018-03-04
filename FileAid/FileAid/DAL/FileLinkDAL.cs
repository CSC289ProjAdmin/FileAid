using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileAid.Models;
using System.Data.SqlClient;

namespace FileAid.DAL {
    public static class FileLinkDAL {
        public static List<TrackedFile> GetFiles(int linkID) {
            string select = "Select FileID, sFileName As Filename, sFileExt As FileExtension, " +
                "sFilePath As FilePath, iSizeInBytes As FileSize, dFileModified As ModifiedOn, " +
                "dFileCreated As CreatedOn, sFileMemo As FileMemo, " +
                "dTrackingDisabled As TrackingDisabledOn, ReminderID From TrackedFiles " +
                "Inner Join FileLinks On TrackedFiles.FileID = FileLinks.FileID " +
                "Where dTrackDeleted Is Null " +
                "And dLinkDeleted Is Null And LinkID = @LinkID ";
            List<SqlParameter> args = new List<SqlParameter>();
            args.Add(new SqlParameter("@LinkID", linkID));
            return Db.ReadQuery<TrackedFile>(select, args.ToArray());
        }

        public static void Join(int memberFileID) {
            // stub
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
