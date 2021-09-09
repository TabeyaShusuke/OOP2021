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

namespace RssReader {
    public partial class Form1 : Form {
        List<string> rss = new List<string>();

        public Form1() {
            InitializeComponent();
        }

        private void btRead_Click(object sender, EventArgs e) {
            setRssTitle(tbUrl.Text);
        }

        //指定したURL先からXMLデータを取得し title要素 を取得し、リストボックスへセットする
        private void setRssTitle(string uri) {
            using (var wc = new WebClient()) {
                wc.Headers.Add("Content-type", "charset=UTF-8");
                var url = new Uri(uri);
                var stream = wc.OpenRead(url);
                XDocument xdoc = XDocument.Load(stream);
                var nodes = xdoc.Root.Descendants("item");
                foreach (var node in nodes) {
                    lbTitles.Items.Add(node.Element("title").Value);
                    rss.Add(node.Element("link").Value);
                }
            }
        }

        private void lbTitles_SelectedIndexChanged(object sender, EventArgs e) {
            var titlenum = lbTitles.SelectedIndex;
            wbBrowser.Url = new Uri(rss[titlenum]);
        }
    }
}
