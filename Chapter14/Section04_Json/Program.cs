using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Xml.Linq;

namespace Section04_Json {
    class Program {
        static void Main(string[] args) {
            var keyword = "算用記";
            var content = GetFromWikipedia(keyword);
            Console.WriteLine(content ?? "見つかりませんでした");

        }

        private static object GetFromWikipedia(string keyword) {
            var wc = new WebClient();
            wc.QueryString = new NameValueCollection() {
                ["action"] = "query",
                ["prop"] = "revisions",
                ["rvprop"] = "content",
                ["format"] = "xml",
                ["titles"] = HttpUtility.UrlEncode(keyword, Encoding.UTF8),
            };
            wc.Headers.Add("Content-type", "charset=UTF-8");
            var result = wc.DownloadString("http://ja.wikipedia.org/w/api.php");
            var xmldoc = XDocument.Parse(result);
            var rev = xmldoc.Root.Descendants("rev").FirstOrDefault();
            return WebUtility.HtmlDecode(rev?.Value);
        }
    }



}
