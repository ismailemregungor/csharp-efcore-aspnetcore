using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreModelFirst3._2.Models
{
    [Index("HarfNotID", IsUnique = true)]
    public class OgrenciDers
    {
        public int OgrenciDersID { get; set; }
        public int OgrenciID { get; set; }
        public int DersID { get; set; }
        public int Not { get; set; }

        [ForeignKey("HarfNot")]
        public int HarfNotID { get; set; }
        public Ders? Ders { get; set; }
        public Ogrenci? Ogrenci { get; set; }
        public HarfNotu? HarfNotu { get; set; }
    }
}
