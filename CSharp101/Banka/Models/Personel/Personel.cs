using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka
{
    public class Personel
    {
        public string Ad { get; private set; }
        public Personel(string ad)
        {
            Ad = ad;
        }
    }
}
