using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    internal struct Nokta
    {
        public int X { get; set; }
        public int Y { get; set; }

        //public Nokta()
        //{

        //}

        public Nokta(int x, int y)
        {
            X = x;
            Y = y;
        }

        public string Point()
        {
            return $"P({X},{Y})";
        }
    }
}
