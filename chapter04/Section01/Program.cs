using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {
        static void Main(string[] args) {
            //var person = new Person { 
            //    Name = "新井遥菜",
            //    Birthday = new DateTime(1995,11,23),
            //    PhoneNumber = "123-3456-7890",
            //};

            //var list = new List<int> { 10,20,30,40,};
            //var key = 400;
            //var num = list.Contains(key) ? "あるよ" : "ないよ";
            //Console.WriteLine(num);

            //null合体演算子
            //string code = "12345";
            //var message = GetMessage(code) ?? DefalutMessage();
            //Console.WriteLine(message);

            //var ret =  GetProductA();

            //int count = 0;
            //Console.WriteLine($"後置:{count++}");
            //Console.WriteLine($"前置:{++count}");

            //var str = "123a";
            //int height;
            //if (int.TryParse(str,out var height)) {
            //    Console.WriteLine(height);
            //} else {
            //    Console.WriteLine("変換不可");
            //}


            var Session = new Dictionary<string, object>();
            Session["MyProduct"] = new Product();
            var product = Session["MyProduct"] as Product;
            if (product == null) {
                //できないとき
                Console.WriteLine("product取得できません。");
            } else {
                //できるとき
                Console.WriteLine("product取得できました。");
            }

        }

        //private static Product GetProductA() {
        //    Sale sale = new Sale();
        //    return sale?.Product; //null条件演算子
        //}
        

        //スタブ
        //private static object DefalutMessage() {
        //    return "Defalut Message";
        //}
        //スタブ
        //private static object GetMessage(object code) {
        //    return code;
        //}
    }

    class Sale {
        public string ShopName { get; set; } = "abcde";
        public int Amount { get; set; } = 12340;
        public Product Product { get; set; } 

    }

}
