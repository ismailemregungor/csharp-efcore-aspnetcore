using System;
using System.Collections.Generic;

namespace EFCoreWFA1.Models
{
    public partial class Kategoriler
    {
        public Kategoriler()
        {
            Urunlers = new HashSet<Urunler>();
        }

        public int KategoriId { get; set; }
        public string KategoriAdi { get; set; } = null!;

        public virtual ICollection<Urunler> Urunlers { get; set; }
    }
}
