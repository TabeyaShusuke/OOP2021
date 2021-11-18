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
        
        private Random random = new Random();
        private int answerNum;
        private const int Rows = 5;     //行
        private const int Columns = 6;  //列
        Stopwatch sw = new Stopwatch();

        private SolidColorBrush selectedButtonColor = new SolidColorBrush(Colors.Yellow);
        private SolidColorBrush hitButtonColor = new SolidColorBrush(Colors.Red);

        private void Window_Loaded(object sender, RoutedEventArgs e) {
            List<Button> buttons = new List<Button>();
            //正解を取得
            answerNum = random.Next(Rows * Columns) + 1;

            //行
            for (int i = 0; i < Rows; i++) {
                grid.RowDefinitions.Add(new RowDefinition());
            }
            //列
            for (int i = 0; i < Columns; i++) {
                grid.ColumnDefinitions.Add(new ColumnDefinition());
            }
            int count = 0;
            for (int i = 0; i < Rows; i++) {
                for (int j = 0; j < Columns; j++) {
                    var bt = new Button();
                    bt.Width = MainForm.Width / Columns;
                    bt.Height = MainForm.Height / Rows;
                    bt.Content = ++count;
                    bt.FontSize = 20;
                    bt.Click += Button_Click;
                    Grid.SetRow(bt, i);
                    Grid.SetColumn(bt, j);
                    buttons.Add(bt);
                }
            }
            buttons.ForEach(bt => grid.Children.Add(bt));
            MainForm.Height += textDisp.Height + 50;

        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            var count = int.Parse(((Button)sender).Content.ToString());
            sw.Start();
            this.timera.Text = sw.Elapsed.ToString(@"mm\:ss\.ff");
            var timer = new DispatcherTimer(DispatcherPriority.Normal) {
                // インターバルを設定
                Interval = TimeSpan.FromSeconds(0.1),
            };
            timer.Tick += Timer_Tick;
            timer.Start();
            if (count < answerNum) {
                //大きい
                textDisp.Text = "もっと大きい数です↑↑↑";
            } else if (count > answerNum) {
                //小さい
                textDisp.Text = "もっと小さい数です↓↓↓";
            } else {
                textDisp.Text = "それ正解!!!!!!!!!!!!!!!";
                sw.Stop();
            }
            }

        private void Timer_Tick(object sender, EventArgs e) {
            this.timera.Text = sw.Elapsed.ToString(@"mm\:ss\.ff");
        }
    }
}
