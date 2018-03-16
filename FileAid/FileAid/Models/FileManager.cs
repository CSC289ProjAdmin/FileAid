using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileAid.Models {
    public static class FileManager {
        public static List<TrackedFile> GetFiles() {
            List<TrackedFile> myFiles = DAL.FileManagerDAL.GetFiles();
            return myFiles;
        }

        public static TrackedFile GetFile(int fileID) {
            TrackedFile file = DAL.FileManagerDAL.GetFile(fileID);
            return file;
        }

        public static bool AddFile(string filename, string extension, string path, int filesize,
                DateTime created, DateTime modified, string memo) {
            bool wasAdded = DAL.FileManagerDAL.AddFile(filename, extension, path, filesize,
                created, modified, memo);
            return wasAdded;
        }

        public static bool AddFile(string filename, string extension, string path, int filesize,
                DateTime created, DateTime modified) {
            bool wasAdded = DAL.FileManagerDAL.AddFile(filename, extension, path, filesize,
                created, modified);
            return wasAdded;
        }
    }
}
