using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileAid.Models {
    public class TrackedFile {
        public int FileID { get; set; }
        public string Filename { get; set; }
        public string FileExtension { get; set; }
        public string FilePath { get; set; }
        public int FileSize { get; set; }
        public DateTime ModifiedOn { get; set; }
        public DateTime CreatedOn { get; set; }
        public string FileMemo { get; set; } = null;
        public DateTime TrackingDisabledOn { get; set; }
        public int ReminderID { get; set; } = -999;

        public string GetInfo() {
            // stub
            return "dummy";
        }

        public List<FileLink> GetLinks() {
            // stub
            List<FileLink> dummy = new List<FileLink>();
            return dummy;
        }

        public Reminder GetReminder() {
            // stub
            Reminder dummy = new Reminder();
            return dummy;
        }

        public void UpdateMemo(string memo) {
            // stub
        }

        public void RemoveMemo() {
            // stub
        }

        public List<Event> GetHistory() {
            // stub
            List<Event> dummy = new List<Event>();
            return dummy;
        }

        public void StopTracking() {
            // stub
        }

        public void StartTracking() {
            // stub
        }
    }
}
