using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Excercise1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btAction_Click(object sender, EventArgs e) {
            //var today = DateTime.Today;
            var today = new DateTime((int)nudYear.Value, (int)nudMonth.Value, (int)nudDay.Value );
            DayOfWeek dayOfWeek = Dtp.Value.DayOfWeek;
            string dow = "";
            switch (dayOfWeek) {
                case DayOfWeek.Sunday:
                    dow = "日曜日です。";
                    break;
                case DayOfWeek.Monday:
                    dow = "月曜日です。";
                    break;
                case DayOfWeek.Tuesday:
                    dow = "火曜日です。";
                    break;
                case DayOfWeek.Wednesday:
                    dow = "水曜日です。";
                    break;
                case DayOfWeek.Thursday:
                    dow = "木曜日です。";
                    break;
                case DayOfWeek.Friday:
                    dow = "金曜日です。";
                    break;
                case DayOfWeek.Saturday:
                    dow = "土曜日です。";
                    break;
                default:
                    break;
            }
            tb.Text = "今日は"+dow;

            var isLeapYear = DateTime.IsLeapYear((int)nudYear.Value);
            if (isLeapYear)
                tbLeapYear.Text = "閏年です。";
            else
                tbLeapYear.Text = "閏年ではありません。";

            var date1 = today;
            var date2 = DateTime.Today;
            TimeSpan diff = date2 - date1;
            //tbOut.Text =diff.Days.ToString()+"日経過";
            var birthday = today;
            var targetday = date2;
            //tbOut.Text = Getage(birthday,targetday).ToString();
            var  s = date2.Year - Dtp.Value.Year;
            tbOut.Text = s.ToString();

        }
        
        
        public static int Getage(DateTime birthday,DateTime targetday) {
            var age = targetday.Year - birthday.Year;
            if (targetday < birthday.AddYears(age)) {
                age--;
            } 
            return age;
        }

        
    }
}
