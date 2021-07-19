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

namespace E2 {
    public partial class Form1 : Form {
        string input = "";//変換元ファイル
        string output = "";//変換先ファイル
        public Form1() {
            InitializeComponent();
        }

        private void tbOpen_Click(object sender, EventArgs e) {
            if (ofd.ShowDialog() == DialogResult.OK) {
                input = ofd.FileName;
            }
        }

        private void btchage_Click(object sender, EventArgs e) {
            if (sfd.ShowDialog() == DialogResult.OK) {
                output = sfd.FileName;
            }
        }

        private void btnum_Click(object sender, EventArgs e) {
            var line = File.ReadLines(input, Encoding.UTF8)
                                .Select((s, ix) => string.Format("{0,4}:{1}", ix + 1, s)).ToArray();
            File.WriteAllLines(output,line);
        }
    }
}
