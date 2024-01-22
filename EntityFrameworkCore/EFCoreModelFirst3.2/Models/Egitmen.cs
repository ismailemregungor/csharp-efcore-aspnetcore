using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreModelFirst3._2.Models
{
    public class Egitmen
    {
        public int EgitmenID { get; set; }

        public string Ad { get; set; }

        public string Soyad { get; set; }

        public ICollection<EgitmenDers>? EgitmenDersleri { get; set; }
    }
}
