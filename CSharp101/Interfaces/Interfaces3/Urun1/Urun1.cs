using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Interfaces3.Urun1
{
    internal class Urun : IComparable
    {
        public int UrunId { get; set; }

        public string UrunAdi { get; set; }

        public double UrunFiyati { get; set; }

        public int CompareTo(object? obj)
        {
            Urun urun = obj as Urun;
            return UrunId.CompareTo(urun.UrunId);

            //if (UrunId > urun.UrunId)
            //{
            //    return -1;
            //}
            //else if (UrunId < urun.UrunId)
            //{
            //    return 1;
            //}
            //else
            //{
            //    return 0;
            //}
        }

        public override string ToString()
        {
            return $"{UrunId} {UrunAdi} {UrunFiyati}";
        }
    }
}
