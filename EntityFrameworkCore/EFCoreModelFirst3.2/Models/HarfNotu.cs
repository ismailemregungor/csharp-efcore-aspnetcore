using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreModelFirst3._2.Models
{
    public class HarfNotu
    {
        public int HarfNotID { get; set; }

        public string Harf { get; set; }

        public int MinDeger { get; set; }

        public int MaxDeger { get; set; }

        public OgrenciDers? Ders { get; set; }
    }
}
