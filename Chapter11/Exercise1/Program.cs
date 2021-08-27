using System;
using System.Collections.Generic;
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
