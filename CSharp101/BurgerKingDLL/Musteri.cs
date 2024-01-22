using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerKingDLL
{
    public class Musteri
    {
        public string Isim { get; private set; }

        public Siparis Siparis { get; private set; }

        public Musteri(string isim)
        {
            Isim = isim;
        }

        public void SiparisVer(Siparis siparis)
        {
            Siparis = siparis;
            siparis.Musteri = this;
        }

        public void SiparisiGoster()
        {
            Console.WriteLine($"Müşteri: {Isim}, Sipariş Durumu: {Siparis.Durum}");
            foreach (var hamburger in Siparis.Hamburgerler)
            {
                Console.WriteLine($"Hamburger Tipi: {hamburger.Tip}");
                foreach (var malzeme in hamburger.Malzemeler)
                {
                    Console.WriteLine($"Malzeme: {malzeme.Tip}");
                }
            }
        }
    }
}
