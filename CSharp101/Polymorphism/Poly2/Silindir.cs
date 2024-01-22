using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Poly2
{
    internal class Silindir : Daire
    {
        public double h { get; set; }
        public override double AlanHesapla()
        {
            return base.AlanHesapla() * h;
        }
    }
}
