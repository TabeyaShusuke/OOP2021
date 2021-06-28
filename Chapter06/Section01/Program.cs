using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {
        static void Main(string[] args) {
            var books = Books.GetBooks();

            Console.WriteLine("本の平均価格は" + books.Average(x => x.Price).ToString("#,0")+"円");
            Console.WriteLine("------------------");
            Console.WriteLine("総ページ数:P" + books.Sum(x => x.Pages).ToString("#,0"));
            Console.WriteLine("------------------");
            Console.WriteLine("最高価格:" + books.Max(x => x.Price).ToString("#,0") + "円");
            Console.WriteLine("------------------");
            Console.WriteLine("最低価格:" + books.Min(x => x.Price).ToString("#,0") + "円");
            Console.WriteLine("------------------");
            Console.WriteLine("冊数:" + books.Count()+"冊");
            Console.WriteLine("------------------");
            Console.WriteLine("500円以上の本:" + books.Count(x => 500 <= x.Price)+"冊");
            Console.WriteLine("------------------");


            Console.WriteLine(books.Count(z => z.Title.Contains("物語")));
            Console.WriteLine("------------------");
            var result = books.Where(s => s.Title.Contains("物語")).Take(2);
            foreach (var item in result) {
                Console.WriteLine(item.Title);
                Console.WriteLine("------------------");
            }

            var r = books.OrderByDescending(a => a.Price).Take(3);
            foreach (var item in r) {
                Console.WriteLine(item.Price+"円 "+item.Title);
            }
            Console.WriteLine("------------------");

            var title = books.Select(s => s.Title);
            foreach (var item in title) {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------------");



        }
    }
}
