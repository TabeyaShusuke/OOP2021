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

namespace Exercise3 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void bt_Click(object sender, EventArgs e) {
                var path = tb.Text;
                var path1 = tb2.Text;
                using (var writer = new StreamWriter(path, append:true)) {
                var reader = File.ReadLines(path1, Encoding.UTF8);
                    foreach (var item in reader) {
                        writer.Write(item);
                    }
                }
        }
    }
}
