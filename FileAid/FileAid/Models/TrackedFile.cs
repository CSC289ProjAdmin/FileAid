using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileAid.Models {
    public class TrackedFile {
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
