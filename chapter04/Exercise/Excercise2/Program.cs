using Excercise1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise2 {
    class Program {
        static void Main(string[] args) {
            var yms = new YearMonth[] { new YearMonth(2980, 3), new YearMonth(2035, 4),
                new YearMonth(2000, 5), new YearMonth(2002, 12), new YearMonth(2020, 3), };

            

            Excercise2_2(yms);
            Console.WriteLine("--------");

            Excercise2_4(yms);
            Console.WriteLine("--------");

            Excercise2_5(yms);
            Console.WriteLine("--------");

        }

        

        private static void Excercise2_2(YearMonth[] yms) {
            foreach (var a in yms) {
                Console.WriteLine(a);
            }
        }

        private static void Excercise2_4(YearMonth[] yms) {
            var ry = Fc2(yms);
            var year = ry == null ? "21世紀ではありません":ry.ToString();
            Console.WriteLine(year);
        }

        static YearMonth Fc2(YearMonth[] yms) {
            foreach (var ym in yms) {
                if (ym.Is21Century) 
                    return ym;
                }
                return null;
        }
        
        private static void Excercise2_5(YearMonth[] yms) {
            var add = yms.Select(ym => ym.AddOneMonth()).OrderBy(ym => ym.Year).ToArray();
            foreach (var b in add) {
                Console.WriteLine(b);
            }
        }
    }
}