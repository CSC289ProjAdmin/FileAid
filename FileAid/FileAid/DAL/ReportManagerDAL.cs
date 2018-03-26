using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileAid.Models;
using System.Data.SqlClient;

namespace FileAid.DAL {
    public static class ReportManagerDAL {
        public static List<Report> GetReports() {
            string select = "Select ReportID, sReportName As Name, sReportDescription As Description " +
                "From Reports Where dReportDeleted Is Null; ";
            return Db.ReadQuery<Report>(select);
        }

        public static Report GetReportByName(string reportName) {
            List<SqlParameter> args = new List<SqlParameter>();
            args.Add(new SqlParameter("@Name", reportName));
            string select = "Select ReportID, sReportName As Name, sReportDescription As Description " +
                "From Reports Where dReportDeleted Is Null And sReportName = @Name; ";
            List<Report> results = Db.ReadQuery<Report>(select, args.ToArray());
            if (results != null) {
                return results[0];
            } else {
                return null;
            }
        }
    }
}
