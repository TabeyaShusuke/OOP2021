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
            //var title = Title.Text;
            //var value = "Novelist=";
            //var startind = title.IndexOf("Novelist=") + value.Length;
            //var endind = title.IndexOf(";", startind);
            //Text5_4.Text = "作家  :" + title.Substring(startind, endind - startind);


            //var value2 = "BestWork=";
            //var startind2 = title.IndexOf("BestWork=") + value2.Length;
            //var endind2 = title.IndexOf(";", startind2);
            //Text5_41.Text = "代表作:" + title.Substring(startind2, endind2 - startind2);


            //var value3 = "Born=";
            //var startind3 = title.IndexOf("Born=") + value3.Length;
            //var endind3 = title.IndexOf(" ", startind3);
            //Text5_42.Text = "誕生年:"+title.Substring(startind3);

            //解答
            //Novelist=谷崎潤一郎
            //BestWork=春琴抄
            //Born=1886
            foreach (var pair in Title.Text.Split(';')) {
                var sepa = pair.Split('=');
                Text5_4.Text += ToJapanese(sepa[0])+":"+sepa[1]+Environment.NewLine;
            }


        }

        private string ToJapanese(string key) {
            switch (key) {
                case "Novelist":
                    return "作家　";
                case "BestWork":
                    return "代表作";
                case "Born":
                    return "誕生年";
            }
            throw new ArgumentException("引数が正しくありません。");
        }

    }
}
