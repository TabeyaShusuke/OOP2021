using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Section04 {
    class Program {

        Dictionary<string, int> AreaDic = new Dictionary<string, int>() {
            {"前橋",4210 },
            {"みなかみ",4220 },
            {"宇都宮",4110 },
            {"水戸",4010 },
        };

        static void Main(string[] args) {
            new Program();
            
        }

        //コンストラクタ
        public Program() {
            Console.WriteLine("yahoo!週間天気予報");
            Console.WriteLine();
            Console.WriteLine("地域コード入力");
            int num = 1;
            foreach (KeyValuePair<string, int>  pair in AreaDic) {
                
                Console.WriteLine("{0}:{1}", num++ , pair.Key);
                
            }
            
            //Console.WriteLine("1:前橋");
            //Console.WriteLine("2:みなかみ");
            //Console.WriteLine("3:宇都宮");
            //Console.WriteLine("4:水戸");
            Console.WriteLine("9:その他　（直接入力）");
            Console.WriteLine();
            Console.Write(">");
            var code = int.Parse(Console.ReadLine());
           
            
            switch (code) {
                            
                case 1:
                    code = 4210;
                    break;
                case 2:
                    code = 4220;
                    break;
                case 3:
                    code = 4110;
                    break;
                case 4:
                    code = 4010;
                    break;
                case 9:
                    Console.Write("コード入力:");
                    code = int.Parse(Console.ReadLine());
                    break;
                default:
                    Console.WriteLine("正しく入力して下さい");

                    new Program();
                    break;
            

        }
            var results = GetWeatherReportFromYahoo(code);
            foreach (var s in results) {
                Console.WriteLine(s);
            }
            Console.WriteLine();    
        }

        //14.15
        public void DownloadString() {
            var wc = new WebClient();
            wc.Encoding = Encoding.UTF8;
            var html = wc.DownloadString("https://yahoo.co.jp/");
            Console.WriteLine(html);
        }

        //14.17 (非同期処理)一括
        private void DownloadFileAsync() {
            var wc = new WebClient();
            var url = new Uri(@"C:\DB&MOSなど.zip");
            var filename = @"C:\temp\example.zip";
            wc.DownloadProgressChanged += wc_DownloadProgressChanged;
            wc.DownloadFileCompleted += wc_DownloadFileCompleted;
            wc.DownloadFileAsync(url, filename);//非同期でダウンロード
            Console.ReadLine();//アプリケーションが終了しないようにする
        }

        static void wc_DownloadProgressChanged(object sender,
                            DownloadProgressChangedEventArgs e) {
            Console.WriteLine("{0}% {1}/{2}", e.ProgressPercentage,
                              e.BytesReceived, e.TotalBytesToReceive);
        }

        static void wc_DownloadFileCompleted(object sender,
                            System.ComponentModel.AsyncCompletedEventArgs e) {
            Console.WriteLine("ダウンロード完了");
        }

        //14.18 ストリームとしてダウンロード nagara
        public void OpenReadSample() {
            var wc = new WebClient();
            using (var strem = wc.OpenRead(@"https://yahoo.co.jp/"))
            using (var sr = new StreamReader(strem,Encoding.UTF8)) {
                string html = sr.ReadToEnd();
                Console.WriteLine(html);
            }
        }

        //14.19
        private static IEnumerable<string> GetWeatherReportFromYahoo(int cityCode) {
            using (var wc = new WebClient()) {
                wc.Headers.Add("Content-type", "charset=UTF-8");
                var uriString = string.Format(
                    @"http://rss.weather.yahoo.co.jp/rss/days/{0}.xml", cityCode);
                var url = new Uri(uriString);
                var stream = wc.OpenRead(url);

                XDocument xdoc = XDocument.Load(stream);
                var nodes = xdoc.Root.Descendants("title");
                foreach (var node in nodes) {
                    string s = Regex.Replace(node.Value, "【|】 | - Yahoo!天気・災害", "");
                    yield return s;
                }
            }
        }
    }
}
