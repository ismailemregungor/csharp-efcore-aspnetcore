using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToObject._2
{
    public class Urun : IComparable<Urun>
    {
        public int UrunId { get; set; }

        public string UrunAdi { get; set; }

        public double Fiyat { get; set; }

        public int KategoriId { get; set; }

        public int CompareTo(Urun other)
        {
            return this.UrunId.CompareTo(other.UrunId) * -1;
        }

        public override string ToString()
        {
            return $"{UrunId} {UrunAdi} {Fiyat} {KategoriId}";
        }
    }
}
