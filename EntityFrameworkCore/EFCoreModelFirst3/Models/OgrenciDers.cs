using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreModelFirst3.Models
{
    public class OgrenciDers
    {
        public int OgrenciDersID { get; set; }
        public int OgrenciID { get; set; }
        public Ogrenci Ogrenci { get; set; }
        public int DersID { get; set; }
        public Ders Ders { get; set; }

        [Range(0, 100)]
        public int Not { get; set; }
    }
}
