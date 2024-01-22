using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Shapes
{
    internal class Silindir: Sekil
    {

        public double YariCap { get; set; }
        public double Yukseklik { get; set; }

        public Silindir(double yariCap, double yukseklik)
        {
            YariCap = yariCap;
            Yukseklik = yukseklik;
        }

        public double HesaplaSilindirAlani()
        {
            double daireAlani = Math.PI * YariCap * YariCap;
            double yanYuzeyAlani = 2 * Math.PI * YariCap * Yukseklik;
            return 2 * daireAlani + yanYuzeyAlani;
        }

        public double HesaplaSilindirHacmi()
        {
            return Math.PI * YariCap * YariCap * Yukseklik;
        }
    }
}
