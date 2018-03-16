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
            List<TrackedFile> myFiles = DAL.FileLinkDAL.GetFiles(this.LinkMemoID);
            return myFiles;
        }

        public bool Join(int newMemberFileID) {
            bool wasJoined = DAL.FileLinkDAL.Join(this.LinkMemoID, newMemberFileID);
            return wasJoined;
        }

        public bool UpdateMemo(string memo) {
            bool wasUpdated = DAL.FileLinkDAL.UpdateMemo(this.LinkMemoID, memo);
            if (wasUpdated) LinkMemo = memo;
            return wasUpdated;
        }

        public bool RemoveMemo() {
            bool wasRemoved = DAL.FileLinkDAL.RemoveMemo(this.LinkMemoID);
            if (wasRemoved) LinkMemo = "";
            return wasRemoved;
        }

        public bool RemoveFiles(List<int> exMemberFileIDs) {
            bool wereRemoved = DAL.FileLinkDAL.RemoveFiles(this.LinkMemoID, exMemberFileIDs);
            return wereRemoved;
        }
    }
}
