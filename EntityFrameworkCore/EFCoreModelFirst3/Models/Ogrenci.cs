using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreModelFirst3.Models
{
    public class Ogrenci
    {
        public int OgrenciID { get; set; }
        public string OgrenciAdi { get; set; }
        public ICollection<OgrenciDers> OgrenciDersleri { get; set; }

    }
}
