using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileAid.Models {
    public static class DbManager {
        public static bool Reset() {
            bool wasReset = false;
            return wasReset;
        }

        public static bool Backup(string destFolderName) {
            // TODO: Verify folder exists before trying to save to it
            bool wasBackedUp = DAL.DbManagerDAL.Backup(destFolderName);
            return wasBackedUp;
        }

        public static bool Restore(string srcFilename) {
            // TODO: Verify file exists before trying to restore it
            bool wasRestored = DAL.DbManagerDAL.Restore(srcFilename);
            return wasRestored;
        }
    }
}
