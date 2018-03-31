using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileAid.Models {
    public static class BatchManager {
        public static void Scan() {
            List<string> officeFileExtensions = new List<string> { "*.doc", "*.xls", "*.ppt" };
            List<string> searchPaths = new List<string>();
            Dictionary<string, int> foundFiles = new Dictionary<string, int>();
            Dictionary<string, int> notFoundFiles = new Dictionary<string, int>();

            List<TrackedFile> allFiles = FileManager.GetFiles();
            if (allFiles != null) {
                // For each file in database
                foreach (var file in allFiles) {
                    // Add path to unique list to search for new files later
                    string path = file.FilePath.ToUpper();
                    if (!path.EndsWith(@"\")) {
                        path += @"\";
                    }
                    bool pathAlreadyAdded = searchPaths.Contains(path);
                    if (!pathAlreadyAdded) {
                        searchPaths.Add(path);
                    }

                    // Create string from filename & extension
                    string nameWithExt = file.Filename + '.' + file.FileExtension;

                    // Locate file
                    FileInfo fi = new FileInfo(path + nameWithExt);
                    bool wasFound = fi.Exists;

                    if (wasFound) {
                        // If being tracked, compare file info & update
                        bool isTracked = (file.TrackingDisabledOn == new DateTime());
                        if (isTracked) {
                            // Compare file info & update
                        }
                        // If not being tracked, don't update

                        // Add file to "Handled" dictionary (key = string, value = fileID)
                    } else { // Add to "Not Found" dictionary (key = string, value = fileID)
                    }
                }
            }

            // Add other desired search paths (e.g. common or specific folders)

            // For each unique path
            foreach (var path in searchPaths) {
                bool isValidDirectory = Directory.Exists(path);
                if (isValidDirectory) {
                    // Enumerate files in path with MS Office extensions
                    foreach (var ext in officeFileExtensions) {
                        try {
                            var filesInFolder = Directory.EnumerateFiles(path, ext);
                            // For each file in path
                            foreach (var file in filesInFolder) {
                                // If file in "Handled" dictionary, do nothing
                                bool alreadyHandled = (foundFiles.ContainsKey(file.ToUpper()));
                                if (!alreadyHandled) {
                                    // If file in "Not Found" dictionary
                                    bool wasMoved = (notFoundFiles.ContainsKey(file.ToUpper()));
                                    if (wasMoved) {
                                        // Update path, move to "Handled"
                                        // Update history if file is being tracked
                                    } else { // Add new file to database
                                    }
                                }
                            }
                        }
                        catch (DirectoryNotFoundException) {
                            // Swallow for now
                        }
                    }
                }
            }
            // For each file left in "Not Found" dictionary
            foreach (var pair in notFoundFiles) {
                // Stop tracking
            }
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
