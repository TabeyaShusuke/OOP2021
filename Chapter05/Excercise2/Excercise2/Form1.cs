using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Excercise2 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Button5_2_Click(object sender, EventArgs e) {
            if (int.TryParse(inStrNum.Text,out int inst)) {
                outStrNum.Text = inst.ToString("#,#");
            } else {
                outStrNum.Text = "数字ではありません。";
            } 
            

        }
    }
}
