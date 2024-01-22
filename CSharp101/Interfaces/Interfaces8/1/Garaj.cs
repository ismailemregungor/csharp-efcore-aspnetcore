using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Interfaces8
{
    internal class Garaj
    {
        public void Boya(IBoyanabilir boyanabilir, ConsoleColor renk)
        {
            Console.WriteLine($"Araç {renk} rengine boyanıyor...");
            boyanabilir.AraciBoya(renk);
        }
    }
}
