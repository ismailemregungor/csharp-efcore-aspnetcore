using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreModelFirst.Models
{
    // Personel Modeli
    public class Personel
    {
        /*
         * 1 - ID veya ID adında bir property tanımlarsak EFCore primary key kabul eder.
         * 2 - PersonelId veya PersonelID adında bir property tanımlarsak EFCore primary key kabul eder.
         * ! - PerId veya PerID olarak tanımlarsak EF primary key olarak algılamaz!!!
         */
        public int PersonelID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public double Maas { get; set; }

        // Navigation Property
        // Personel ve Bölüm arasında One-to-Many ilişkisi vardır.
        // 1 Personelin 1 bölümü olabilir
        // Veri tabanına BolumID kendisi oluşacaktır.

        // Ama bazı kontrolleri yapmak için BolumId property'sini sonradan eklemek daha mantıklıdır.

        // One olanın id'si Foreign Key olur yani BolumID
        public int BolumID { get; set; }
        public Bolum Bolum { get; set; }

        // Personel ve Proje arasında Many-to-Many ilişkisi vardır.

        // 1 personelin n tane projesi olabilir, 1 proje'de n tane personel çalışabilir.
        // public ICollection<Proje> Projeler { get; set; }

        public ICollection<PersonelProje> Projeler { get; set; }

        // Personel ve PersonelDetay arasında One-to-One ilişkisi vardır.
        public PersonelDetay PersonelDetay { get; set; }
    }
}
