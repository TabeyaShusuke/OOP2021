using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter {
    class Program {
        static void Main(string[] args) {

            if (args.Length >= 1&& args[0] == "-tom") {
                PrintFeetToMeterList(10,110);
            } else {
                PrintMeterToFeetList(10,110);
            }
        }

        //feet to m
        private static void PrintFeetToMeterList(int start,int stop) {

            FeetConverter f = new FeetConverter();

            for (int feet = start; feet <= stop; feet++) {
                double meter = f.ToMeter(feet);
                Console.WriteLine("{0} ft = {1:0.0000} m", feet, meter);
            }
        }

        //m to feet
        private static void PrintMeterToFeetList(int start, int stop) {

            FeetConverter f = new FeetConverter();

            for (int meter = start; meter <= stop; meter++) {
                double feet = f.FromMeter(meter);
                Console.WriteLine("{0} m = {1:0.0000} ft", meter, feet);
            }
        }
    }
}
