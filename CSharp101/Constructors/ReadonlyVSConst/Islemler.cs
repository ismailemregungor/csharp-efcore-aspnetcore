using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors.ReadonlyVSConst
{
    internal class Islemler
    {
        public readonly double katsayi = 1.2;

        public Islemler()
        {

        }

        public Islemler(double katsayi)
        {
            this.katsayi = katsayi;
        }
    }
}
