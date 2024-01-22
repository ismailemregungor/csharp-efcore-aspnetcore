using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreModelFirst2.Models
{
    [Table("PERSONELLER")]
    public class Personel
    {
        public int PersonelID { get; set; }

        public string Ad { get; set; }

        public string Soyad { get; set; }

        public int BolumID { get; set; }

        public Proje Proje { get; set; }

        public Bolum Bolum { get; set; }
    }
}
