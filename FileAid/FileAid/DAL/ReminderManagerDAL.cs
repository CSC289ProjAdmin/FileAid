using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileAid.Models;
using System.Data.SqlClient;

namespace FileAid.DAL {
    public static class ReminderManagerDAL {
        public static List<Reminder> GetReminders() {
            string select = "Select ReminderID, sReminderName As Name, dDue As DueOn, " +
                "sReminderMemo As Memo, dResolved As ResolvedOn, dPushed As PushedOn " +
                "From Reminders Where dReminderDeleted Is Null;";
            //! TODO: Handle nullable DateTimes
            return Db.ReadQuery<Reminder>(select);
        }

        public static Reminder GetReminder(int reminderID) {
            if (reminderID <= 0) return null;
            List<SqlParameter> args = new List<SqlParameter>();
            args.Add(new SqlParameter("@ReminderID", reminderID));
            string select = "Select ReminderID, sReminderName As Name, dDue As DueOn, " +
                "sReminderMemo As Memo, dResolved As ResolvedOn, dPushed As PushedOn " +
                "From Reminders Where dReminderDeleted Is Null And ReminderID = @ReminderID;";
            //! TODO: Handle nullable DateTimes
            List<Reminder> results = Db.ReadQuery<Reminder>(select, args.ToArray());
            if (results != null) {
                return results[0];
            } else {
                return null;
            }
        }

        public static int AddReminder(List<int> fileIDs, string reminderName, 
                DateTime dueOn, string reminderMemo) {
            // Create the reminder
            List<SqlParameter> args = new List<SqlParameter>();
            args.Add(new SqlParameter("@Name", reminderName));
            args.Add(new SqlParameter("@DueOn", System.Data.SqlDbType.DateTime));
            args[1].Value = dueOn;
            args.Add(new SqlParameter("@Memo", reminderMemo));
            string insert = "Insert Into Reminders " +
                "(sReminderName, dDue, sReminderMemo, dReminderCreated, dReminderUpdated) " +
                "Values (@Name, @DueOn, @Memo, GetDate(), GetDate()); " +
                "Select Convert(int, Scope_Identity());";
            int newID = (int)Db.ExecuteScalar(insert, args.ToArray());
            // Add list of files to the group
            foreach (int id in fileIDs) {
                ReminderDAL.Join(newID, id);
            }
            return newID;
        }

        public static int AddReminder(List<int> fileIDs, string reminderName, DateTime dueOn) {
            // Create the reminder (without setting up a memo/description)
            List<SqlParameter> args = new List<SqlParameter>();
            args.Add(new SqlParameter("@Name", reminderName));
            args.Add(new SqlParameter("@DueOn", System.Data.SqlDbType.DateTime));
            args[1].Value = dueOn;
            string insert = "Insert Into Reminders " +
                "(sReminderName, dDue, dReminderCreated, dReminderUpdated) " +
                "Values (@Name, @DueOn, GetDate(), GetDate()); " +
                "Select Convert(int, Scope_Identity());";
            int newID = (int)Db.ExecuteScalar(insert, args.ToArray());
            // Add list of files to the group
            foreach (int id in fileIDs) {
                ReminderDAL.Join(newID, id);
            }
            return newID;
        }
    }
}    
