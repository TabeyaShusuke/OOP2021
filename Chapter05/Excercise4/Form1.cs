using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Excercise4 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            Title.Text = "Novelist=谷崎潤一郎;BestWork=春琴抄;Born=1886";
        }

        private void Button5_4_Click(object sender, EventArgs e) {
            //var separate = Title.Text.Split(';').ToArray();
            //foreach (var item in separate) {
            //    var a = item.Split('=');
            //    Text5_4.Text = a[0]+":"+a[1];
               
            //}
            
        }
    }
}
