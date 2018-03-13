using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using FileAid.Models;
using FileAid.DAL;

namespace FileAidTest.Tests {
    [TestClass]
    public class TrackedFileTest {
        [TestMethod]
        public void GetInfoTest() {
            List<TrackedFile> files = FileManagerDAL.GetFiles();
            if (files != null) {
                TrackedFile first = files[0];
                string originalName = first.Filename;
                string newName = "Something different than what we know it is";
                first.Filename = newName; // only updating the in-memory object; not database
                first.GetInfo(); // refresh object information from database
                string actual = first.Filename;
                Assert.AreNotEqual(newName, actual);
                Assert.AreEqual(originalName, actual);
            }
        }

        [TestMethod]
        public void GetLinksTest() {
            List<TrackedFile> files = FileManagerDAL.GetFiles();
            if (files != null) {
                TrackedFile first = files[0];
                List<FileLink> links = first.GetLinks();
                if (links != null) {
                    int expectedLinkCount = 1;
                    int actualLinkCount = links.Count;
                    Assert.AreEqual(expectedLinkCount, actualLinkCount);
                }
            }
        }

        [TestMethod]
        public void GetReminderTest() {
            Assert.AreEqual(1, 2);
        }

        [TestMethod]
        public void UpdateMemoTest() {
            Assert.AreEqual(1, 2);
        }

        [TestMethod]
        public void RemoveMemoTest() {
            Assert.AreEqual(1, 2);
        }

        [TestMethod]
        public void GetHistoryTest() {
            Assert.AreEqual(1, 2);
        }

        [TestMethod]
        public void StopTrackingTest() {
            Assert.AreEqual(1, 2);
        }

        [TestMethod]
        public void StartTrackingTest() {
            Assert.AreEqual(1, 2);
        }
    }
}
