using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FileAid.Models;

namespace FileAid.GUI {
    public partial class FormFileAidRptBatches : Form {
        public FormFileAidRptBatches() {
            InitializeComponent();
        }

        private void FormFileAidRptBatches_Load(object sender, EventArgs e) {
            List<Event> allEvents = EventManager.GetEvents();
            if (allEvents == null) return;


            List<EventTypes> batchEvents = new List<EventTypes>();
            batchEvents.Add(EventTypes.BatchAutoStarted);
            batchEvents.Add(EventTypes.BatchCompleted);
            batchEvents.Add(EventTypes.BatchManualStarted);

            var filteredEvents = from ev in allEvents
                                 where batchEvents.Contains(ev.EventTypeID)
                                 select ev;

            if (filteredEvents == null) return;
            BindingList<BatchReportItem> myEvents = new BindingList<BatchReportItem>();
            foreach (Event ev in filteredEvents) {
                BatchReportItem item = new BatchReportItem();
                item.Date = ev.OccurredOn.ToString();
                item.BatchDescription = ev.Description;
                myEvents.Add(item);
            }
            BatchReportItemBindingSource.DataSource = myEvents;
            this.reportViewer1.RefreshReport();
        }
    }

    public class BatchReportItem {
        public string Date { get; set; }
        public string BatchDescription { get; set; }
    }
}
