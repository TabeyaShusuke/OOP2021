using System;
using System.Collections.Generic;
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

namespace NumberGame {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {
        int collect = 0;
        
        public MainWindow() {
            InitializeComponent();
        }

        private void bt_click(object sender, RoutedEventArgs e) {
            var count = int.Parse(((Button)sender).Content.ToString());
            if (count == collect) {
                this.comment.Text = "それ正解!!!!!!!!!!!!!!!";
            } else if (count < collect) {
                //大きい
                this.comment.Text = "もっと大きい数です↑↑↑";
            } else if (count > collect) {
                //小さい
                this.comment.Text = "もっと小さい数です↓↓↓";
            }
            
            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {
            Random r = new Random();
            collect = r.Next(1, 25);
        }
    }
}
