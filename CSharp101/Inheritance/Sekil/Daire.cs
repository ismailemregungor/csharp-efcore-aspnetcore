using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Sekil
{
    internal class Daire
    {
        public double r { get; set; }

        public double AlanHesapla()
        {
            return Math.PI * r * r;
        }
    }
}
