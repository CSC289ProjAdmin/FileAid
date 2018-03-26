﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileAid.Models {
    public static class BatchManager {
        public static void Scan() {
            // stub
        }

        private static List<string> GetActiveFiles() {
            // stub
            List<string> dummy = new List<string>();
            return dummy;
        }

        private static List<string> BuildLocationList(List<string> filenames) {
            // stub
            List<string> dummy = new List<string>();
            return dummy;
        }

        private static void ScanForKnown() {
            // stub
        }

        private static bool CompareFileInfo(TrackedFile tf) {
            // stub
            return false;
        }

        private static void QueueUpdatedInfo(string fileInfo) {
            // stub
        }

        private static void ScanForNew() {
            // stub
        }

        private static void QueueNewFile(TrackedFile newFile) {
            // stub
        }

        public static string Update() {
            // stub
            return "dummy";
        }

        public static void LogSummary(string batchSummary) {
            // stub
        }

        public static List<Batch> GetBatches() {
            List<Batch> allBatches = DAL.BatchManagerDAL.GetBatches();
            return allBatches;
        }

        public static Batch GetBatch(int batchID) {
            Batch specific = DAL.BatchManagerDAL.GetBatch(batchID);
            return specific;
        }

        public static Batch AddBatch(int nAdded, int nModified, int nDisabled,
            DateTime started, DateTime ended, bool isPeriodic) {
            int newID = DAL.BatchManagerDAL.AddBatch(nAdded, nModified, nDisabled,
                started, ended, isPeriodic);
            Batch newBatch = GetBatch(newID);
            return newBatch;
        }
    }
}
