using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileAid.Models {
    public class FileLink {
        public int LinkMemoID { get; set; }
        public string LinkMemo { get; set; } = null;

        public List<TrackedFile> GetFiles() {
            // stub
            List<TrackedFile> dummy = new List<TrackedFile>();
            return dummy;
        }

        public void Join(List<TrackedFile> newMembers) {
            // stub
        }

        public void UpdateMemo(string memo) {
            // stub
        }

        public void RemoveMemo() {
            // stub
        }

        public void RemoveFiles(List<TrackedFile> exMembers) {
            // stub
        }
    }
}
