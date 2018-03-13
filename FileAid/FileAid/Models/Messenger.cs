using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileAid.Models {
    public static class Messenger {
        public static void Show(string message) {
            MessageBox.Show(message);
        }

        public static void Show(string message, string caption) {
            MessageBox.Show(message, caption);
        }

        public static DialogResult ShowYesNo(string message, string caption) {
            return MessageBox.Show(message, caption, MessageBoxButtons.YesNo);
        }

        public static DialogResult ShowOkCancel(string message, string caption) {
            return MessageBox.Show(message, caption, MessageBoxButtons.OKCancel);
        }
    }
}
