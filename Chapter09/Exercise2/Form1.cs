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

namespace Exercise2 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void bt1_Click(object sender, EventArgs e) {
            if (ofdFile.ShowDialog() == DialogResult.OK) {
                var line = File.ReadLines(ofdFile.FileName, Encoding.UTF8)
                                .Select((s, ix) => string.Format("{0,4}:{1}", ix + 1, s)).ToArray();
                foreach (var item in line) {
                    tbNumber.Text += item + "\r\n";
                }
            }


        }
    }
}