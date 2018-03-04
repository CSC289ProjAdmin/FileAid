using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileAid.Models;

namespace FileAid.DAL {
    public static class LinkManagerDAL {
        public static List<FileLink> GetLinks() {
            string select = "Select LinkMemoID, sLinkMemo As LinkMemo From LinkMemos " +
                "Where dMemoDeleted Is Null";
            return Db.ReadQuery<FileLink>(select);
        }

        public static FileLink GetLink() {
            // stub
            return Db.ReadQuery<FileLink>("stub")[0];
        }

        public static void AddLink(List<int> fileIDs) {
            // stub
        }
    }
}
