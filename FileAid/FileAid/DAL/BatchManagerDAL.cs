﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileAid.Models;
using System.Data;

namespace FileAid.DAL {
    public static class BatchManagerDAL {
        public static DataSet GetActiveFiles() {
            // stub
            return Db.ExecuteDataset("stub");
        }

        public static void AddFile(TrackedFile newFile) {
            // stub
        }

        public static void UpdateFile() {
            // stub
        }

        public static void LogSummary(string batchSummary) {
            // stub
        }
    }
}