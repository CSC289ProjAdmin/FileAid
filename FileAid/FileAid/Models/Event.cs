using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileAid.Models {
    public enum EventTypes {
        Invalid = -999,

        FileAdded = 1,
        FileModified = 2,
        FileTrackingStopped = 3,
        FileTrackingStarted = 4,
        FileMemoUpdated = 5,
        FileMemoRemoved = 6,
        FileReminderSet = 7,

        FileLinkAdded = 8,
        FileLinkJoinedGroup = 9,
        FileLinkLeftGroup = 10,
        FileLinkMemoUpdated = 11,
        FileLinkMemoRemoved = 12,

        ReminderAdded = 13,
        ReminderResolved = 14,
        ReminderPushed = 15,
        ReminderMemoUpdated = 16,
        ReminderMemoRemoved = 17,

        LoginSuccess = 18,
        LoginFailure = 19,
        UserLockedOut = 20,
        UserUnlocked = 21,
        UserDisabled = 22,
        UserEnabled = 23,
        UserPasswordChanged = 24,
        UserPasswordReset = 25,
        UserPermsChanged = 26,

        DbBackedUp = 27,
        DbRestored = 28,
        DbReset = 29,

        BatchManualStarted = 30,
        BatchAutoStarted = 31,
        BatchCompleted = 32,

        ReportRun = 33,

        ProgramSettingsChanged = 34
    }
    public class Event {
        public int EventID { get; set; } = -999;
        public EventTypes EventTypeID { get; set; } = EventTypes.Invalid;
        public DateTime OccurredOn { get; set; }
        public string Description { get; set; }
        public string Initial { get; set; }
        public string New { get; set; }
        public int FileID { get; set; } = -999;
        public int LinkID { get; set; } = -999;
        public int ReportID { get; set; } = -999;
        public int ReminderID { get; set; } = -999;
        public int BatchID { get; set; } = -999;
        public int UserID { get; set; } = -999;
        public int LoginID { get; set; } = -999;
        public int PermID { get; set; } = -999;
        public int ConfigID { get; set; } = -999;
        // stub
    }
}
