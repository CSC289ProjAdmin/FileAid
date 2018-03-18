using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileAid.Models {
    public enum EventTypes {
        Invalid = -999,

        FileAdded = 1,
        FileModified,
        FileTrackingStopped,
        FileTrackingStarted,
        FileMemoUpdated,
        FileMemoRemoved,
        FileReminderSet,

        FileLinkAdded,
        FileLinkJoinedGroup,
        FileLinkLeftGroup,
        FileLinkMemoUpdated,
        FileLinkMemoRemoved,

        ReminderAdded,
        ReminderResolved,
        ReminderPushed,
        ReminderMemoUpdated,
        ReminderMemoRemoved,

        LoginSuccess,
        LoginFailure,
        UserLockedOut,
        UserUnlocked,
        UserDisabled,
        UserEnabled,
        UserPasswordChanged,
        UserPasswordReset,
        UserPermsChanged,

        BatchManualStarted,
        BatchAutoStarted,
        BatchCompleted,

        DbBackedUp,
        DbRestored,
        DbReset,

        ReportRun
    }
    public class Event {
        public int EventID { get; set; } = -999;
        public int EventTypeID { get; set; } = -999;
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
