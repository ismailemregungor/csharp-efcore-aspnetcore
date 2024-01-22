using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaDLL
{
    public static class BankaUtility
    {
        private static int personelId = 0;
        private static int musteriId = 1000;
        private static byte vezneNo = 65;
        private static string[] KisiOlustur()
        {
            string[] isimler =
            {
                "Cevdet","Selami","Dursun","Kemal","Deniz","Derya","Fuat","Suat","Cengaver","Temel","Ayse"
            };

            string[] soyisimler =
            {
                "Deniz","Aslan","Kaplan","Yıldırım","Durmasin","Irmak","Bayrak","Sancak"
            };

            Random random = new Random();
            string[] veriler = new string[2];
            veriler[0] = isimler[random.Next(0, isimler.Length)];
            veriler[1] = soyisimler[random.Next(0, soyisimler.Length)];

            return veriler;
        }
        public static Musteri MusteriOlustur()
        {
            Musteri musteri = new Musteri();
            musteri.Id = musteriId;
            musteriId++;
            string[] isimler = KisiOlustur();
            musteri.Ad = isimler[0];
            musteri.Soyad= isimler[1];

            musteri.IslemTipi = RastgeleIslemSec();
            musteri.HesapNo = Guid.NewGuid().ToString().Substring(0,9);
            musteri.Bakiye = new Random().NextDouble() * 10000;
            return musteri;
        }
        public static Personel PersonelOlustur()
        {
            Personel personel = new Personel();
            personel.Id = personelId;
            personelId++;
            string[] isimler = KisiOlustur();
            personel.Ad = isimler[0];
            personel.Soyad = isimler[1];

            return personel;
        }

        public static Vezne VezneOlustur(Personel personel)
        {
            Vezne vezne = new Vezne();
            vezne.Personel = personel;
            vezne.No = ((char)vezneNo).ToString();
            vezneNo++;
            vezne.VezneDurumu = (VezneDurumu)new Random().Next(1,4);

            return vezne;
        }

        private static Islem RastgeleIslemSec()
        {
            List<Islem> islemler = new List<Islem>();
            islemler.Add(new HavaleIslemi() { Sure = 5});
            islemler.Add(new ParaCekmeIslemi() { Sure = 7 });
            islemler.Add(new ParaYatirmaIslemi() { Sure = 2 });

            return islemler[new Random().Next(0, islemler.Count)];
        }
    }
}
