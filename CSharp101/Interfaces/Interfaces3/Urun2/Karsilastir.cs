using Interfaces.Interfaces3.Urun1;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Interfaces3.Urun2
{
    internal class Karsilastir: IComparer
    {
        public string NeyeGore { get; set; }
        public int Compare(object? x, object? y)
        {
            Urun2 urun1 = (Urun2)x;
            Urun2 urun2 = (Urun2)y;

            if (NeyeGore == "UrunId")
            {
                return urun1.UrunId.CompareTo(urun2.UrunId);
            }
            else if (NeyeGore == "UrunAdi")
            {
                return urun1.UrunAdi.CompareTo(urun2.UrunAdi);
            }
            else
            {
                return urun1.UrunFiyati.CompareTo(urun2.UrunFiyati);
            }
        }
    }
}
