using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileAid.Models {
    public class Configs {
        public int ConfigID { get; set; }
        public int UpdateTimerInMinutes { get; set; }
        public bool ShowInactive { get; set; }
        public bool InUpdateMode { get; set; }
        //public string SearchFolder { get; set; }
        // stub
    }
}
