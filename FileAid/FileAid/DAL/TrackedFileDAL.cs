using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileAid.Models;

namespace FileAid.DAL {
    public static class TrackedFileDAL {
        public static TrackedFile GetInfo() {
            //stub
            return new TrackedFile();
        }

        public static List<FileLink> GetLinks() {
            //stub
            return Db.ReadQuery<FileLink>("stub");
        }

        public static Reminder GetReminder() {
            //stub
            return Db.ReadQuery<Reminder>("stub")[0];
        }

        public static void UpdateMemo(string newMemo) {
            // stub
        }

        public static void RemoveMemo() {
            // stub
        }

        public static List<Event> GetHistory() {
            //stub
            return Db.ReadQuery<Event>("stub");
        }

        public static void StopTracking() {
            // stub
        }

        public static void StartTracking() {
            // stub
        }
    }
}
