using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileAid.Models {
    public class Event {
        public int EventID { get; set; } = -999;
        public int EventTypeID { get; set; } = -999;
        public DateTime OccurredOn { get; set; }
        public string Description { get; set; }
        public string Initial { get; set; }
        public string New { get; set; }
        /* Is it necessary to include these IDs in the object?
        */
        public int FileID { get; set; } = -999;
        public int LinkID { get; set; } = -999;
        public int ReportID { get; set; } = -999;
        public int ReminderID { get; set; } = -999;
        public int BatchID { get; set; } = -999;
        public int UserID { get; set; } = -999;
        public int LoginID { get; set; } = -999;
        public int PermID { get; set; } = -999;
        public int ConfigID { get; set; } = -999;
        /**/
        // stub
    }
}
