using EFCoreSinavProvaCA1.Data;
using EFCoreSinavProvaCA1.Enums;
using EFCoreSinavProvaCA1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreSinavProvaCA1.Utilities
{
    public static class Utility
    {
        public static bool GirisYap()
        {
            Console.Write("Kullanıcı Adı: ");
            string kullaniciAdi = Console.ReadLine();
            Console.Write("Şifre: ");
            string sifre = Console.ReadLine();

            var kullaniciManager = new KullaniciManager<Kullanici>();
            var kullanici = kullaniciManager.BulKullaniciAdiIle(kullaniciAdi);

            if (kullanici != null && kullaniciAdi == kullanici.KullaniciAdi && sifre == kullanici.Sifre)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool MenuGoster()
        {
            Console.WriteLine("\n1. Kitap İşlemleri");
            Console.WriteLine("2. Yayınevi İşlemleri");
            Console.WriteLine("3. Kullanıcı İşlemleri");
            Console.WriteLine("4. Raporlar");
            Console.WriteLine("5. Çıkış Yap");
            Console.Write("\nSeçiminiz: ");
            var secim = Console.ReadLine();
            switch (secim)
            {
                case "1":
                    KitapMenu();
                    break;
                case "2":
                    YayineviMenu();
                    break;
                case "3":
                    KullaniciMenu();
                    break;
                case "4":
                    RaporlariGoruntule();
                    break;
                case "5":
                    return true; 
                default:
                    Console.WriteLine("Geçersiz seçim!");
                    break;
            }
            return false;
        }

        public static void KitapMenu()
        {
            Console.WriteLine("Kitap İşlemleri Menüsü");
            Console.WriteLine("1. Kitap Ekle");
            Console.WriteLine("2. Kitap Güncelle");
            Console.WriteLine("3. Kitap Sil");
            Console.WriteLine("4. Kitap Listele");
            Console.WriteLine("5. Kitap Ara");
            Console.WriteLine("6. Ana Menüye Dön");
            Console.Write("\nSeçiminiz: ");
            var secim = Console.ReadLine();
            switch (secim)
            {
                case "1":
                    KitapEkle();
                    break;
                case "2":
                    KitapGuncelle();
                    break;
                case "3":
                    KitapSil();
                    break;
                case "4":
                    KitaplariListele();
                    break;
                case "5":
                    KitapAra();
                    break;
                case "6":
                    return;
                default:
                    Console.WriteLine("Geçersiz seçim!");
                    break;
            }
        }

        public static void YayineviMenu()
        {
            Console.WriteLine("Yayınevi İşlemleri Menüsü");
            Console.WriteLine("1. Yayınevi Ekle");
            Console.WriteLine("2. Yayınevi Güncelle");
            Console.WriteLine("3. Yayınevi Sil");
            Console.WriteLine("4. Yayınevi Listele");
            Console.WriteLine("5. Yayınevi Ara");
            Console.WriteLine("6. Ana Menüye Dön");
            Console.Write("\nSeçiminiz: ");
            var secim = Console.ReadLine();
            switch (secim)
            {
                case "1":
                    YayineviEkle();
                    break;
                case "2":
                    YayineviGuncelle();
                    break;
                case "3":
                    YayineviSil();
                    break;
                case "4":
                    YayinevleriniListele();
                    break;
                case "5":
                    YayineviAra();
                    break;
                case "6":
                    return;
                default:
                    Console.WriteLine("Geçersiz seçim!");
                    break;
            }
        }

        public static void KullaniciMenu()
        {
            Console.WriteLine("Kullanıcı İşlemleri Menüsü");
            Console.WriteLine("1. Kullanıcı Ekle");
            Console.WriteLine("2. Kullanıcı Güncelle");
            Console.WriteLine("3. Kullanıcı Sil");
            Console.WriteLine("4. Kullanıcı Listele");
            Console.WriteLine("5. Kullanıcı Ara");
            Console.WriteLine("6. Ana Menüye Dön");
            Console.Write("\nSeçiminiz: ");
            var secim = Console.ReadLine();
            switch (secim)
            {
                case "1":
                    KullaniciEkle();
                    break;
                case "2":
                    KullaniciGuncelle();
                    break;
                case "3":
                    KullaniciSil();
                    break;
                case "4":
                    KullanicilariListele();
                    break;
                case "5":
                    KullaniciAra();
                    break;
                case "6":
                    return; 
                default:
                    Console.WriteLine("Geçersiz seçim!");
                    break;
            }
        }

        public static void KitapEkle()
        {
            Console.WriteLine("Yeni Kitap Ekleme Ekranı");
            Console.Write("Kitap Adı: ");
            var kitapAdi = Console.ReadLine();
            Console.Write("Stok Adedi: ");
            var stokAdedi = int.Parse(Console.ReadLine());
            Console.Write("Fiyat: ");
            var fiyat = double.Parse(Console.ReadLine());
            Console.Write("Yayın Evi ID: ");
            var yayinEviId = int.Parse(Console.ReadLine());

            var kitap = new Kitap
            {
                KitapAdi = kitapAdi,
                StokAdedi = stokAdedi,
                Fiyat = fiyat,
                EklemeTarih = DateTime.Now,
                YayinEviID = yayinEviId,
                KitapDurumu = KitapDurumu.Aktif
            };

            var kitapManager = new KitapManager<Kitap>();
            kitapManager.Ekle(kitap);
            Console.WriteLine("Kitap başarıyla eklendi!");
        }

        public static void KitapGuncelle()
        {
            Console.WriteLine("Kitap Güncelleme Ekranı");
            Console.Write("Güncellenecek Kitap ID: ");
            var kitapId = int.Parse(Console.ReadLine());

            var kitapManager = new KitapManager<Kitap>();
            var kitap = kitapManager.Bul(kitapId);
            if (kitap == null)
            {
                Console.WriteLine("Kitap bulunamadı!");
                return;
            }

            Console.Write("Yeni Kitap Adı (Mevcut: " + kitap.KitapAdi + "): ");
            kitap.KitapAdi = Console.ReadLine();
            Console.Write("Yeni Stok Adedi (Mevcut: " + kitap.StokAdedi + "): ");
            kitap.StokAdedi = int.Parse(Console.ReadLine());
            Console.Write("Yeni Fiyat (Mevcut: " + kitap.Fiyat + "): ");
            kitap.Fiyat = double.Parse(Console.ReadLine());
            Console.Write("Yeni Yayın Evi ID (Mevcut: " + kitap.YayinEviID + "): ");
            kitap.YayinEviID = int.Parse(Console.ReadLine());
            Console.WriteLine("Yeni Durum (1-Aktif, 2-Pasif): ");
            kitap.KitapDurumu = (Console.ReadLine() == "1") ? KitapDurumu.Aktif : KitapDurumu.Pasif;

            kitapManager.Guncelle(kitap);
            Console.WriteLine("Kitap başarıyla güncellendi!");
        }

        public static void KitapSil()
        {
            Console.WriteLine("Kitap Silme Ekranı");
            Console.Write("Silinecek Kitap ID: ");
            var kitapId = int.Parse(Console.ReadLine());

            var kitapManager = new KitapManager<Kitap>();
            kitapManager.Sil(kitapId);
            Console.WriteLine("Kitap başarıyla silindi!");
        }

        public static void KitaplariListele()
        {
            Console.WriteLine("Kitap Listeleme Ekranı");
            var kitapManager = new KitapManager<Kitap>();
            var kitaplar = kitapManager.ListeleJoin("Yayinevi");

            foreach (var kitap in kitaplar)
            {
                Console.WriteLine($"ID: {kitap.KitapID}, Adı: {kitap.KitapAdi}, Stok: {kitap.StokAdedi}, Fiyat: {kitap.Fiyat}, Kitap Durumu: {kitap.KitapDurumu}, Yayınevi Adi: {kitap.Yayinevi.YayineviAdi}");
            }
        }

        public static void KitapAra()
        {
            Console.WriteLine("Kitap Arama Ekranı");
            Console.Write("Aranacak Kitap ID: ");
            int kitapId = Convert.ToInt32(Console.ReadLine());
            KitapManager<Kitap> kitapManager = new KitapManager<Kitap>();
            Kitap kitap = kitapManager.Bul(kitapId);

            if (kitap != null)
            {
                Console.WriteLine($"ID: {kitap.KitapID}, Adı: {kitap.KitapAdi}, Stok: {kitap.StokAdedi}, Fiyat: {kitap.Fiyat}, Kitap Durumu: {kitap.KitapDurumu}");
            }
            else
            {
                Console.WriteLine("Kitap bulunamadı.");
            }
        }

        public static void RaporListesiniYazdir(List<Kitap> kitaplar)
        {
            foreach (var kitap in kitaplar)
            {
                var yayineviAdi = kitap.Yayinevi != null ? kitap.Yayinevi.YayineviAdi : "Yayınevi Bilgisi Yok";
                Console.WriteLine($"ID: {kitap.KitapID}, Adı: {kitap.KitapAdi}, Stok: {kitap.StokAdedi}, Fiyat: {kitap.Fiyat}, Durum: {kitap.KitapDurumu}, Yayınevi: {yayineviAdi}, Ekleme Tarihi: {kitap.EklemeTarih}");
            }
        }

        public static void RaporlariGoruntule()
        {
            Console.WriteLine("Raporlar Ekranı");
            Console.WriteLine("1. En Son Eklenen 10 Kitap");
            Console.WriteLine("2. Yayın Evlerine Göre Kitaplar");
            Console.WriteLine("3. Satışı Durdurulan Kitaplar");
            Console.WriteLine("4. Fiyatına Göre Kitaplar");
            Console.Write("Seçiminiz: ");
            var secim = Console.ReadLine();

            var kitapManager = new KitapManager<Kitap>();
            List<Kitap> raporListesi;

            switch (secim)
            {
                case "1":
                    raporListesi = kitapManager.EnSonEklenenOnKitap();
                    RaporListesiniYazdir(raporListesi);
                    break;
                case "2":
                    Console.Write("Yayınevi Adı Giriniz: ");
                    string yayineviAdi = Console.ReadLine();
                    raporListesi = kitapManager.YayinEvlerineGoreKitaplar(yayineviAdi);
                    RaporListesiniYazdir(raporListesi);
                    break;
                case "3":
                    raporListesi = kitapManager.SatisiDurdurulanKitaplar();
                    RaporListesiniYazdir(raporListesi);
                    break;
                case "4":
                    raporListesi = kitapManager.FiyatinaGoreKitaplar();
                    RaporListesiniYazdir(raporListesi);
                    break;
                default:
                    Console.WriteLine("Geçersiz seçim!");
                    break;
            }
        }

        public static void YayineviEkle()
        {
            Console.WriteLine("Yeni Yayınevi Ekleme Ekranı");
            Console.Write("Yayınevi Adı: ");
            var yayineviAdi = Console.ReadLine();
            Console.Write("Adres: ");
            var adres = Console.ReadLine();

            var yayinevi = new Yayinevi
            {
                YayineviAdi = yayineviAdi,
                Adres = adres
            };

            var yayineviManager = new YayineviManager<Yayinevi>();
            yayineviManager.Ekle(yayinevi);
            Console.WriteLine("Yayınevi başarıyla eklendi!");
        }

        public static void YayineviGuncelle()
        {
            Console.WriteLine("Yayınevi Güncelleme Ekranı");
            Console.Write("Güncellenecek Yayınevi ID: ");
            int id = int.Parse(Console.ReadLine());

            var yayineviManager = new YayineviManager<Yayinevi>();
            var yayinevi = yayineviManager.Bul(id);

            if (yayinevi == null)
            {
                Console.WriteLine("Yayınevi bulunamadı!");
                return;
            }

            Console.Write("Yeni Yayınevi Adı (Mevcut: " + yayinevi.YayineviAdi + "): ");
            yayinevi.YayineviAdi = Console.ReadLine();
            Console.Write("Yeni Adres (Mevcut: " + yayinevi.Adres + "): ");
            yayinevi.Adres = Console.ReadLine();

            yayineviManager.Guncelle(yayinevi);
            Console.WriteLine("Yayınevi başarıyla güncellendi!");
        }

        public static void YayineviSil()
        {
            Console.WriteLine("Yayınevi Silme Ekranı");
            Console.Write("Silinecek Yayınevi ID: ");
            int id = int.Parse(Console.ReadLine());

            var yayineviManager = new YayineviManager<Yayinevi>();
            yayineviManager.Sil(id);
            Console.WriteLine("Yayınevi başarıyla silindi!");
        }

        public static void YayinevleriniListele()
        {
            var yayineviManager = new YayineviManager<Yayinevi>();
            var yayinevleri = yayineviManager.Listele();
            foreach (var yayinevi in yayinevleri)
            {
                Console.WriteLine($"ID: {yayinevi.YayinEviID}, Adı: {yayinevi.YayineviAdi}, Adres: {yayinevi.Adres}");
            }
        }

        public static void YayineviAra()
        {
            Console.Write("Aranacak Yayınevi ID: ");
            int yayinEviId = Convert.ToInt32(Console.ReadLine()); 
            YayineviManager<Yayinevi> yayineviManager = new YayineviManager<Yayinevi>();
            Yayinevi yayinevi = yayineviManager.Bul(yayinEviId);

            if (yayinevi != null)
            {
                Console.WriteLine($"ID: {yayinevi.YayinEviID}, Adı: {yayinevi.YayineviAdi}, Adres: {yayinevi.Adres}");
            }
            else
            {
                Console.WriteLine("YayinEvi bulunamadı.");
            }
        }

        public static void KullaniciEkle()
        {
            Console.WriteLine("Yeni Kullanıcı Ekleme Ekranı");
            Console.Write("Ad: ");
            var ad = Console.ReadLine();
            Console.Write("Soyad: ");
            var soyad = Console.ReadLine();
            Console.Write("Kullanıcı Adı: ");
            var kullaniciAdi = Console.ReadLine();
            Console.Write("Şifre: ");
            var sifre = Console.ReadLine();

            var kullanici = new Kullanici
            {
                Ad = ad,
                Soyad = soyad,
                KullaniciAdi = kullaniciAdi,
                Sifre = sifre
            };

            var kullaniciManager = new KullaniciManager<Kullanici>();
            kullaniciManager.Ekle(kullanici);
            Console.WriteLine("Kullanıcı başarıyla eklendi!");
        }

        public static void KullaniciGuncelle()
        {
            Console.WriteLine("Kullanıcı Güncelleme Ekranı");
            Console.Write("Güncellenecek Kullanıcı ID: ");
            int id = int.Parse(Console.ReadLine());

            var kullaniciManager = new KullaniciManager<Kullanici>();
            var kullanici = kullaniciManager.Bul(id);

            if (kullanici == null)
            {
                Console.WriteLine("Kullanıcı bulunamadı!");
                return;
            }

            Console.Write("Yeni Ad (Mevcut: " + kullanici.Ad + "): ");
            kullanici.Ad = Console.ReadLine();
            Console.Write("Yeni Soyad (Mevcut: " + kullanici.Soyad + "): ");
            kullanici.Soyad = Console.ReadLine();

            kullaniciManager.Guncelle(kullanici);
            Console.WriteLine("Kullanıcı başarıyla güncellendi!");
        }

        public static void KullaniciSil()
        {
            Console.WriteLine("Kullanıcı Silme Ekranı");
            Console.Write("Silinecek Kullanıcı ID: ");
            int id = int.Parse(Console.ReadLine());

            var kullaniciManager = new KullaniciManager<Kullanici>();
            kullaniciManager.Sil(id);
            Console.WriteLine("Kullanıcı başarıyla silindi!");
        }

        public static void KullanicilariListele()
        {
            Console.WriteLine("Kullanıcı Listeleme Ekranı");
            var kullaniciManager = new KullaniciManager<Kullanici>();
            var kullanicilar = kullaniciManager.Listele();
            foreach (var kullanici in kullanicilar)
            {
                Console.WriteLine($"ID: {kullanici.KullaniciID}, Adı: {kullanici.Ad}, Soyadı: {kullanici.Soyad}");
            }
        }

        public static void KullaniciAra()
        {
            Console.Write("Aranacak Kullanıcı ID: ");
            int kullaniciId = Convert.ToInt32(Console.ReadLine());
            KullaniciManager<Kullanici> kullaniciManager = new KullaniciManager<Kullanici>();
            Kullanici kullanici = kullaniciManager.Bul(kullaniciId);

            if (kullanici != null)
            {
                Console.WriteLine($"ID: {kullanici.KullaniciID}, Ad: {kullanici.Ad}, Soyad: {kullanici.Soyad}");
            }
            else
            {
                Console.WriteLine("YayinEvi bulunamadı.");
            }
        }
    }
}
