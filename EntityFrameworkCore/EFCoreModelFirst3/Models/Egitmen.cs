using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreModelFirst3.Models
{
    public class Egitmen
    {
        public int EgitmenID { get; set; }
        public string EgitmenAdi { get; set; }
        public ICollection<Ders> EgitmenDersleri { get; set; }
    }
}
