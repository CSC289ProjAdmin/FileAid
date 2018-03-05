using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileAid.Models {
    public class Reminder {
        public int ReminderID { get; set; }
        public string Name { get; set; }
        public DateTime DueOn { get; set; }
        public string Memo { get; set; } = null;
        public DateTime ResolvedOn { get; set; }
        public DateTime PushedOn { get; set; }

        public List<TrackedFile> GetFiles() {
            // stub
            List<TrackedFile> dummy = new List<TrackedFile>();
            return dummy;
        }

        public void RemoveFiles(List<TrackedFile> exMembers) {
            // stub
        }

        public void Resolve() {
            // stub
        }

        public void Push() {
            // stub
        }

        public void UpdateMemo(string memo) {
            // stub
        }

        public void RemoveMemo() {
            // stub
        }
    }
}
