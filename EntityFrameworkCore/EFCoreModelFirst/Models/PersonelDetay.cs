using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreModelFirst.Models
{
    public class PersonelDetay
    {
        [ForeignKey("Personel")]
        public int PersonelDetayID { get; set; }
        public int SicilNotu { get; set; }
        public string Aciklama { get; set; }
        public Personel Personel { get; set; }
    }
}
