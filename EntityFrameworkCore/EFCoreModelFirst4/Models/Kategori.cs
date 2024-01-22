using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreModelFirst4.Models
{
    [Table("KATEGORILER")]
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
