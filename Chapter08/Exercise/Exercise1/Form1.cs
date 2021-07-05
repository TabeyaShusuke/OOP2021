using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Exercise1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btToday_Click(object sender, EventArgs e) {
            var today = DateTime.Now;
            tbDateDisp.Text = string.Format("{0:yyyy/M/d HH:mm}",today) + "\r\n";
            tbDateDisp.Text += string.Format("{0:yyyy年MM月dd日 HH時mm分ss秒}", today) + "\r\n";
            var a = new CultureInfo("ja-JP");
            a.DateTimeFormat.Calendar = new JapaneseCalendar();
            tbDateDisp.Text += today.ToString("ggyy年　M月d日(dddd)", a);
            //tbDateDisp.Text = today.ToString("d");
            


        }

        private void Form1_Load(object sender, EventArgs e) {
            Timer tm = new Timer();
            tm.Tick += Tm_Tick;
            tm.Interval = 1000;
            tm.Start();
            tssTimeLabel.Text = DateTime.Now.ToString();
        }

        private void Tm_Tick(object sender, EventArgs e) {
            tssTimeLabel.Text += "a";
        }
    }
}
