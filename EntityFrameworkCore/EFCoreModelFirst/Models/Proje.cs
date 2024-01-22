using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreModelFirst.Models
{
    public class Proje
    {
        public int ProjeID { get; set; }

        public string ProjeAdi { get; set; }

        // Personel ve Proje arasında Many-to-Many ilişkisi vardır.

        // 1 personelin n tane projesi olabilir, 1 proje'de n tane personel çalışabilir.
        // public ICollection<Personel> Personeller { get; set; }

        public ICollection<PersonelProje> Personeller { get; set; }

    }
}
