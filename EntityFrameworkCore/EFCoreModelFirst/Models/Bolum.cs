using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreModelFirst.Models
{
    [Table("BOLUMLER")]
    public class Bolum
    {
        [Column("BOLUM_ID")]
        public int BolumId { get; set; }

        [Column("BOLUM_ADI", TypeName = "CHAR")]
        [StringLength(100)]
        public string BolumAdi { get; set; }

        // public List<Personel> Personeller { get; set; } demek yerine ICollection kullanmak daha iyidir.

        // 1 Bölümde n tane Personel olabilir.
        public ICollection<Personel> Personeller { get; set; }
    }
}
