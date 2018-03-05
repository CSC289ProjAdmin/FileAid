using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileAid.Models;
using System.Data.SqlClient;

namespace FileAid.DAL {
    public static class TrackedFileDAL {
        public static TrackedFile GetInfo() {
            //stub
            return new TrackedFile();
        }

        public static List<FileLink> GetLinks(int fileID) {
            if (fileID <= 0) return null; // not required but prevents an unnecessary db call
            List<SqlParameter> args = new List<SqlParameter>();
            args.Add(new SqlParameter("@FileID", fileID));
            string select = "Select LM.LinkMemoID, sLinkMemo As LinkMemo " +
                "From LinkMemos LM Inner Join FileLinks FL On LM.LinkMemoID = FL.LinkMemoID " +
                "Where FileID = @FileID And dLinkDeleted Is Null And dMemoDeleted Is Null;";
            return Db.ReadQuery<FileLink>(select, args.ToArray());
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
