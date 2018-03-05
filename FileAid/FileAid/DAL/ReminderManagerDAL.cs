using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileAid.Models;
namespace FileAid.DAL {
    public static class ReminderManagerDAL {
        public static List<Reminder> GetReminders() {
            string select = "Select ReminderID, sReminderName As Name, dDue As DueOn, " +
                "sReminderMemo As Memo, dResolved As ResolvedOn, dPushed As PushedOn " +
                "From Reminders Where dReminderDeleted Is Null";
            //! TODO: Handle nullable DateTimes
            return Db.ReadQuery<Reminder>(select);
        }

        public static Reminder GetReminder(int reminderID) {
            // stub
            return Db.ReadQuery<Reminder>("stub")[0];
        }

        public static void AddReminder(List<int> fileIDs) {
            // stub
        }
    }
/*
        public int ReminderID { get; set; }
        public string Name { get; set; }
        public DateTime DueOn { get; set; }
        public string Memo { get; set; } = null;
        public DateTime? ResolvedOn { get; set; } = null;
        public DateTime? PushedOn { get; set; } = null;


        public static List<FileLink> GetLinks() {
            string select = "Select LinkMemoID, sLinkMemo As LinkMemo From LinkMemos " +
                "Where dMemoDeleted Is Null";
            return Db.ReadQuery<FileLink>(select);
        }

        public static FileLink GetLink(int linkMemoID) {
            List<SqlParameter> args = new List<SqlParameter>();
            args.Add(new SqlParameter("@LinkMemoID", linkMemoID));
            string select = "Select LinkMemoID, sLinkMemo As LinkMemo From LinkMemos " +
                "Where dMemoDeleted Is Null And LinkMemoID = @LinkMemoID";
            List<FileLink> results = Db.ReadQuery<FileLink>(select, args.ToArray());
            if (results != null) {
                return results[0];
            } else {
                return null;
            }
        }

        public static void AddLink(List<int> fileIDs, string linkMemo) {
            // Create the link group
            List<SqlParameter> args = new List<SqlParameter>();
            args.Add(new SqlParameter("@Memo", linkMemo));
            string insert = "Insert Into LinkMemos (sLinkMemo, dMemoCreated, dMemoUpdated) " +
                "Values (@Memo, GetDate(), GetDate()); " +
                "Select Convert(int, Scope_Identity());";
            int newID = (int)Db.ExecuteScalar(insert, args.ToArray());
            // Add list of files to the group
            foreach (int id in fileIDs) {
                FileLinkDAL.Join(newID, id);
            }
        }

        public static void AddLink(List<int> fileIDs) {
            // Create the link group (without setting up a memo)
            string insert = "Insert Into LinkMemos (dMemoCreated, dMemoUpdated) " +
                "Values (GetDate(), GetDate()); " +
                "Select Convert(int, Scope_Identity());";
            int newID = (int)Db.ExecuteScalar(insert);
            // Add list of files to the group
            foreach (int id in fileIDs) {
                FileLinkDAL.Join(newID, id);
            }
        }
*/
}
