﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileAid.Models {
    public class User {
        public int UserID { get; set; }
        public string Username { get; set; }
        //public string Password { get; set; } // Is this needed in the User object?
        public int RoleID { get; set; }
        public int LoginFailures { get; set; }
        public DateTime LockedOutOn { get; set; }
        public DateTime DisabledOn { get; set; }
        public bool NeedsPasswordReset { get; set; }
        // stub
    }
}
