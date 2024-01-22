using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Poly2
{
    internal class Koni : Silindir
    {
        public override double AlanHesapla()
        {
            return base.AlanHesapla() * .3333;
        }
    }
}
