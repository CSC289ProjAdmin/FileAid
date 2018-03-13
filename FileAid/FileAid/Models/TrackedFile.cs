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

        public List<FileLink> GetLinks() {
            List<FileLink> myLinks = DAL.TrackedFileDAL.GetLinks(this.FileID);
            return myLinks;
        }

        public Reminder GetReminder() {
            Reminder myReminder = DAL.TrackedFileDAL.GetReminder(this.FileID);
            return myReminder;
        }

        public void UpdateMemo(string memo) {
            DAL.TrackedFileDAL.UpdateMemo(this.FileID, memo);
            FileMemo = memo;
        }

        public void RemoveMemo() {
            DAL.TrackedFileDAL.RemoveMemo(this.FileID);
            FileMemo = "";
        }

        public List<Event> GetHistory() {
            List<Event> myHistory = DAL.TrackedFileDAL.GetHistory(this.FileID);
            return myHistory;
        }

        public void StopTracking() {
            DAL.TrackedFileDAL.StopTracking(this.FileID);
            TrackingDisabledOn = DateTime.Now;
        }

        public void StartTracking() {
            DAL.TrackedFileDAL.StartTracking(this.FileID);
            TrackingDisabledOn = new DateTime(); // 01-01-0001
        }
    }
}
