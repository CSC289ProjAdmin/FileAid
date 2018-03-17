using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileAid.Models {
    public static class LinkManager {
        public static List<FileLink> GetLinks() {
            List<FileLink> allLinks = DAL.LinkManagerDAL.GetLinks();
            return allLinks;
        }

        public static FileLink GetLink(int linkMemoID) {
            FileLink specific = DAL.LinkManagerDAL.GetLink(linkMemoID);
            return specific;
        }

        public static FileLink AddLink(List<int> memberFileIDs, string linkMemo) {
            int newID = DAL.LinkManagerDAL.AddLink(memberFileIDs, linkMemo);
            FileLink newLink = GetLink(newID);
            return newLink;
        }

        public static FileLink AddLink(List<int> memberFileIDs) {
            int newID = DAL.LinkManagerDAL.AddLink(memberFileIDs);
            FileLink newLink = GetLink(newID);
            return newLink;
        }
    }
}
