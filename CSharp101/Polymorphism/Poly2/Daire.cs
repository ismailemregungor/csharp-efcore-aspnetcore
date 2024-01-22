using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Poly2
{
    internal class Daire
    {
        public double r { get; set; }

        public virtual double AlanHesapla()
        {
            return Math.PI * r * r;
        }
    }
}
