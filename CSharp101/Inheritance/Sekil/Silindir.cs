using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Sekil
{
    internal class Silindir:Daire
    {
        public double h { get; set; }

        public double SilindirHacimHesapla()
        {
            return base.AlanHesapla() * h;
        }
    }
}
