using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaV2DLL
{
    public class Vezne
    {
        public Personel Personel { get; set; }
        public VezneDurumu Durum { get; set; }

        public Vezne(Personel personel)
        {
            Personel = personel;
            Durum = VezneDurumu.Musait;
        }

        public void IslemYap(Musteri musteri)
        {
            if (Durum == VezneDurumu.Musait)
            {
                Durum = VezneDurumu.Mesgul;
                Console.WriteLine($"{musteri.Ad} isimli müşteri {Personel.Ad} tarafından hizmet alıyor. İşlem süresi: {musteri.Islem.Sure} dakika");
                System.Threading.Thread.Sleep(musteri.Islem.Sure * 1000); // Saniye cinsinden bekletmek için
                Durum = VezneDurumu.Musait;
                Console.WriteLine($"{musteri.Ad} isimli müşterinin işlemi tamamlandı. {Personel.Ad} müsait.");
            }
            else
            {
                Console.WriteLine($"{Personel.Ad} isimli personel meşgul. Lütfen bekleyiniz.");
            }
        }
    }
}
