using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.KitapKutuphane
{
    internal class Kitap
    {
        private int KitapId { get; set; }

        private string KitapAdi { get; set; }

        private string YazarAdi { get; set; }

        private int KitapFiyati { get; set; }

        public Kitap(int KitapId, string KitapAdi, string YazarAdi, int KitapFiyati)
        {
            this.KitapId = KitapId;
            this.KitapAdi = KitapAdi;
            this.YazarAdi = YazarAdi;
            this.KitapFiyati = KitapFiyati;
        }
    }
}
