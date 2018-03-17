using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileAid.Models {
    public static class ReminderManager {
        public static List<Reminder> GetReminders() {
            List<Reminder> allReminders = DAL.ReminderManagerDAL.GetReminders();
            return allReminders;
        }

        public static Reminder GetReminder(int reminderID) {
            Reminder specific = DAL.ReminderManagerDAL.GetReminder(reminderID);
            return specific;
        }

        public static Reminder AddReminder(List<int> memberFileIDs, string name, 
                DateTime dueOn, string memo) {
            int newID = DAL.ReminderManagerDAL.AddReminder(memberFileIDs, name, dueOn, memo);
            Reminder newReminder = GetReminder(newID);
            return newReminder;
        }

        public static Reminder AddReminder(List<int> memberFileIDs, string name, 
                DateTime dueOn) {
            int newID = DAL.ReminderManagerDAL.AddReminder(memberFileIDs, name, dueOn);
            Reminder newReminder = GetReminder(newID);
            return newReminder;
        }
    }
}
