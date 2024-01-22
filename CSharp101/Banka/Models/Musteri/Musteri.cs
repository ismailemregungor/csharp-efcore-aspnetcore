using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Models.Musteri
{
    public class Musteri
    {
        public string Ad { get; private set; }
        public Musteri(string ad)
        {
            Ad = ad;
        }
    }

}
