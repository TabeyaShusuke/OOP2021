using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WeatherApp {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            
        }

        private void btWeather_Click(object sender, EventArgs e) {
            int areacode = 0;
            switch (cbArea.Text) {
                case "前橋":
                    areacode = 4210;
                    break;
                case "みなかみ":
                    areacode = 4220;
                    break;
                case "宇都宮":
                    areacode = 4110;
                    break;
                case "水戸":
                    areacode = 4010;
                    break;
                
                default:
                    break;
            }

            var results = GetWeatherReportFromYahoo(areacode);
            foreach (var s in results) {
                tbResult.Text += s + "\r\n";

            }
        }

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
