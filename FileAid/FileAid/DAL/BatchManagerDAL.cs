using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileAid.Models;
using System.Data.SqlClient;

namespace FileAid.DAL {
    public static class BatchManagerDAL {
        public static List<Batch> GetBatches() {
            string select = "Select BatchID, iAdded As FilesAdded, iModified As FilesModified, " +
                "iDisabled As FilesDisabled, dBatchStart As StartedAt, dBatchEnd As EndedAt " +
                "bPeriodic As WasPeriodic " +
                "From Batches Where dBatchDeleted Is Null;";
            return Db.ReadQuery<Batch>(select);
        }

        public static Batch GetBatch(int batchID) {
            if (batchID <= 0) return null;
            List<SqlParameter> args = new List<SqlParameter>();
            args.Add(new SqlParameter("@BatchID", batchID));
            string select = "Select BatchID, iAdded As FilesAdded, iModified As FilesModified, " +
                "iDisabled As FilesDisabled, dBatchStart As StartedAt, dBatchEnd As EndedAt " +
                "bPeriodic As WasPeriodic " +
                "From Batches Where dBatchDeleted Is Null And BatchID = @BatchID; ";
            List<Batch> results = Db.ReadQuery<Batch>(select, args.ToArray());
            if (results != null) {
                return results[0];
            } else {
                return null;
            }
        }
    }
}
/*
namespace FileAid.DAL {
    public static class ReminderManagerDAL {

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
*/
