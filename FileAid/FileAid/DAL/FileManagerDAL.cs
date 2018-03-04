using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileAid.Models;

namespace FileAid.DAL {
    public static class FileManagerDAL {
        public static List<TrackedFile> GetFiles() {
            // stub
            return Db.ReadQuery<TrackedFile>("stub");
        }

        public static void AddFiles(TrackedFile newFile) {
            // stub
        }
    }
}
