using EFCoreSinavProvaCA1.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreSinavProvaCA1.Models
{
    public class Kitap
    {
        public int KitapID { get; set; }
        public string KitapAdi { get; set; }
        public int StokAdedi { get; set; }
        public double Fiyat { get; set; }
        public KitapDurumu KitapDurumu { get; set; }
        public DateTime EklemeTarih { get; set; }
        public int YayinEviID { get; set; }
        public Yayinevi? Yayinevi { get; set; }
    }
}
