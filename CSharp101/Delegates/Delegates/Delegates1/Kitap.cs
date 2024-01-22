using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates.Delegates.Delegates1
{
    internal class Kitap
    {
        public int KitapId { get; set; }

        public string KitapAdi { get; set; }

        public double KitapFiyatı { get; set; }

        public string KitapKategorisi { get; set; }

        public override string ToString()
        {
            return $"{KitapId} {KitapAdi} {KitapFiyatı} {KitapKategorisi}";
        }
    }
}
