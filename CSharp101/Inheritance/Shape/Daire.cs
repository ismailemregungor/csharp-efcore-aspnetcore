using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Shapes
{
    internal class Daire: Sekil
    {
        public double YariCap { get; set; }

        public Daire(double yariCap)
        {
            YariCap = yariCap;
        }

        public double HesaplaDaireAlani()
        {
            return Math.PI * YariCap * YariCap;
        }
    }
}
