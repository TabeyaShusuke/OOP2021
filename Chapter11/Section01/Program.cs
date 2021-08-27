using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Section01 {
    class Program {
        static void Main(string[] args) {

            var novelists = ReadNovelists();

            foreach (var xnovelist in novelists) {
                Console.WriteLine("{0} ({1} - {2}) - {3}",xnovelist.Name,
                                    xnovelist.Birth.Year,xnovelist.Death.Year,
                                    string.Join(",",xnovelist.Masterpieces));
            }

            
        }

        //カスタムクラスのオブジェクトとして要素を取り出す
        static public IEnumerable<Novelist> ReadNovelists() {
            var xdoc = XDocument.Load("novelists.xml");
            var novelists = xdoc.Root.Elements()
                          .Select(x => new Novelist{
                              Name = (string)x.Element("name"),
                              KanaName = (string)(x.Element("name").Attribute("kana")),
                              Birth = (DateTime)x.Element("birth"),
                              Death = (DateTime)x.Element("death"),
                              Masterpieces = x.Element("masterpieces")
                                              .Elements("title")
                                              .Select(title => title.Value)
                                              .ToArray()
                          });
            return novelists.ToArray();

        }

    }
}