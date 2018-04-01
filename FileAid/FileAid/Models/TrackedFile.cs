using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileAid.Models {
    public class TrackedFile {
        public int FileID { get; set; }
        public string Filename { get; set; }
        public string FileExtension { get; set; }
        public string FilePath { get; set; }
        public int FileSize { get; set; }
        public DateTime ModifiedOn { get; set; }
        public DateTime CreatedOn { get; set; }
        public string FileMemo { get; set; } = null;
        public DateTime TrackingDisabledOn { get; set; }
        public int ReminderID { get; set; } = -999;

        public void GetInfo() {
            TrackedFile currentInfo = DAL.FileManagerDAL.GetFile(this.FileID);
            if (currentInfo != null) {
                Filename = currentInfo.Filename;
                FileExtension = currentInfo.FileExtension;
                FilePath = currentInfo.FilePath;
                FileSize = currentInfo.FileSize;
                ModifiedOn = currentInfo.ModifiedOn;
                CreatedOn = currentInfo.CreatedOn;
                TrackingDisabledOn = currentInfo.TrackingDisabledOn;
                ReminderID = currentInfo.ReminderID;
            }
        }

        public bool UpdateInfo() {
            bool wasUpdated = DAL.TrackedFileDAL.UpdateInfo(this);
            if (wasUpdated) {
                GetInfo();
            }
            return wasUpdated;
        }

        public List<FileLink> GetLinks() {
            List<FileLink> myLinks = DAL.TrackedFileDAL.GetLinks(this.FileID);
            return myLinks;
        }

        public Reminder GetReminder() {
            Reminder myReminder = DAL.TrackedFileDAL.GetReminder(this.FileID);
            return myReminder;
        }

        public bool UpdateMemo(string memo) {
            bool wasUpdated = DAL.TrackedFileDAL.UpdateMemo(this.FileID, memo);
            if (wasUpdated) FileMemo = memo;
            return wasUpdated;
        }

        public bool RemoveMemo() {
            bool wasRemoved = DAL.TrackedFileDAL.RemoveMemo(this.FileID);
            if (wasRemoved) FileMemo = "";
            return wasRemoved;
        }

        public List<Event> GetHistory() {
            List<Event> myHistory = DAL.TrackedFileDAL.GetHistory(this.FileID);
            return myHistory;
        }

        public bool StartTracking()
        {
            bool wasStarted = DAL.TrackedFileDAL.StartTracking(this.FileID);
            if (wasStarted) TrackingDisabledOn = new DateTime(); // 01-01-0001
            return wasStarted;
        }

        public bool StopTracking() {
            bool wasStopped = DAL.TrackedFileDAL.StopTracking(this.FileID);
            if (wasStopped) TrackingDisabledOn = DateTime.Now;
            return wasStopped;
        }
    }
}
