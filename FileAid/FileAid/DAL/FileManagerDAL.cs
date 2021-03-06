﻿using System;
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
            if (fileID <= 0) return null;
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

        public static int AddFile(string filename, string extension, string path, int filesize,
                DateTime created, DateTime modified, string memo) {
            List<SqlParameter> args = new List<SqlParameter>();
            args.Add(new SqlParameter("@FileName", filename));
            args.Add(new SqlParameter("@FileExt", extension));
            args.Add(new SqlParameter("@FilePath", path));
            args.Add(new SqlParameter("@FileSize", filesize));
            args.Add(new SqlParameter("@CreatedOn", System.Data.SqlDbType.DateTime));
            args[4].Value = created;
            args.Add(new SqlParameter("@ModifiedOn", System.Data.SqlDbType.DateTime));
            args[5].Value = modified;
            args.Add(new SqlParameter("@Memo", memo));
            string insert = "Insert Into TrackedFiles " +
                "(sFileName, sFileExt, sFilePath, iSizeInBytes, dFileModified, dFileCreated, sFileMemo, dTrackCreated, dTrackUpdated) " +
                "Values (@FileName, @FileExt, @FilePath, @FileSize, @ModifiedOn, @CreatedOn, @Memo, GetDate(), GetDate()); " +
                "Select Convert(int, Scope_Identity());";
            int newID = (int)Db.ExecuteScalar(insert, args.ToArray());
            return newID;
        }

        public static int AddFile(string filename, string extension, string path, int filesize,
                DateTime created, DateTime modified) {
            List<SqlParameter> args = new List<SqlParameter>();
            args.Add(new SqlParameter("@FileName", filename));
            args.Add(new SqlParameter("@FileExt", extension));
            args.Add(new SqlParameter("@FilePath", path));
            args.Add(new SqlParameter("@FileSize", filesize));
            args.Add(new SqlParameter("@CreatedOn", System.Data.SqlDbType.DateTime));
            args[4].Value = created;
            args.Add(new SqlParameter("@ModifiedOn", System.Data.SqlDbType.DateTime));
            args[5].Value = modified;
            string insert = "Insert Into TrackedFiles " +
                "(sFileName, sFileExt, sFilePath, iSizeInBytes, dFileModified, dFileCreated, dTrackCreated, dTrackUpdated) " +
                "Values (@FileName, @FileExt, @FilePath, @FileSize, @ModifiedOn, @CreatedOn, GetDate(), GetDate()); " +
                "Select Convert(int, Scope_Identity());";
            int newID = (int)Db.ExecuteScalar(insert, args.ToArray());
            return newID;
        }

        public static bool Exists(string fullFilename) {
            string filename = System.IO.Path.GetFileNameWithoutExtension(fullFilename);
            string extension = System.IO.Path.GetExtension(fullFilename).Substring(1);
            string path = System.IO.Path.GetDirectoryName(fullFilename);
            string pathWithDelimiter = (path.EndsWith("\\") ? path : path + "\\");
            List<SqlParameter> args = new List<SqlParameter>();
            args.Add(new SqlParameter("@FileName", filename));
            args.Add(new SqlParameter("@FileExt", extension));
            args.Add(new SqlParameter("@FilePath", path));
            args.Add(new SqlParameter("@FilePath2", pathWithDelimiter));
            string select = "Select Count(*) From TrackedFiles " +
                "Where sFileName = @FileName And sFileExt = @FileExt " +
                "And (sFilePath = @FilePath Or sFilePath = @FilePath2) " +
                "And dTrackDeleted Is Null;";
            int count = (int)Db.ExecuteScalar(select, args.ToArray());
            bool isInSystem = (count == 1);
            return isInSystem;
        }
    }
}
