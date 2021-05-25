using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter {
    //feet m の単位変換クラス（静的クラス）
    static class FeetConverter {

        private const double ratio = 0.3048;

        //m to feet
        public　static double FromMeter(double meter) {
            return meter / ratio;
        }

        //feet to m
        public static double ToMeter(double feet) {
            return feet * ratio;
        }

    }
}
