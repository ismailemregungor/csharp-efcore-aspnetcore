using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KahveciSimulasyonuDLL.Enums;
using KahveciSimulasyonuDLL.Models;

namespace KahveciSimulasyonuDLL.Managers
{
    public class KahveDukkani
    {
        public List<Calisan> Calisanlar { get; set; } = new List<Calisan>();
        public Queue<Musteri> Musteriler { get; set; } = new Queue<Musteri>();
        public Queue<Siparis> Siparisler { get; set; } = new Queue<Siparis>();
        public List<Urun> Urunler { get; set; } = new List<Urun>();
        public List<Envanter> Envanterler { get; set; } = new List<Envanter>();

        public void SiparisAl(Siparis siparis)
        {
            var kasaCalisani = Calisanlar.FirstOrDefault(c => c.Konum == CalisanKonumu.Kasa && c.Durum == CalisanDurumu.Musait);
            var bosCalisan = Calisanlar.FirstOrDefault(c => c.Durum == CalisanDurumu.Musait);

            if (kasaCalisani != null && bosCalisan != null)
            {
                Siparisler.Enqueue(siparis);
                bosCalisan.Durum = CalisanDurumu.Mesgul;
                Console.WriteLine($"Sipariş alındı: {siparis.Urun.Ad}");
            }
            else if (kasaCalisani == null)
            {
                Console.WriteLine("Kasada müsait çalışan yok!");
            }
            else
            {
                Console.WriteLine("Ürün hazırlayacak boşta çalışan yok!");
            }
        }
        public void SiparisHazirla()
        {
            Calisan calisan = new Calisan();
            if (Siparisler.Count > 0)
            {
                var siparis = Siparisler.Dequeue();
                var hazirlamaCalisani = Calisanlar.FirstOrDefault(c => c.Durum == CalisanDurumu.Mesgul);
                if (hazirlamaCalisani != null)
                {
                    Console.WriteLine($"{hazirlamaCalisani} çalışanı {siparis.Urun.Ad} ürününü hazırlıyor...");
                    Thread.Sleep(siparis.HazirlanmaSuresiHesapla() * 1000);
                    Console.WriteLine($"{siparis.Urun.Ad} hazırlandı.");
                    siparis.Durum = SiparisDurumu.Hazir;
                    hazirlamaCalisani.Durum = CalisanDurumu.Musait;
                }
            }
        }
        public void SiparisTeslimEt(Siparis siparis)
        {
            if (siparis.Durum == SiparisDurumu.Hazir)
            {
                Console.WriteLine($"{siparis.Musteri.Isim} adlı müşteriye {siparis.Urun.Ad} teslim edildi.");
                siparis.Durum = SiparisDurumu.TeslimEdildi;
                Console.WriteLine("Tüm siparişler teslim edildi.");
            }
        }

        public void CalisanEkle(Calisan calisan)
        {
            Calisanlar.Add(calisan);
        }

        public bool CalisanSil(string isim)
        {
            var calisan = Calisanlar.FirstOrDefault(c => c.Isim == isim);
            if (calisan != null)
            {
                Calisanlar.Remove(calisan);
                return true;
            }
            return false;
        }
        public void CalisanlariListele()
        {
            if (Calisanlar.Count == 0)
            {
                Console.WriteLine("Hiç çalışan yok!");
                return;
            }
            Console.WriteLine("Çalışanlar:");
            foreach (var calisan in Calisanlar)
            {
                Console.WriteLine(calisan);
            }
        }

        public void MusteriEkle(Musteri musteri)
        {
            Musteriler.Enqueue(musteri);
        }

        public void MusterileriListele()
        {
            if (Musteriler.Count == 0)
            {
                Console.WriteLine("Hiç müşteri yok!");
                return;
            }
            Console.WriteLine("Müşteriler:");
            foreach (var musteri in Musteriler)
            {
                Console.WriteLine(musteri);
            }
        }
    }
}
