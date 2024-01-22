using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerKingDLL
{
    public class BurgerKing
    {
        private List<Kasa> kasalar;
        private List<Asci> ascilar;
        public List<Musteri> Musteriler { get; private set; }

        public BurgerKing()
        {
            kasalar = new List<Kasa>
            {
                new Kasa() // Bir adet kasa nesnesi oluşturulup listeye ekleniyor
            };
            ascilar = new List<Asci>
            {
                new Asci() // Bir adet aşçı nesnesi oluşturulup listeye ekleniyor
            };
            Musteriler = new List<Musteri>();
        }
        public void MusteriEkle(Musteri musteri)
        {
            Musteriler.Add(musteri);
        }
        public void SiparisAl(Siparis siparis)
        {
            // Burada siparişi alan kasa seçilir.
            Kasa kasa = kasalar[0];
            kasa.SiparisAl(siparis);
            Musteriler.Add(siparis.Musteri);
        }
        public void SiparisHazirla(Siparis siparis)
        {
            // Burada siparişi hazırlayan aşçı seçilir.
            Asci asci = ascilar[0];
            asci.HamburgerHazirla(siparis);
        }

        public void MusterileriListele()
        {
            Console.WriteLine("Müşteri Listesi:");
            foreach (var musteri in Musteriler)
            {
                Console.WriteLine($"Ad: {musteri.Isim}, Sipariş Durumu: {musteri.Siparis.Durum}");
            }
        }
    }
}
