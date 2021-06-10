using Excercise1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise2 {
    class Program {
        static void Main(string[] args) {
           var ym1 = new YearMonth(1999,3);
           var ym2 = new YearMonth(1999,4);
           var ym3 = new YearMonth(1999,5);
           var ym4 = new YearMonth(1999,6);
           var ym5 = new YearMonth(1999,12);
            var yms = new YearMonth[] {ym1,ym2,ym3,ym4,ym5,};

            for (int i = 0; i < yms.Length; i++) {
                Console.WriteLine(yms[i]);
            }



        }
    }
}
