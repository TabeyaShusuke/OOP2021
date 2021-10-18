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
            //using (var db = new BooksDbContext()) {
            //    db.Database.Log = sql => { Debug.Write(sql); };
            //    var count = db.Books.Count();
            //    Console.WriteLine(count);


            //}

            //using (var db = new BooksDbContext()) {
            //    //書籍2冊以上の著者取得
            //    var authors = db.Authors.Where(a => a.Books.Count() >= 2);
            //    foreach (var author in authors) {
            //        Console.WriteLine($"{author.Name}{author.Gender}{author.Birthday}");
            //    }

            //    //出版年、著者順（昇順）に並べ替え取得
            //    var books = db.Books.OrderBy(b => b.PublishedYear)
            //                        .ThenBy(b => b.Author.Name);
            //    foreach (var book in books) {
            //        Console.WriteLine($"{book.Title}{book.PublishedYear}{book.Author.Name}");
            //    }

            //    //発行年毎の書籍数を求める
            //    var groups = db.Books.GroupBy(b => b.PublishedYear)
            //                         .Select(g => new {
            //                             Year = g.Key,
            //                             Count = g.Count()
            //                         });
            //    foreach (var g in groups) {
            //        Console.WriteLine($"{g.Year}{g.Count}");
            //    }

            //    //最も冊数の多い著者を1人求める
            //    var auth = db.Authors.Where(a => a.Books.Count() == db.Authors.Max(x => x.Books.Count())).First();
            //    Console.WriteLine($"{auth.Name}{auth.Gender}{auth.Birthday}");
            //}

            InsertBooks();
            AddAuthors();
            AddBooks();

            //1
            Addname();

            //2
            foreach (var book in GetData()) {
                Console.WriteLine($"{book.Title} {book.PublishedYear} " +
                    $"{book.Author.Name} {book.Author.Birthday}");
            }
            Console.WriteLine("*************************************************************");

            MaxlengthTitle();
            Console.WriteLine("*************************************************************");
            //4
            OldTitle();
            Console.WriteLine("*************************************************************");
            //5
            DescBirth();
            Console.WriteLine("*************************************************************");
        }

        private static void DescBirth() {
            using (var db = new BooksDbContext()) {
                var books = db.Books.OrderByDescending(s => s.Author.Birthday);
                foreach (var book in books) {
                    Console.WriteLine($"{book.Title} {book.PublishedYear} {book.Author.Name} {book.Author.Birthday}");
                }
            }
        }

        private static void OldTitle() {
            using (var db = new BooksDbContext()) {
                var books = db.Books.OrderBy(s => s.PublishedYear).Take(3);
                foreach (var book in books) {
                    Console.WriteLine($"{book.Title} {book.Author.Name} {book.PublishedYear}");
                }
            }
        }

        //3
        private static void MaxlengthTitle() {
            using (var db = new BooksDbContext()) {
                var author = db.Books.Where(s => s.Title.Length == db.Books.Max(a => a.Title.Length));
                foreach (var book in author) {
                    Console.WriteLine($"{book.Title}");
                }
            } 
        }

        private static IEnumerable<Book> GetData() {
            using (var db = new BooksDbContext()) {
                return db.Books.Include(nameof(Author)).ToList();
            }
        }

        //章末問題1
        private static void Addname() {
            using (var db = new BooksDbContext()) {
                var author3 = db.Authors.Single(a => a.Name == "夏目漱石");
                var book1 = new Book {
                    Title = "こころ",
                    PublishedYear = 1991,
                    Author = author3,
                };
                db.Books.Add(book1);

                

                var author6 = db.Authors.Single(a => a.Name == "宮沢賢治");
                var book4 = new Book {
                    Title = "注文の多い料理店",
                    PublishedYear = 2000,
                    Author = author6,
                };
                db.Books.Add(book4);
                db.SaveChanges();
            }

            using (var db = new BooksDbContext()) {
                var book1 = new Book {
                    Title = "真珠婦人",
                    PublishedYear = 2002,
                    Author = new Author {
                        Birthday = new DateTime(1888, 12, 26),
                        Gender = "M",
                        Name = "菊池寛",
                    }
                };
                db.Books.Add(book1);

                var book2 = new Book {
                    Title = "伊豆の踊子",
                    PublishedYear = 2003,
                    Author = new Author {
                        Birthday = new DateTime(1899, 6, 14),
                        Gender = "M",
                        Name = "川端康成",
                    }
                };
                db.Books.Add(book2);
                db.SaveChanges();

            }

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
