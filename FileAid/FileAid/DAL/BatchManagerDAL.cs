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
                "iDisabled As FilesDisabled, dBatchStart As StartedAt, dBatchEnd As EndedAt, " +
                "bPeriodic As WasPeriodic " +
                "From Batches Where dBatchDeleted Is Null;";
            return Db.ReadQuery<Batch>(select);
        }

        public static Batch GetBatch(int batchID) {
            if (batchID <= 0) return null;
            List<SqlParameter> args = new List<SqlParameter>();
            args.Add(new SqlParameter("@BatchID", batchID));
            string select = "Select BatchID, iAdded As FilesAdded, iModified As FilesModified, " +
                "iDisabled As FilesDisabled, dBatchStart As StartedAt, dBatchEnd As EndedAt, " +
                "bPeriodic As WasPeriodic " +
                "From Batches Where dBatchDeleted Is Null And BatchID = @BatchID; ";
            List<Batch> results = Db.ReadQuery<Batch>(select, args.ToArray());
            if (results != null) {
                return results[0];
            } else {
                return null;
            }
        }

        public static int AddBatch(int nAdded, int nModified, int nDisabled,
            DateTime started, DateTime ended, bool isPeriodic) {
            List<SqlParameter> args = new List<SqlParameter>();
            args.Add(new SqlParameter("@Added", nAdded));
            args.Add(new SqlParameter("@Modified", nModified));
            args.Add(new SqlParameter("@Disabled", nDisabled));
            args.Add(new SqlParameter("@Start", System.Data.SqlDbType.DateTime));
            args[3].Value = started;
            args.Add(new SqlParameter("@End", System.Data.SqlDbType.DateTime));
            args[4].Value = ended;
            args.Add(new SqlParameter("@Periodic", isPeriodic));
            string insert = "Insert Into Batches " +
                "(iAdded, iModified, iDisabled, dBatchStart, dBatchEnd, bPeriodic, dBatchCreated, dBatchUpdated) " +
                "Values (@Added, @Modified, @Disabled, @Start, @End, @Periodic, GetDate(), GetDate()); " +
                "Select Convert(int, Scope_Identity()); ";
            int newID = (int)Db.ExecuteScalar(insert, args.ToArray());
            return newID;
        }
    }
}
