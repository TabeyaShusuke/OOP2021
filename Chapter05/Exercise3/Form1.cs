using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise3 {
    public partial class Form1 : Form {
        //コンストラクタ first
        public Form1() {
            InitializeComponent();
        }


        //formがロードされるタイミングで一回だけ実行される
        private void Form1_Load(object sender, EventArgs e) {
            inputStrText.Text = "Jackdaws love my big sphinx of quartz";
        }

        //空白カウント
        private void Button5_3_1_Click(object sender, EventArgs e) {
            var count = inputStrText.Text.Count(n => n.ToString() ==  " ");
            Text1.Text += count;
        }

        private void Button5_3_2_Click(object sender, EventArgs e) {
            var change = inputStrText.Text.Replace("big", "small");
            Text2.Text += change;
        }

        private void Button3_Click(object sender, EventArgs e) {
            var word = inputStrText.Text.Split(' ').Count();
            Text3.Text += word;
        }

        private void Button4_Click(object sender, EventArgs e) {
            var array = inputStrText.Text.Split(' ').ToArray();
            if (array.Length > 0) {
                var sb = new StringBuilder(array[0]);
                foreach (var word in array.Skip(1)) {
                    sb.Append(' ');
                    sb.Append(word);
                }
                var text = sb.ToString();
                Text4.Text += text;
            }
        }

        private void Button5_Click(object sender, EventArgs e) {
            var counting = inputStrText.Text.Split(' ').Where(n => n.Length <= 4);
            foreach (var count in counting) {
                Text5.Text += count+ " " ;
            }
            
        }
    }
}
