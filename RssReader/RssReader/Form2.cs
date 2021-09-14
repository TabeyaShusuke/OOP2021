using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RssReader {
    public partial class Form2 : Form {
        public Form2() {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e) {

        }

        internal void wbBrowser(string sender) {
            wbTitle.Url = new Uri(sender);

        }

        private void btBack_Click(object sender, EventArgs e) {
            if (wbTitle.CanGoBack == true) {
                wbTitle.GoBack();
            }
        }

        private void btForward_Click(object sender, EventArgs e) {
            if (wbTitle.CanGoForward == true) {
                wbTitle.GoForward();
            }
        }

        private void wbTitle_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e) {
            btReturn.Enabled = wbTitle.CanGoBack;
            btForward.Enabled = wbTitle.CanGoForward;
        }
    }
}
