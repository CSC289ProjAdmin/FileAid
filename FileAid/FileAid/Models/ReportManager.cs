using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileAid.Models {
    public static class ReportManager {
        public static List<Report> GetReports() {
            List<Report> allReports = DAL.ReportManagerDAL.GetReports();
            return allReports;
        }

        public static Report GetReportByName(string reportName) {
            Report specific = DAL.ReportManagerDAL.GetReportByName(reportName);
            return specific;
        }
    }
}
