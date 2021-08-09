using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise {
    class Program {
        static void Main(string[] args) {
            if (args.Length == 0)
                return;
            var dir = args[0];
            Display(dir, 1 * 1024L * 1024L);
        }

        private static void Display(string directory ,long filesize) {
            var files = Directory.EnumerateFiles(directory, "*.*", SearchOption.AllDirectories)
                                 .Where(file => FileSize(file) >= filesize);
            foreach (var file in files)
                Console.WriteLine(file);
        }

        private static long FileSize(string file) {
            var fi = new FileInfo(file);
            return fi.Length;
        }
    }


}
