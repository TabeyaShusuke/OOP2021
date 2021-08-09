using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1 {
    class Program {
        static void Main(string[] args) {
            var filepath = @"C:\Users\st32261\Desktop\HTML\sf.txt";
            if (File.Exists(filepath)) {
                using (var reader = new StreamReader(filepath,Encoding.GetEncoding("shift_jis"))) {
                    while (!reader.EndOfStream) {
                        var line = reader.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            }
        }
    }
}
