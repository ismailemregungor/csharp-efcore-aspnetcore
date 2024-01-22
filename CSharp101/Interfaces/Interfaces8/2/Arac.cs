using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Interfaces8._2
{
    internal abstract class Arac
    {
        public ConsoleColor Renk { get; set; }

        public Arac() 
        {
            Renk = Utility.GetRandomColor();
            Console.ForegroundColor = Renk;
        }

        
    }
}
