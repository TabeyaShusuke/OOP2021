using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise5 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btOpen_Click(object sender, EventArgs e) {
            var di = new DirectoryInfo(tbDir.Text);
            FileInfo[] files = di.GetFiles();
            foreach (var item in files) {
                if (item.Length >= 1048576) {
                    tbDisplay.Text += item.Name + "\r\n";
                }
            }
        }
    }
}
