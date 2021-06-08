using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice {
    class Program {
        static void Main(string[] args) {
            var numbers = new List<int> { 12, 87, 94, 14, 53, 20, 40, 35, 76, 91, 31, 17, 48 };
            var names = new List<string> { "Tokyo", "New Delhi", "Bangkok", "London", "Paris", "Berlin", "Canberra", "Hong Kong", };

            // 3.1.1
            Exercise1_1(numbers);
            Console.WriteLine("-----");

            // 3.1.2
            Exercise1_2(numbers);
            Console.WriteLine("-----");

            // 3.1.3
            Exercise1_3(numbers);
            Console.WriteLine("-----");

            // 3.1.4
            Exercise1_4(numbers);
            Console.WriteLine("-----");
            // 3.2.1
            Exercise2_1(names);
            Console.WriteLine("-----");

            // 3.2.2
            Exercise2_2(names);
            Console.WriteLine("-----");

            // 3.2.3
            Exercise2_3(names);
            Console.WriteLine("-----");

            // 3.2.4
            Exercise2_4(names);
            Console.WriteLine("-----");


            //3.3.1
            Exercise3_1(names);
            Console.WriteLine("-----");
        }

        //done
        private static void Exercise3_1(List<string> names) {
            int count = 0;

            //これを改善し一行で！！！！
            //names.ForEach(n => count += n.Count(c => char.IsLower(c)));

            foreach (var name in names) {
                count += name.Count(c => char.IsLower(c));
            }
            Console.WriteLine(count);
        }

        private static void Exercise2_4(List<string> names) {
            var bnames = names.Where(s => s.StartsWith("B")).Select(s => s.Length);
            foreach (var n in bnames) {
                Console.WriteLine(n);
            }
        }

        private static void Exercise2_3(List<string> names) {
            var extraction = names.Where(s => s.Contains('o')).ToArray();
            foreach (var oname in extraction) {
                Console.WriteLine(oname);
            }
            
        }

        private static void Exercise2_2(List<string> names) {
            var count = names.Count(s => s.Contains('o'));
            Console.WriteLine(count);
        }

        private static void Exercise2_1(List<string> names) {
            Console.Write("都市名:");
            var line = Console.ReadLine();
            var search = names.FindIndex(s => s == line);
                Console.WriteLine(search);
        }

        private static void Exercise1_4(List<int> numbers) {
            var list = numbers.Select(s => s * 2).ToList();
            foreach (var dos in list) {
                Console.WriteLine(dos);
            }
        }

        private static void Exercise1_3(List<int> numbers) {
            foreach (var num in numbers.Where(s => 50 <= s)){
                Console.WriteLine(num);
            }
        }

        private static void Exercise1_2(List<int> numbers) {
            numbers.ForEach(n => Console.WriteLine( n/2.0));
            

        }

        private static void Exercise1_1(List<int> numbers) {
            var exists = numbers.Exists(s => s % 8 == 0 || s % 9 == 0);
            if (exists)
                Console.WriteLine("存在しています");
            else
                Console.WriteLine("存在しない");

        }
    }
}
