using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Interfaces3.Urun2
{
    internal class Urun2
    {
        public int UrunId { get; set; }
        public string UrunAdi { get; set; }
        public double UrunFiyati { get; set; }

        public override string ToString()
        {
            return $"{UrunId} {UrunAdi} {UrunFiyati}";
        }
    }
}
