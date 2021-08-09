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

namespace S1._1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btOpen_Click(object sender, EventArgs e) {
            if (ofd.ShowDialog() == DialogResult.OK) {
                var line = File.ReadLines(ofd.FileName,Encoding.GetEncoding("shift_jis"));
                foreach (var item in line) {
                    tbFile.Text += item + "\r\n";
                }
            }
        }
    }
}
