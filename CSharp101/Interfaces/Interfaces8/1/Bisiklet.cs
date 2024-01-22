using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Interfaces8
{
    internal class Bisiklet: Arac, IBoyanabilir
    {
        public Bisiklet(string marka, string model)
        {
            Marka = marka;
            Model = model;
            ArabaninRengi = ConsoleColor.Gray;
        }

        public void AraciBoya(ConsoleColor renk)
        {
            Console.BackgroundColor = renk;
            Console.WriteLine($"{Marka} {Model} boyandı.");
            Console.ResetColor();
        }
    }
}
