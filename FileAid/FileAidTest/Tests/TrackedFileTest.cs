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
        public void GetReminderTest()
        {
            List<TrackedFile> files = FileManagerDAL.GetFiles();
            if (files != null)
            {
                // Test reminders for first file
                TrackedFile file = files[0];
                Reminder reminder = file.GetReminder();

                //Assert for file 1
                Assert.AreEqual(1, reminder.ReminderID);
                Assert.AreEqual("First reminder", reminder.Name);
                Assert.AreEqual("Description for first reminder", reminder.Memo);
                
                //Assert for file 2
                file = files[1];
                reminder = file.GetReminder();
                Assert.IsNull(reminder);
            }
        }

        [TestMethod]
        public void RemoveMemoTest()
        {
            List<TrackedFile> files = FileManagerDAL.GetFiles();
            if (files != null)
            {
                TrackedFile file = files[0];

                Assert.AreEqual("Description of first file", file.FileMemo);

                file.RemoveMemo();

                Assert.AreEqual("", file.FileMemo);
            }
        }

        [TestMethod]
        public void UpdateMemoTest() {
            List<TrackedFile> files = FileManagerDAL.GetFiles();
            if (files != null)
            {
                // Test reminders for first file
                TrackedFile file = files[0];

                Assert.IsNull(file.FileMemo);

                file.UpdateMemo("Description of first file");

                Assert.AreEqual("Description of first file", file.FileMemo);
            }
        }

        [TestMethod]
        public void GetHistoryTest() {
            List<TrackedFile> files = FileManagerDAL.GetFiles();
            if (files != null)
            {
                // File 1 history
                TrackedFile file = files[0];

                List<Event> events = file.GetHistory();

                Assert.AreEqual(1, events.Count);
                Assert.AreEqual("First file added to system", events[0].Description);

                // File 2 history
                file = files[1];
                events = file.GetHistory();
                Assert.IsNull(events);

            }
        }

        [TestMethod]
        public void StopTrackingTest() {
            List<TrackedFile> files = FileManagerDAL.GetFiles();
            if (files != null)
            {
                TrackedFile file = files[0];

                file.StartTracking();

                Assert.AreEqual(new DateTime(), file.TrackingDisabledOn);
                
                file.StopTracking();

                Assert.AreNotEqual(new DateTime(), file.TrackingDisabledOn);
                             
            }
        }

        [TestMethod]
        public void StartTrackingTest() {
            List<TrackedFile> files = FileManagerDAL.GetFiles();
            if (files != null)
            {
                TrackedFile file = files[0];

                file.StopTracking();

                Assert.AreNotEqual(new DateTime(), file.TrackingDisabledOn);

                file.StartTracking();

                Assert.AreEqual(new DateTime(), file.TrackingDisabledOn);

            }
        }
    }
}
