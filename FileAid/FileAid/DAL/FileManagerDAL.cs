using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileAid.Models;

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

        public static TrackedFile GetFile() {
            //stub
            return new TrackedFile();
        }

        public static void AddFile(TrackedFile newFile) {
            // stub
        }
    }
}
