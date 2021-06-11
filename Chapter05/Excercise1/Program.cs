using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise1 {
    class Program {
        static void Main(string[] args) {
#if false
#region 問題5.1
            Console.Write("文字列1:");
            var st1 = Console.ReadLine();
            Console.Write("文字列2:");
            var st2 = Console.ReadLine();
             
            if (string.Compare(st1, st2, ignoreCase:true) == 0)
                Console.WriteLine("等しい");
            else
                Console.WriteLine("等しくない");
#endregion
#endif

#region 問題5.2
            Console.Write("数値:");
            var str = int.Parse(Console.ReadLine());
            Console.WriteLine("{0:#,0}",str);
#endregion

        }
    }
}
