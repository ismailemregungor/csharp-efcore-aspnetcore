using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KahveciSimulasyonuDLL.Enums;

namespace KahveciSimulasyonuDLL.Models
{
    public class Calisan : Kisi
    {
        public CalisanDurumu Durum { get; set; }
        public CalisanKonumu Konum { get; set; }

    }
}
