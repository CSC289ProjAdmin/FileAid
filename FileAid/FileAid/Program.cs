using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using FileAid.GUI;

namespace FileAid {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            //Application.Run(new FormFileAidLogin());
            //Application.Run(new FormFileAidDash());
            //Application.Run(new FormFileAidConfig());
            //Application.Run(new FormFileAidDbMgmt());
            //Application.Run(new FormFileAidEvents());
            //Application.Run(new FormFileAidMain());
            //Application.Run(new FormFileAidNewFile());

            // Testing real MDF connection
            FormFileAidLogin login = new FormFileAidLogin();
            List<Models.TrackedFile> files = DAL.FileManagerDAL.GetFiles();
            if (files != null) {
                MessageBox.Show($"File count: {files.Count}");
                foreach (var f in files) {
                    MessageBox.Show($"File name: {f.Filename}\nModified On: {f.ModifiedOn}");
                }
            }
            // Testing real MDF connection

            if (login.ShowDialog() == DialogResult.OK) {
                Application.Run(new FormFileAidDash());
            } else {
                Application.Exit();
            }
        }
    }
}
