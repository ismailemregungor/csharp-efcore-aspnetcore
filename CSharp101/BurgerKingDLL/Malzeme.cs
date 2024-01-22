using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerKingDLL
{
    public class Malzeme
    {
        public MalzemeTipi Tip { get; private set; }

        public Malzeme(MalzemeTipi tip)
        {
            Tip = tip;
        }
    }
}
