using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreModelFirst2.Models
{
    [Table("PROJELER")]
    public class Proje
    {
        [Column("PROJE_ID")]
        public int ProjeID { get; set; }

        [Column("PROJEADI", TypeName = "CHAR"), StringLength(200)]
        public string ProjeAdi { get; set; }

        public ICollection<Personel> Personeller { get; set; }
    }
}
