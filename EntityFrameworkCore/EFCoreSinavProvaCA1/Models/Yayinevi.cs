using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreSinavProvaCA1.Models
{
    public class Yayinevi
    {
        public int YayinEviID { get; set; }
        public string YayineviAdi { get; set; }
        public string Adres { get; set; }
        public ICollection<Kitap>? Kitaplar { get; set; }
    }
}
