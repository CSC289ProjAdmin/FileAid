using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileAid.Models;
namespace FileAid.DAL {
    public static class ReminderManagerDAL {
        public static List<Reminder> GetReminders() {
            // stub
            return Db.ReadQuery<Reminder>("stub");
        }

        public static Reminder GetReminder(int reminderID) {
            // stub
            return Db.ReadQuery<Reminder>("stub")[0];
        }

        public static void AddReminder(List<int> fileIDs) {
            // stub
        }
    }
}
