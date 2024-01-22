using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Sekil
{
    internal class Koni: Silindir
    {
        public double KoniHacimHesapla()
        {
            return base.SilindirHacimHesapla() * .3333;
        }
    }
}
