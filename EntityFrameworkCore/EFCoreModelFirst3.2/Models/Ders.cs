using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreModelFirst3._2.Models
{
    public class Ders
    {
        public int DersID { get; set; }
        public string DersAdi { get; set; }
        public int Kredi { get; set; }
        public ICollection<OgrenciDers>? OgrenciDersleri { get; set; }

        public ICollection<EgitmenDers>? EgitmenDersleri { get; set; }
    }
}
