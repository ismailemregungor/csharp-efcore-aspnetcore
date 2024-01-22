using EFCoreSinavProvaCA2.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreSinavProvaCA2.Models
{
    public class Album
    {
        public int AlbumID { get; set; }
        public string AlbumAdi { get; set; }
        public DateTime YayimTarihi { get; set; }
        public double Fiyat { get; set; }
        public AlbumDurumu AlbumDurumu { get; set; }
        public ICollection<Sarki> Sarkilar { get; set; }
        public int SanatciID { get; set; }
        public Sanatci Sanatci { get; set; }
    }
}
