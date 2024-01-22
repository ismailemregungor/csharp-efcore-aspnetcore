using System;
using System.Collections.Generic;

namespace EFCoreDatabaseFirst2.Models
{
    public partial class Urunler
    {
        public int UrunId { get; set; }
        public string UrunAdi { get; set; } = null!;
        public double Fiyat { get; set; }
        public int KategoriId { get; set; }
        public virtual Kategoriler Kategori { get; set; } = null!;

        public override string ToString()
        {
            return $"{UrunId} {UrunAdi} {Fiyat} {KategoriId}";
        }
    }
}
