using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreSinavProvaWFA1.Models
{
    public class Kitap
    {
        public int KitapID { get; set; }
        public string Adi { get; set; }
        public decimal Fiyat { get; set; }
        public bool Durum { get; set; } 
        public int? YayinEviID { get; set; }
        public YayinEvi?YayinEvi { get; set; }
    }
}
