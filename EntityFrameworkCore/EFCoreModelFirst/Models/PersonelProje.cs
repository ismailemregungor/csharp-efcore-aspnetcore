using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreModelFirst.Models
{
    public class PersonelProje
    {
        public int PersonelProjeID { get; set; }
        public int PersonelID { get; set; }
        public int ProjeID { get; set; }
        public Proje Proje { get; set; }
        public Personel Personel { get; set; }

    }
}
