using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using FileAid.Models;

namespace FileAidTest.Tests
{
    [TestClass]
    public class ReportManagerTest
    {
        [TestMethod]
        public void GetReportsTest()
        {
            // Get reports
            List<Report> reports = ReportManager.GetReports();

            // Verify reports were retrieved
            Assert.IsNotNull(reports);

            // Verify at least one report was retrieved
            Assert.AreNotEqual(0, reports.Count);
        }

        [TestMethod]
        public void GetReportByNameTest()
        {
            // Test Parameters 
            string reportName = "Logins";

            // Get report
            Report report = ReportManager.GetReportByName(reportName);

            // Verify the report was retrieved
            Assert.IsNotNull(report);

        }
    }
}
