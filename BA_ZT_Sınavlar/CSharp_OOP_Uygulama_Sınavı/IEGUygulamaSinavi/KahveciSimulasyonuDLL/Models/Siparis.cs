using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KahveciSimulasyonuDLL.Enums;

namespace KahveciSimulasyonuDLL.Models
{
    public class Siparis
    {
        public Musteri Musteri { get; set; }
        public Urun Urun { get; set; }
        public List<Envanter> Ekstralar { get; set; } = new List<Envanter>();
        public SiparisDurumu Durum { get; set; } = SiparisDurumu.Hazirlaniyor;

        public int HazirlanmaSuresiHesapla()
        {
            int toplamSure = Urun.HazirlanmaSuresi;
            foreach (var ekstra in Ekstralar)
            {
                toplamSure += ekstra.EkstraSure;
            }
            return toplamSure;
        }
    }
}
