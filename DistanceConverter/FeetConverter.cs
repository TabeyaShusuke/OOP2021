using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter {
    class FeetConverter {
        //m to feet
        public double FromMeter(double meter) {
            return meter / 0.3048;
        }

        //feet to m
        public double ToMeter(double feet) {
            return feet * 0.3048;
        }

    }
}
