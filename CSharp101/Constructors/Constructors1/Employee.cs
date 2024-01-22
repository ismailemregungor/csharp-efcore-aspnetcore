using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors.Constructors1
{
    internal class Employee
    {
        // Constructor
        public Employee()
        {
            Console.WriteLine("ilk islemler");
        }

        // Destructure
        ~Employee()
        {
            Console.WriteLine("son islemler");
        }
    }
}
