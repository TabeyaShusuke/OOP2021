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

namespace Exercise4 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btCopy_Click(object sender, EventArgs e) {

            var files = Directory.EnumerateFiles(tbCopySouce.Text, "*.*");
            if (!Directory.Exists(tbCopy.Text))
                Directory.CreateDirectory(tbCopy.Text);
            foreach (var file in files) {
                var name = Path.GetFileNameWithoutExtension(file) + "_bak";
                var ext = Path.GetExtension(file);
                var dest = Path.Combine(tbCopy.Text, name + ext);
                File.Copy(file, dest, overwrite: true);
            }

            MessageBox.Show(tbCopy.Text+"に"+tbCopySouce.Text+"をコピーしました。");
        }
    }
}
