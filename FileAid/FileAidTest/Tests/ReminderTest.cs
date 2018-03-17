using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using FileAid.Models;
using FileAid.DAL;

namespace FileAidTest.Tests {
    [TestClass]
    public class ReminderTest {
        [TestMethod]
        public void GetFilesTest()
        {
            List<TrackedFile> files = FileManagerDAL.GetFiles();
            if (files != null)
            {
                // Get reminder for first file
                TrackedFile file = files[0];
                Reminder reminder = file.GetReminder();

                // Get the count for all the files that
                // have this reminder.
                int reminderCount = 0;

                foreach(var f in files)
                {
                    if(f.ReminderID == reminder.ReminderID)
                    {
                        reminderCount++;
                    }
                }

                // Call reminder GetFiles for this reminder to get the 
                // list of files with this reminder.
                List<TrackedFile> reminderfileList = reminder.GetFiles();

                // Verify the counts are the same
                Assert.AreEqual(reminderCount, reminderfileList.Count);
            }
        }

        [TestMethod]
        public void RemoveFilesTest() {
            List<TrackedFile> files = FileManagerDAL.GetFiles();
            if (files != null && files.Count >= 3)
            {
                // Get reminder for third file
                TrackedFile file = files[2];

                if(file.ReminderID != -999)
                {
                    Reminder reminder = file.GetReminder();


                    // Call reminder GetFiles for this reminder to get the 
                    // list of files with this reminder.
                    List<TrackedFile> reminderfileList = reminder.GetFiles();

                    // Create an int list containing the third file id to remove the reminder.
                    List<int> removeList = new List<int>() { file.FileID };

                    // Remove the reminder for the files in the remove list.
                    reminder.RemoveFiles(removeList);

                    // Get the list of files assigned the reminder that was removed from the third file.
                    List<TrackedFile> reminderfileListAfterRemove = reminder.GetFiles();

                    // Verify the after remove file count list matches the before remove file
                    // count list minus the number of files in the remove list.
                    Assert.AreEqual(reminderfileListAfterRemove.Count, reminderfileList.Count - removeList.Count);
                }
            }
        }

        [TestMethod]
        public void ResolveTest() {
            List<TrackedFile> files = FileManagerDAL.GetFiles();
            if (files != null && files.Count >= 2)
            {
                // Get reminder for second file
                TrackedFile file = files[1];

                if (file.ReminderID != -999 )
                {
                    Reminder reminder = file.GetReminder();
                    DateTime defaultDateTime = new DateTime();
                    if (reminder.ResolvedOn == defaultDateTime)
                    {
                        // Verify the reminder for this file is not resolved.
                        Assert.AreEqual(defaultDateTime, reminder.ResolvedOn);

                        // Call reminder Resolve for this reminder to clear 
                        // the reminder.
                        reminder.Resolve();                        


                        // Verify the reminder for this file is resolved.
                        Assert.AreNotEqual(defaultDateTime, reminder.ResolvedOn);
                    }
                }
            }
        }

        [TestMethod]
        public void PushTest() {
            List<TrackedFile> files = FileManagerDAL.GetFiles();
            if (files != null && files.Count >= 2)
            {
                // Get reminder for second file
                TrackedFile file = files[1];

                if (file.ReminderID != -999)
                {
                    Reminder reminder = file.GetReminder();
                    DateTime defaultDateTime = new DateTime();
                    if (reminder.PushedOn == defaultDateTime)
                    {
                        // Verify the reminder for this file is not pushed.
                        Assert.AreEqual(defaultDateTime, reminder.PushedOn);

                        // Call reminder Resolve for this reminder to clear 
                        // the reminder.
                        reminder.Push();


                        // Verify the reminder for this file is resolved.
                        Assert.AreNotEqual(defaultDateTime, reminder.PushedOn);
                    }
                }
            }
        }

        [TestMethod]
        public void UpdateMemoTest() {

            string defaultMemo = "Description for memo test reminder";
            string memoUpdate = "This is updated memo text";

            List<TrackedFile> files = FileManagerDAL.GetFiles();
            if (files != null)
            {
                // Get reminder for first file
                TrackedFile file = files[0];

                if (file.ReminderID != -999)
                {
                    Reminder reminder = file.GetReminder();

                    // Store reminder memo value
                    string memo = reminder.Memo ?? "";

                    // Update reminder memo value to default text
                    reminder.UpdateMemo(defaultMemo);

                    // Verify reminder has default memo text
                    Assert.AreEqual(defaultMemo, reminder.Memo);

                    // Update reminder memo value to memo update text
                    reminder.UpdateMemo(memoUpdate);

                    // Verify the reminder has the update memo text
                    Assert.AreEqual(memoUpdate, reminder.Memo);

                    // Update reminder memo with the original memo text
                    reminder.UpdateMemo(memo);

                    // Verify the reminder has the original memo text
                    Assert.AreEqual(memo, reminder.Memo);
                }
            }
        }

        [TestMethod]
        public void RemoveMemoTest() {

            string defaultMemo = "Description for memo test reminder";
            string removedMemo = "";

            List<TrackedFile> files = FileManagerDAL.GetFiles();
            if (files != null)
            {
                // Get reminder for first file
                TrackedFile file = files[0];

                if (file.ReminderID != -999)
                {
                    Reminder reminder = file.GetReminder();

                    // Store reminder memo value
                    string memo = reminder.Memo ?? "";

                    // Update reminder memo value to default text
                    reminder.UpdateMemo(defaultMemo);

                    // Verify reminder has default memo text
                    Assert.AreEqual(defaultMemo, reminder.Memo);

                    // Remove the reminder memo
                    reminder.RemoveMemo();

                    // Verify the reminder memo has been removed
                    Assert.AreEqual(removedMemo, reminder.Memo);

                    // Update reminder memo with the original memo text
                    reminder.UpdateMemo(memo);

                    // Verify the reminder has the original memo text
                    Assert.AreEqual(memo, reminder.Memo);
                }
            }
        }

    }
}
