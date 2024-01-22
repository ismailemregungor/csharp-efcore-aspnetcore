using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ismailemregungorAlbumDukkani.Enums;

namespace ismailemregungorAlbumDukkani.Models
{
    // Album sınıfı, albüm özellikleri temsil eder.
    public class Album
    {
        public int AlbumID { get; set; }
        public string AlbumAdi { get; set; }
        public DateTime YayimTarihi { get; set; }
        public double Fiyat { get; set; }
        public double? IndirimOrani { get; set; }
        public AlbumDurumu AlbumDurumu { get; set; }
        // Albümün bağlı olduğu sanatçının ID'si.
        public int SanatciID { get; set; }
        // Albümün bağlı olduğu sanatçı
        public Sanatci Sanatci { get; set; }
    }
}
