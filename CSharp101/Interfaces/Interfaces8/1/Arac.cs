using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Interfaces8
{
    internal class Arac
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public ConsoleColor ArabaninRengi { get; set; }

        public void AraciBoya(ConsoleColor renk)
        {
            Console.BackgroundColor = renk;
            Console.WriteLine($"{Marka} {renk} {Model} boyandı.");
            Console.ResetColor();
        }
    }
}
