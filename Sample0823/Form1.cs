using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sample0823 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Exec_Click(object sender, EventArgs e) {
            int n = int.Parse(Value.Text);
            int m = int.Parse(Jyou.Text);
            Result.Text = Math.Pow(n,m).ToString();
            //var jou = n;
            //for (int i = 1; i < m ; i++) {
            //    jou = n * jou;
            //}
            //Result.Text = jou.ToString();
        }
    }
}
