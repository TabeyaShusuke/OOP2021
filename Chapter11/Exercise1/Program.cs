using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exercise1 {
    class Program {
        static void Main(string[] args) {
            var file = "Sample.xml";
            Exercise1_1(file);
            Console.WriteLine("---------------------------------");

            Exercise1_2(file);
            Console.WriteLine("---------------------------------");

            Exercise1_3(file);
            Console.WriteLine("---------------------------------");

            var newfile = "sports.xml";
            Exercise1_4(file,newfile);
            Console.WriteLine("---------------------------------");
            var text = File.ReadAllText(newfile);
            Console.WriteLine(text);




        }

        private static void Exercise1_4(string file, string newfile) {
            var element = new XElement("ballsports",
                                new XElement("name","サッカー",new XAttribute("kanji","蹴球")),
                                new XElement("teammembers","11"),
                                new XElement("firstplayed", "1863")
                              );
            var xdoc = XDocument.Load(file);
            xdoc.Root.Add(element);
            xdoc.Save(newfile);
            foreach (var item in xdoc.Root.Elements()) {
                var xname = item.Element("name");
                var member = item.Element("teammembers");
                var xyear = item.Element("firstplayed");
                Console.WriteLine("競技名:{0} 人数:{1} 年:{2}",xname.Value,member.Value,xyear.Value);
            }
        }

        private static void Exercise1_1(string file) {
            var xdoc = XDocument.Load(file);
            var xelements = xdoc.Root.Elements();
            foreach (var item in xelements) {
                var xname = item.Element("name");
                var xmembers = item.Element("teammembers");
                Console.WriteLine("競技名:{0} 人数:{1}", xname.Value, xmembers.Value);
            }
        }

        private static void Exercise1_2(string file) {
            var xdoc = XDocument.Load(file);
            var sportsname = xdoc.Root.Elements()
                                       .OrderBy(x => (string)x.Element("firstplayed"));
            foreach (var item in sportsname) {
                var sportname = item.Element("name").Attribute("kanji");
                Console.WriteLine("競技名:{0}", sportname.Value);
            }
        }

        private static void Exercise1_3(string file) {
            var xdoc  = XDocument.Load(file);
            var num = xdoc.Root.Elements()
                               .Select(x => new {
                                   Name = x.Element("name").Value,
                                   Teammembers = x.Element("teammembers").Value
                               })
                               .OrderByDescending(x => int.Parse(x.Teammembers))
                               .First();
            Console.WriteLine("競技名:{0}", num.Name);
        }
    }
}
