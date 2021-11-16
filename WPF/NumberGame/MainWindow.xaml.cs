using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace NumberGame {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {
        int collect = 0;
        Stopwatch sw = new Stopwatch();
        public MainWindow() {
            InitializeComponent();
        }

        private void bt_click(object sender, RoutedEventArgs e) {
           
            var count = int.Parse(((Button)sender).Content.ToString());
            sw.Start();
            this.timer.Text = sw.Elapsed.ToString(@"hh\:mm\:ss\.ff");


            var timer = new DispatcherTimer(DispatcherPriority.Normal) {
                // インターバルを設定
                Interval = TimeSpan.FromSeconds(1.0),
            };
            timer.Tick += Timer_Tick;
            timer.Start();

            if (count < collect) {
                //大きい
                this.comment.Text = "もっと大きい数です↑↑↑";
            } else if (count > collect) {
                //小さい
                this.comment.Text = "もっと小さい数です↓↓↓";
            } else {
                this.comment.Text = "それ正解!!!!!!!!!!!!!!!";
                timer.Stop();
            }

            
        }

        private void Timer_Tick(object sender, EventArgs e) {
            this.timer.Text = sw.Elapsed.ToString(@"hh\:mm\:ss\.ff");
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {
            Random r = new Random();
            collect = r.Next(1, 25);
        }

    }
}
