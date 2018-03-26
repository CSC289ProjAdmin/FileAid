using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileAid.Models {
    public class Batch {
        public int BatchID { get; set; }
        public int FilesAdded { get; set; }
        public int FilesModified { get; set; }
        public int FilesDisabled { get; set; }
        public DateTime StartedAt { get; set; } = new DateTime(); // 01-01-0001
        public DateTime EndedAt { get; set; } = new DateTime(); // 01-01-0001
        public bool WasPeriodic { get; set; }
    }
}
