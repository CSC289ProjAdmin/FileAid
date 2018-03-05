using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileAid.Models {
    public class Event {
        public int EventID { get; set; }
        public int EventTypeID { get; set; }
        public DateTime OccurredOn { get; set; }
        public string Description { get; set; } = null;
        public string Initial { get; set; } = null;
        public string New { get; set; } = null;
        /* Is it necessary to include these IDs in the object?
        public int? FileID { get; set; } = null;
        public int? LinkID { get; set; } = null;
        public int? ReportID { get; set; } = null;
        public int? ReminderID { get; set; } = null;
        public int? BatchID { get; set; } = null;
        public int? UserID { get; set; } = null;
        public int? LoginID { get; set; } = null;
        public int? PermID { get; set; } = null;
        public int? ConfigID { get; set; } = null;
        */
        // stub
    }
}
