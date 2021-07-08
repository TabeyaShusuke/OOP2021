using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise2 {
    public partial class Form1 : Form {

        //stopwatch 
        Stopwatch sw = new Stopwatch();
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            lb1.Text = sw.Elapsed.ToString(@"hh\:mm\:ss\.ff");
        }

        private void start_Click(object sender, EventArgs e) {
            sw.Start();//stopwatch
            tmLevolution.Start();//画面更新用のタイマースタート
        }

        private void stop_Click(object sender, EventArgs e) {
            sw.Stop();
            tmLevolution.Stop();
        }

        private void btReset_Click(object sender, EventArgs e) {
            sw.Reset();
            lbox.Items.Clear();
        }

        private void tmLevolution_Tick(object sender, EventArgs e) {
            lb1.Text = sw.Elapsed.ToString(@"hh\:mm\:ss\.ff");
            tmLevolution.Tick += Tm_Tick;
            tmLevolution.Start();
        }

        private void Tm_Tick(object sender, EventArgs e) {
            lb1.Text = sw.Elapsed.ToString(@"hh\:mm\:ss\.ff");
        }

        private void btRap_Click(object sender, EventArgs e) {
            lbox.Items.Insert(0,lb1.Text);
        }

        
    }
}
