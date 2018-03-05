using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileAid.Models;
using System.Data.SqlClient;

namespace FileAid.DAL {
    public static class FileManagerDAL {
        public static List<TrackedFile> GetFiles() {
            string select = "Select FileID, sFileName As Filename, sFileExt As FileExtension, sFilePath As FilePath, " +
                "iSizeInBytes As FileSize, dFileModified As ModifiedOn, dFileCreated As CreatedOn, sFileMemo As FileMemo, " +
                "dTrackingDisabled As TrackingDisabledOn, ReminderID " +
                "From TrackedFiles Where dTrackDeleted Is Null";
            //! TODO: Handle nullable DateTime
            return Db.ReadQuery<TrackedFile>(select);
        }

        public static TrackedFile GetFile(int fileID) {
            List<SqlParameter> args = new List<SqlParameter>();
            args.Add(new SqlParameter("@FileID", fileID));
            string select = "Select FileID, sFileName As Filename, sFileExt As FileExtension, sFilePath As FilePath, " +
                "iSizeInBytes As FileSize, dFileModified As ModifiedOn, dFileCreated As CreatedOn, sFileMemo As FileMemo, " +
                "dTrackingDisabled As TrackingDisabledOn, ReminderID " +
                "From TrackedFiles Where dTrackDeleted Is Null And FileID = @FileID;";
            //! TODO: Handle nullable DateTime
            List<TrackedFile> results = Db.ReadQuery<TrackedFile>(select, args.ToArray());
            if (results != null) {
                return results[0];
            } else {
                return null;
            }
        }

        public static void AddFile(TrackedFile newFile) {
            // stub
        }
    }
}
