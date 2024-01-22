using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Interfaces8
{
    internal class Ferrari : Arac, IBoyanabilir
    {
        public Ferrari(string marka, string model)
        {
            Marka = marka;
            Model = model;
            ArabaninRengi = ConsoleColor.Green;
        }
        public void AraciBoya(ConsoleColor renk)
        {
            Console.BackgroundColor = renk;
            Console.WriteLine($"{Marka} {Model} boyandı.");
            Console.ResetColor();
        }
    }
}
