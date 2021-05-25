using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter {
    class FeetConverter {
        //m to feet
        public　static double FromMeter(double meter) {
            return meter / 0.3048;
        }

        //feet to m
        public static double ToMeter(double feet) {
            return feet * 0.3048;
        }

    }
}
