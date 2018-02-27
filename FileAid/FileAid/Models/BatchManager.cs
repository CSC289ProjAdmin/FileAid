using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileAid.Models {
    public class BatchManager {
        public static void Scan() {
            // stub
        }

        private static List<string> GetActiveFiles() {
            // stub
        }

        private static List<string> BuildLocationList(List<string> filenames) {
            // stub
        }

        private static void ScanForKnown() {
            // stub
        }

        private static bool CompareFileInfo(TrackedFile tf) {
            // stub
        }

        private static void QueueUpdatedInfo(FileInfo fi) {
            // stub
        }

        private static void ScanForNew() {
            // stub
        }

        private static void QueueNewFile(TrackedFile newFile) {
            // stub
        }

        public static BatchSummary Update() {
            // stub
        }

        public static void LogSummary(BatchSummary summary) {
            // stub
        }
    }
}
