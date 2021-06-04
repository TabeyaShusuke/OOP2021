using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {
        static void Main(string[] args) {
            //var names = new List<string> {
            //     "Tokyo", "New Delhi", "Bangkok", "London", "Paris", "Berlin", "Canberra", "Hong Kong",
            //};

            //IEnumerable<string> query = names.Where(s => s.Length <= 5).Select(s => s.ToLower());
            //foreach (string s in query) {
            //    Console.WriteLine(s);
            //}


            string[] names = {
                "Tokyo", "New Delhi", "Bangkok", "London", "Paris", "Berlin", "Canberra"  };
            var query = names.Where(s => s.Length <= 5).ToList();



            foreach (var item in query)
                Console.WriteLine(item);
            Console.WriteLine("------");

            names[0] = "Osaka";
            foreach (var item in query)
                Console.WriteLine(item);

        }
    }
}
