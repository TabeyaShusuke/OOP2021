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
            Console.WriteLine("総ページ数:P" + books.Sum(x => x.Pages).ToString("#,0"));
            Console.WriteLine("最高価格:" + books.Max(x => x.Price).ToString("#,0") + "円");
            Console.WriteLine("最低価格:" + books.Min(x => x.Price).ToString("#,0") + "円");
            Console.WriteLine("冊数:" + books.Count()+"冊");
            Console.WriteLine("500円以上の本:" + books.Where(x => 500 <= x.Price).Count()+"冊");
        }
    }
}
