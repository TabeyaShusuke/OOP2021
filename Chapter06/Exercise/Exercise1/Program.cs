using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1 {
    class Program {
        static void Main(string[] args) {
            var numbers = new int[] { 5, 10, 17, 9, 3, 21, 10, 40, 21, 3, 5, };

            //1
            Console.WriteLine(numbers.Max());
            Console.WriteLine("--------------");
            //2
            var a = numbers.Reverse().Take(2);
            foreach (var item in a) {
                Console.WriteLine("{0}",item);
            }
            Console.WriteLine("--------------");

            //3
            var num = numbers.Select(n => n.ToString());
            foreach (var item in num) {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("--------------");

            //4
            var order = numbers.OrderBy(x => x).Take(3);
            foreach (var item in order) {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------");

            //5
            var dis = numbers.Distinct();
            Console.WriteLine(dis.Count(x => 10 < x));
            

        }

        
    }
}
