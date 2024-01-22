using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Shapes
{
    internal class Koni : Sekil
    {
        public double YariCap { get; set; }
        public double Yukseklik { get; set; }

        public Koni(double yariCap, double yukseklik)
        {
            YariCap = yariCap;
            Yukseklik = yukseklik;
        }

        public double HesaplaKoniAlani()
        {
            double yanYuzeyUzunlugu = Math.Sqrt(YariCap * YariCap + Yukseklik * Yukseklik);
            double yanYuzeyAlani = Math.PI * YariCap * yanYuzeyUzunlugu;
            return Math.PI * YariCap * (YariCap + yanYuzeyUzunlugu);
        }

        public double HesaplaKoniHacmi()
        {
            return (1.0 / 3.0) * Math.PI * YariCap * YariCap * Yukseklik;
        }
    }
}
