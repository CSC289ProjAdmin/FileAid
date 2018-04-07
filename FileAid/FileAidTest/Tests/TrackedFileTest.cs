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
        public void UpdateInfoTest()
        {
            List<TrackedFile> files = FileManagerDAL.GetFiles();
            if (files != null)
            {
                // Get one of the files and modify the file name
                TrackedFile first = files[0];
                string fileName = first.Filename;
                string newFileName = fileName + "TestName";
                first.Filename = newFileName;

                // Verify the filename has been changed for the object
                Assert.AreNotEqual(fileName, first.Filename);
                Assert.AreEqual(newFileName, first.Filename);

                // Update Info for the object
                first.UpdateInfo();

                // Verify info was updated for the object
                Assert.AreEqual(fileName, first.Filename);
                Assert.AreNotEqual(newFileName, first.Filename);

            }
        }

        [TestMethod]
        public void GetLinksTest()
        {
            // Test Parameters
            bool linksFound = false;

            // Get tracked files
            List<TrackedFile> files = FileManagerDAL.GetFiles();

            // Verify there are tracked files returned
            Assert.IsNotNull(files, "No tracked files found.");

            // Search for a link in the tracked files
            foreach (var file in files)
            {
                if (file.GetLinks() != null)
                {
                    // Get Links Successful and break
                    linksFound = true;
                    break;
                }
            }

            // Verify a link was found with one of the files
            Assert.IsTrue(linksFound, "No links found in the tracked files.");
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
                
            }
        }

        [TestMethod]
        public void RemoveMemoTest()
        {
            string defaultMemo = "Description for memo test reminder";
            string removedMemo = "";

            List<TrackedFile> files = FileManagerDAL.GetFiles();
            if (files != null)
            {
                TrackedFile file = files[0];

                // Store the current file memo
                string currentMemo = file.FileMemo ?? "";

                // Update the file to default text
                file.UpdateMemo(defaultMemo);

                // Verify file has the default memo text
                Assert.AreEqual(defaultMemo, file.FileMemo);

                // Remove the file memo
                file.RemoveMemo();

                // Verify the file memo has been removed
                Assert.AreEqual(removedMemo, file.FileMemo);

                // Update the file memo to the original memo text
                file.UpdateMemo(currentMemo);

                // Verify the file memo has the original memo text
                Assert.AreEqual(currentMemo, file.FileMemo);

            }
        }

        [TestMethod]
        public void UpdateMemoTest()
        {
            string defaultMemo = "Description for memo test reminder";
            string updateMemo = "This is updated memo text";

            List<TrackedFile> files = FileManagerDAL.GetFiles();
            if (files != null)
            {
                TrackedFile file = files[0];

                // Store the current file memo
                string currentMemo = file.FileMemo ?? "";

                // Update the file to default text
                file.UpdateMemo(defaultMemo);

                // Verify file has the default memo text
                Assert.AreEqual(defaultMemo, file.FileMemo);

                // Remove the file memo
                file.UpdateMemo(updateMemo);

                // Verify the file memo has been removed
                Assert.AreEqual(updateMemo, file.FileMemo);

                // Update the file memo to the original memo text
                file.UpdateMemo(currentMemo);

                // Verify the file memo has the original memo text
                Assert.AreEqual(currentMemo, file.FileMemo);

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
                if (events != null) {
                    Assert.AreEqual(1, events.Count);
                    Assert.AreEqual("First file added to system", events[0].Description);
                    
                    // File 2 history
                    file = files[1];
                    events = file.GetHistory();
                    Assert.IsNull(events);
                }
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
