using System;
using System.Collections.Generic;

namespace ASPNETCOREWebApiDbFirstUrunApi.Models
{
    public partial class Urunler
    {
        public int UrunId { get; set; }
        public string UrunAdi { get; set; } = null!;
        public double UrunFiyati { get; set; }
        public int KategoriId { get; set; }

        public virtual Kategoriler Kategori { get; set; } = null!;
    }
}
