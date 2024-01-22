using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreModelFirst4.Models
{
    [Table("URUNLER")]
    public class Urun
    {
        public int UrunID { get; set; }
        public string UrunAdi { get; set; }
        public double UrunFiyati { get; set; }
        public int KategoriID { get; set; }
        public Kategori? Kategori { get; set; }

        public override string ToString()
        {
            return $"{UrunID} {UrunAdi} {UrunFiyati} {KategoriID}";
        }
    }
}
