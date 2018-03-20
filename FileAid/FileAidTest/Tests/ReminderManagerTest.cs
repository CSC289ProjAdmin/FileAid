using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using FileAid.Models;

namespace FileAidTest.Tests {
    [TestClass]
    public class ReminderManagerTest {
        [TestMethod]
        public void GetRemindersTest() {

            // Add reminder
            ReminderManager.AddReminder(new List<int> { 1 }, "Test Reminder", DateTime.Now);

            // Get all reminders
            List<Reminder> remindersList = ReminderManager.GetReminders();

            // Verify there is at least one reminder
            Assert.IsNotNull(remindersList);
        }

        [TestMethod]
        public void GetReminderTest() {


            ReminderManager.AddReminder(new List<int> { 1 }, "Test add reminder", DateTime.Now);

            // Get reminders
            List <Reminder> reminderList= ReminderManager.GetReminders();

            // Store some data for one of the reminders
            int reminderId = reminderList[0].ReminderID;
            string linkName = reminderList[0].Name;

            // Get reminder
            Reminder reminder = ReminderManager.GetReminder(reminderId);

            // Verify the expected reminder is returned
            Assert.IsNotNull(reminder);
            Assert.AreEqual(linkName, reminder.Name);
        }

        [TestMethod]
        public void AddReminderTest() {

            int reminderCount = 0;

            // Add a default reminder and then get current reminder count
            ReminderManager.AddReminder(new List<int> { 1 }, "Test add reminder", DateTime.Now);
            List < Reminder > remindersList = ReminderManager.GetReminders();
            reminderCount = remindersList.Count;

            // Add reminder without memo
            ReminderManager.AddReminder(new List<int> { 1 }, "Test add reminder without memo", DateTime.Now);

            // Verify the reminder was added
            remindersList = ReminderManager.GetReminders();
            Assert.AreEqual(reminderCount + 1, remindersList.Count);

            //Add reminder with memo
            ReminderManager.AddReminder(new List<int> { 1 }, "Test reminder with memo", DateTime.Now, "Description for added reminder");
            remindersList = ReminderManager.GetReminders();
            Assert.AreEqual(reminderCount + 2, remindersList.Count);
        }
    }
}
