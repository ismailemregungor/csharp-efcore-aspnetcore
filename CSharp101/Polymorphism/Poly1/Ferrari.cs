using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Poly1
{
    internal class Ferrari : Araba
    {
        public override void Sur()
        {
            Console.WriteLine("Ferrari sür");
        }

        public override string ToString()
        {
            return "Ferrari bilgileri";
        }
    }
}
