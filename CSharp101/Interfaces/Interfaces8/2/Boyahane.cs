using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Interfaces8._2
{
    internal class Boyahane
    {
        public void Boya(IBoyanabilir arac, ConsoleColor yeniRenk)
        {
            ((Arac)arac).Renk = yeniRenk;
        }
    }
}
