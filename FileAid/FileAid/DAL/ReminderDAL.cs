using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileAid.Models;

namespace FileAid.DAL {
    public static class ReminderDAL {
        public static List<TrackedFile> GetFiles() {
            // stub
            return Db.ReadQuery<TrackedFile>("stub");
        }

        public static void RemoveFiles(List<int> exMemberFileIDs) {
            // stub
        }

        public static void Resolve() {
            // stub
        }

        public static void Push() {
            // stub
        }

        public static void UpdateMemo(string newMemo) {
            // stub
        }

        public static void RemoveMemo() {
            // stub
        }
    }
}
