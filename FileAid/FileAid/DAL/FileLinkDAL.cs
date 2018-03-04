using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileAid.Models;

namespace FileAid.DAL {
    public static class FileLinkDAL {
        public static List<TrackedFile> GetFiles() {
            // stub
            return Db.ReadQuery<TrackedFile>("stub");
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
