using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2 {
    class Program {
        static void Main(string[] args) {

            if (args.Length >= 1 && args[0] == "-toi") {
                PrintMeterToInchList(1, 10);
            } else {
                PrintInchToMeterList(1, 10);
            }
        }   
        
        private static void PrintMeterToInchList(int start, int stop) {
            for (int meter = start; meter <= stop; meter++) {
            double Inch = InchConverter.FromMeter(meter);
            Console.WriteLine("{0} m = {1:0.0000} inch", meter, Inch);
            }
        }

        private static void PrintInchToMeterList(int start, int stop) {
            for (int Inch = start; Inch <= stop; Inch++) {
            double meter = InchConverter.ToMeter(Inch);
            Console.WriteLine("{0} inch = {1:0.0000} m", Inch, meter);
            }
        }        
    }
}
