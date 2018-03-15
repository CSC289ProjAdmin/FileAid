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
            List<TrackedFile> myFiles = DAL.ReminderDAL.GetFiles(this.ReminderID);
            return myFiles;
        }

        public bool Join(int newMemberFileID) {
            bool wasJoined = DAL.ReminderDAL.Join(this.ReminderID, newMemberFileID);
            return wasJoined;
        }

        public bool RemoveFiles(List<int> exMemberFileIDs) {
            bool wereRemoved = DAL.ReminderDAL.RemoveFiles(this.ReminderID, exMemberFileIDs);
            return wereRemoved;
        }

        public bool Resolve() {
            bool wasResolved = DAL.ReminderDAL.Resolve(this.ReminderID);
            if (wasResolved) ResolvedOn = DateTime.Now;
            return wasResolved;
        }

        public bool Push() {
            bool wasPushed = DAL.ReminderDAL.Push(this.ReminderID);
            if (wasPushed) PushedOn = DateTime.Now;
            return wasPushed;
        }

        public bool UpdateMemo(string memo) {
            bool wasUpdated = DAL.ReminderDAL.UpdateMemo(this.ReminderID, memo);
            if (wasUpdated) Memo = memo;
            return wasUpdated;
        }

        public bool RemoveMemo() {
            bool wasRemoved = DAL.ReminderDAL.RemoveMemo(this.ReminderID);
            if (wasRemoved) Memo = "";
            return wasRemoved;
        }
    }
}
