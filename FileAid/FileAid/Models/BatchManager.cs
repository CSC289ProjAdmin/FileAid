using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileAid.Models {
    public static class BatchManager {
        public static void Scan(string masterPath) {
            List<string> searchPaths = new List<string>();
            // Add any static search paths (e.g. common or specific folders)
            if (!string.IsNullOrEmpty(masterPath)) {
                if (!masterPath.EndsWith(@"\")) masterPath += @"\";
                searchPaths.Add(masterPath.ToUpper());
            }

            Dictionary<string, int> foundFiles = new Dictionary<string, int>();
            Dictionary<string, int> notFoundFiles = new Dictionary<string, int>();

            // First look for files already in system
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
                    string nameWithExt = (file.Filename + '.' + file.FileExtension).ToUpper();

                    // Locate file
                    FileInfo fi = new FileInfo(path + nameWithExt);
                    bool wasFound = fi.Exists;

                    if (wasFound) {
                        // If being tracked, compare file info & update
                        bool isTracked = (file.TrackingDisabledOn == new DateTime());
                        if (isTracked) {
                            // Compare file info
                            bool hasChanged = CompareFileInfo(file, fi);
                            if (hasChanged) {
                                // Update info
                                file.FileSize = (int)fi.Length;
                                file.ModifiedOn = fi.LastWriteTime;
                                file.CreatedOn = fi.CreationTime;
                                file.UpdateInfo();
                            }
                        }
                        // If not being tracked, don't update

                        // Add file to "Handled" dictionary (key = full path and filename, value = fileID)
                        foundFiles.Add(fi.FullName, file.FileID);
                    } else { // Add to "Not Found" dictionary (key = filename with extension, value = fileID)
                        notFoundFiles.Add(nameWithExt, file.FileID);
                    }
                }
            }

            // Second, for each unique path, look for new (or moved) MS Office files
            List<string> officeExtensionPatterns = new List<string> {
                // Note: *.3-character patterns cover all extensions starting with those characters
                "*.doc", "*.dot", "*.wbk", // Word
                "*.xls", "*.xlt", "*.xlm", "*.xla", "*.xll", "*.xlw", // Excel
                "*.ppt", "*.pot", "*.pps", "*.ppam", "*.sldx", "*.sldm" // PowerPoint
            };
            foreach (var path in searchPaths) {
                bool isValidDirectory = Directory.Exists(path);
                if (isValidDirectory) {
                    SearchOption so = (
                        (path == masterPath.ToUpper())
                        ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly
                    );
                    // Enumerate files in path with MS Office extensions
                    foreach (var ext in officeExtensionPatterns) {
                        try {
                            var filesInFolder = Directory.EnumerateFiles(path, ext, so);
                            // For each file in path
                            foreach (var file in filesInFolder) {
                                // Don't add lock / owner files (MS Office, LibreOffice)
                                if (file.Contains(@"~$") ||
                                    file.Contains(@"~lock")) {
                                    continue;
                                }
                                string full = file.ToUpper();
                                string nameWithExt = Path.GetFileName(full);
                                // If file in "Handled" dictionary, do nothing
                                bool alreadyHandled = (foundFiles.ContainsKey(full));
                                if (!alreadyHandled) {
                                    // If file in "Not Found" dictionary
                                    bool wasMoved = (notFoundFiles.ContainsKey(nameWithExt));
                                    if (wasMoved) {
                                        // Update path
                                        TrackedFile currentFile = FileManager.GetFile(notFoundFiles[nameWithExt]);
                                        currentFile.FilePath = path;
                                        currentFile.UpdateInfo();
                                        // Move to "Handled"
                                        foundFiles.Add(full, currentFile.FileID);
                                        notFoundFiles.Remove(nameWithExt);
                                        // Update history if file is being tracked
                                    } else { // Add new file to database
                                        FileInfo fi = new FileInfo(file);
                                        FileManager.AddFile(Path.GetFileNameWithoutExtension(fi.Name),
                                            fi.Extension.Substring(1), fi.DirectoryName,
                                            (int)fi.Length, fi.CreationTime, fi.LastWriteTime);
                                    }
                                }
                            }
                        }
                        catch (DirectoryNotFoundException) {
                            // Swallow for now
                        }
                        catch (UnauthorizedAccessException) {
                            // Swallow
                        }
                        catch (PathTooLongException) {
                            // Swallow
                        }
                    }
                }
            }

            // Finally, stop tracking any files that couldn't be found
            foreach (var pair in notFoundFiles) {
                // Stop tracking
                TrackedFile notFoundFile = FileManager.GetFile(pair.Value);
                if (notFoundFile != null) {
                    notFoundFile.StopTracking();
                }
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

        private static bool CompareFileInfo(TrackedFile tf, FileInfo fi) {
            bool hasSizeChanged = (tf.FileSize != (int)fi.Length);
            bool hasBeenModified = ((tf.ModifiedOn - fi.LastWriteTime).Duration() > TimeSpan.FromSeconds(1));
            bool hasBeenRecreated = ((tf.CreatedOn - fi.CreationTime).Duration() > TimeSpan.FromSeconds(1));
            bool hasChanged = (hasSizeChanged || hasBeenModified || hasBeenRecreated);
            return hasChanged;
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
