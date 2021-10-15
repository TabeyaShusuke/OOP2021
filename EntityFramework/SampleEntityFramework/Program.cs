using SampleEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleEntityFramework {
    class Program {
        static void Main(string[] args) {
            using (var db = new BooksDbContext()) {
                db.Database.Log = sql => { Debug.Write(sql); };
                var count = db.Books.Count();
                Console.WriteLine(count);

                
            }


            using (var db = new BooksDbContext()) {
                //書籍2冊以上の著者取得
                var authors = db.Authors.Where(a => a.Books.Count() >= 2);
                foreach (var author in authors) {
                    Console.WriteLine($"{author.Name}{author.Gender}{author.Birthday}");
                }

                //出版年、著者順（昇順）に並べ替え取得
                var books = db.Books.OrderBy(b => b.PublishedYear)
                                    .ThenBy(b => b.Author.Name);
                foreach (var book in books) {
                    Console.WriteLine($"{book.Title}{book.PublishedYear}{book.Author.Name}");
                }

                //発行年毎の書籍数を求める
                var groups = db.Books.GroupBy(b => b.PublishedYear)
                                     .Select(g => new {
                                         Year = g.Key,
                                         Count = g.Count()
                                     });
                foreach (var g in groups) {
                    Console.WriteLine($"{g.Year}{g.Count}");
                }

                //最も冊数の多い著者を1人求める
                var auth = db.Authors.Where(a => a.Books.Count() == db.Authors.Max(x => x.Books.Count())).First();
                Console.WriteLine($"{auth.Name}{auth.Gender}{auth.Birthday}");
            }

            Addname();
            
        }

        private static void Addname() {
            //using (var db = new BooksDbContext()) {
            //    var book1 = new Book {
            //        Title = "坊ちゃん",
            //        PublishedYear = 2003,
            //        Author = new Author {
            //            Birthday = new DateTime(1867, 2, 9),
            //            Gender = "M",
            //            Name = "夏目漱石",
            //        }
            //    };
            //    db.Books.Add(book1);
            //}
        }

        //13-14
        private static void DeleteBook() {
            using (var db = new BooksDbContext()) {
                var book = db.Books.SingleOrDefault(x => x.Id == 10);
                if (book != null) {
                    db.Books.Remove(book);
                    db.SaveChanges();
                }
            }
        }

        //13-11
        private static void UpdateBook() {
            using (var db = new BooksDbContext()) {
                var book = db.Books.Single(x => x.Title == "銀河鉄道の夜");
                book.PublishedYear = 2016;
                db.SaveChanges();
            }
        }

        // List 13-5
        static void InsertBooks() {
            using (var db = new BooksDbContext()) {
                var book1 = new Book {
                    Title = "坊ちゃん",
                    PublishedYear = 2003,
                    Author = new Author {
                        Birthday = new DateTime(1867, 2, 9),
                        Gender = "M",
                        Name = "夏目漱石",
                    }
                };
                db.Books.Add(book1);

                var book2 = new Book {
                    Title = "人間失格",
                    PublishedYear = 1990,
                    Author = new Author {
                        Birthday = new DateTime(1909, 6, 19),
                        Gender = "M",
                        Name = "太宰治",
                    }
                };
                db.Books.Add(book2);
                db.SaveChanges();//db更新

            }
        }


        //13-7
        static IEnumerable<Book> GetBooks() {
            using(var db = new BooksDbContext()) {
                return db.Books.Where(book => book.Author.Name.StartsWith("夏目")).ToList();
            }
        }

        //13-8
        static void DisplayAllBooks() {
            var books = GetBooks();
            foreach (var book in books) {
                Console.WriteLine($"{book.Title}{book.PublishedYear}");
            }
            Console.ReadLine();//F5で実行後、一時停止させる
        }

        // List 13-9
        private static void AddAuthors() {
            using (var db = new BooksDbContext()) {
                var author1 = new Author {
                    Birthday = new DateTime(1878, 12, 7),
                    Gender = "F",
                    Name = "与謝野晶子"
                };
                db.Authors.Add(author1);

                var author2 = new Author {
                    Birthday = new DateTime(1896, 8, 27),
                    Gender = "M",
                    Name = "宮沢賢治"
                };
                db.Authors.Add(author2);
                db.SaveChanges(); 
            }
        }

        // List 13-10
        private static void AddBooks() {
            using (var db = new BooksDbContext()) {
                var author1 = db.Authors.Single(a => a.Name == "与謝野晶子");
                var book1 = new Book {
                    Title = "みだれ髪",
                    PublishedYear = 2000,
                    Author = author1,
                };
                db.Books.Add(book1);

                var author2 = db.Authors.Single(a => a.Name == "宮沢賢治");
                var book2 = new Book {
                    Title = "銀河鉄道の夜",
                    PublishedYear = 1989,
                    Author = author2,
                };
                db.Books.Add(book2);
                db.SaveChanges();
            }
        }



    }
}
