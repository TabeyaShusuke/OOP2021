using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1 {
    class Program {
        static void Main(string[] args) {
            var text = "Cozy lummox gives smart squid who asks for job pen";
            Exercise1_1(text);
            Console.WriteLine();
            Exercise1_2(text);
        }

        private static void Exercise1_1(string text) {
            var dict = new Dictionary<Char,int>();
            foreach (var t in text) {
                var s = char.ToUpper(t);//大文字小文字区別しないすべて大文字に変換して処理
                if ('A' <= s && s <='Z') {
                    if (dict.ContainsKey(s))
                        dict[s]++;
                    else
                        dict[s] = 1;
                }
            }
            
            foreach (var item in dict.OrderBy(x => x.Key)) {
                Console.WriteLine("{0}:{1}", item.Key, item.Value);
            }
        }

        private static void Exercise1_2(string text) {
            var dict = new SortedDictionary<Char, int>();
            foreach (var t in text) {
                var up = char.ToUpper(t);
                if ('A' <= up && up <= 'Z') {
                    if (dict.ContainsKey(up))
                        dict[up]++;
                    else
                        dict[up] = 1;
                }
            }

            foreach (var item in dict) {
                Console.WriteLine("{0},{1}",item.Key,item.Value);
            }
        }
    }
}
