using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileAid.Models {
    public class Permissions {
        public int PermID { get; set; }
        public bool ChangeAdminPass { get; set; }
        public bool ChangeUserPass { get; set; }
        public bool ChangeGuestPass { get; set; }
        public bool EnableUser { get; set; }
        public bool EnableGuest { get; set; }
        public bool ResetUserPass { get; set; }
        public bool ResetGuestPass { get; set; }
        public bool UnlockUser { get; set; }
        public bool UnlockGuest { get; set; }
        public bool RestrictGuest { get; set; }
        public bool ResetDb { get; set; }
        public bool BackupDb { get; set; }
        public bool RestoreDb { get; set; }
        public bool BatchScan { get; set; }
        public bool ProgramSetup { get; set; }
        public bool LoginMgmt { get; set; }
        public bool DbMgmt { get; set; }
        // stub
    }
}
