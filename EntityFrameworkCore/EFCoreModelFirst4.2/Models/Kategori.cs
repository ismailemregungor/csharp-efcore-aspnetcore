using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreModelFirst4._2.Models
{
    public class Kategori
    {
        public int KategoriID { get; set; }
        public string KategoriAdi { get; set; }

        public ICollection<Urun>? Urunler { get; set; }

        public override string ToString()
        {
            return $"{KategoriID} {KategoriAdi}";
        }
    }
}
