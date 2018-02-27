using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FileAidTest.Tests {
    [TestClass]
    public class LoggerTest {
        [TestMethod]
        public void LogTest() {
            Assert.AreEqual(1, 2);
        }

        [TestMethod]
        public void LogToDbTest() {
            Assert.AreEqual(1, 2);
        }

        [TestMethod]
        public void LogToFileTest() {
            Assert.AreEqual(1, 2);
        }
    }
}
