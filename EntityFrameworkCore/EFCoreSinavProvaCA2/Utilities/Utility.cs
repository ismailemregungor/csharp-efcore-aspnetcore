using EFCoreSinavProvaCA2.Data;
using EFCoreSinavProvaCA2.Enums;
using EFCoreSinavProvaCA2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreSinavProvaCA2.Utilities
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
            // ilk kez giriş yapmak için Kullanici_CFG'de oluşturduğum
            var password = sifre;
            var hashedPassword = HashPassword(sifre);

            if (kullanici != null && hashedPassword == kullanici.Sifre || password == kullanici.Sifre)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Kullanıcı adı veya şifre hatalı.");
                return false;
            }
        }
        public static bool MenuGoster()
        {
            Console.WriteLine("\n1. Kullanici İşlemleri");
            Console.WriteLine("2. Sanatci İşlemleri");
            Console.WriteLine("3. Albüm İşlemleri");
            Console.WriteLine("4. Sarki İşlemleri");
            Console.WriteLine("5. Albüm Raporları");
            Console.WriteLine("6. Çıkış Yap");
            Console.Write("\nSeçiminiz: ");
            var secim = Console.ReadLine();
            switch (secim)
            {
                case "1":
                    KullaniciMenu();
                    break;
                case "2":
                    SanatciMenu();
                    break;
                case "3":
                    AlbumMenu();
                    break;
                case "4":
                    SarkiMenu();
                    break;
                case "5":
                    AlbumRaporlari();
                    break;
                case "6":
                    return true;
                default:
                    Console.WriteLine("Geçersiz seçim!");
                    break;
            }
            return false;
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

        public static string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
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

            // Şifre kısıtlamalarını kontrol et
            if (sifre.Length < 5 || !sifre.Any(char.IsUpper) || !sifre.Any(char.IsDigit) || !sifre.Any(ch => !char.IsLetterOrDigit(ch)))
            {
                Console.WriteLine("Şifre en az 5 karakter uzunluğunda olmalı, bir büyük harf, bir rakam ve bir özel karakter içermelidir.");
                return;
            }

            var hashedPassword = HashPassword(sifre);

            var kullanici = new Kullanici
            {
                Ad = ad,
                Soyad = soyad,
                KullaniciAdi = kullaniciAdi,
                Sifre = hashedPassword // Şifreyi hash'lenmiş haliyle kaydet
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

            // Şifre güncellemesi için ek güvenlik önlemleri ekleyin
            Console.Write("Yeni Şifre (Yeni şifre girmek istemiyorsanız boş bırakın): ");
            string yeniSifre = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(yeniSifre))
            {
                if (yeniSifre.Length < 5 || !yeniSifre.Any(char.IsUpper) || !yeniSifre.Any(char.IsDigit) || !yeniSifre.Any(ch => !char.IsLetterOrDigit(ch)))
                {
                    Console.WriteLine("Şifre en az 5 karakter uzunluğunda olmalı, bir büyük harf, bir rakam ve bir özel karakter içermelidir.");
                    return;
                }
                else
                {
                    // Eğer şifre politikalarına uygunsa, şifreyi hash'leyin ve güncelleyin
                    kullanici.Sifre = HashPassword(yeniSifre);
                }
            }

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
                Console.WriteLine($"Kullanici ID: {kullanici.KullaniciID}, Kullanici Adı: {kullanici.Ad}, Kullanici Soyadı: {kullanici.Soyad}");
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
                Console.WriteLine($"Kullanici ID: {kullanici.KullaniciID}, Kullanici Ad: {kullanici.Ad}, Kullanici Soyad: {kullanici.Soyad}");
            }
            else
            {
                Console.WriteLine("YayinEvi bulunamadı.");
            }
        }

        public static void SanatciMenu()
        {
            Console.WriteLine("Sanatci İşlemleri Menüsü");
            Console.WriteLine("1. Sanatci Ekle");
            Console.WriteLine("2. Sanatci Güncelle");
            Console.WriteLine("3. Sanatci Sil");
            Console.WriteLine("4. Sanatci Listele");
            Console.WriteLine("5. Sanatci Ara");
            Console.WriteLine("6. Ana Menüye Dön");
            Console.Write("\nSeçiminiz: ");
            var secim = Console.ReadLine();
            switch (secim)
            {
                case "1":
                    SanatciEkle();
                    break;
                case "2":
                    SanatciGuncelle();
                    break;
                case "3":
                    SanatciSil();
                    break;
                case "4":
                    SanatciListele();
                    break;
                case "5":
                    SanatciAra();
                    break;
                case "6":
                    return;
                default:
                    Console.WriteLine("Geçersiz seçim!");
                    break;
            }
        }

        public static void SanatciEkle()
        {
            Console.WriteLine("Yeni Sanatci Ekleme Ekranı");
            Console.Write("Sanatci Adı: ");
            var sanatciAdi = Console.ReadLine();

            var sanatci = new Sanatci
            {
                SanatciAdi = sanatciAdi,
            };

            var sanatciManager = new SanatciManager<Sanatci>();
            sanatciManager.Ekle(sanatci);
            Console.WriteLine("Sanatçi başarıyla eklendi!");
        }

        public static void SanatciGuncelle()
        {
            Console.WriteLine("Sanatci Güncelleme Ekranı");
            Console.Write("Güncellenecek Sanatci ID: ");
            int id = int.Parse(Console.ReadLine());

            var sanatciManager = new SanatciManager<Sanatci>();
            var sanatci = sanatciManager.Bul(id);

            if (sanatci == null)
            {
                Console.WriteLine("Sanatci bulunamadı!");
                return;
            }

            Console.Write("Yeni Sanatci Adı (Mevcut: " + sanatci.SanatciAdi + "): ");
            sanatci.SanatciAdi = Console.ReadLine();

            sanatciManager.Guncelle(sanatci);
            Console.WriteLine("Sanatci başarıyla güncellendi!");
        }

        public static void SanatciSil()
        {
            Console.WriteLine("Sanatci Silme Ekranı");
            Console.Write("Silinecek Sanatci ID: ");
            int id = int.Parse(Console.ReadLine());

            var sanatciManager = new SanatciManager<Sanatci>();
            sanatciManager.Sil(id);
            Console.WriteLine("Yayınevi başarıyla silindi!");
        }

        public static void SanatciListele()
        {
            Console.WriteLine("Sanatci Listeleme Ekranı");
            var sanatciManager = new SanatciManager<Sanatci>();
            var sanatcilar = sanatciManager.Listele();
            foreach (var sanatci in sanatcilar)
            {
                Console.WriteLine($"Sanatci ID: {sanatci.SanatciID}, Sanatci Adı: {sanatci.SanatciAdi}");
            }
        }

        public static void SanatciAra()
        {
            Console.Write("Aranacak Sanatci ID: ");
            int yayinEviId = Convert.ToInt32(Console.ReadLine());
            var sanatciManager = new SanatciManager<Sanatci>();
            Sanatci sanatci = sanatciManager.Bul(yayinEviId);

            if (sanatci != null)
            {
                Console.WriteLine($"Sanatci ID: {sanatci.SanatciID}, Sanatci Adı: {sanatci.SanatciAdi}");
            }
            else
            {
                Console.WriteLine("Sanatci bulunamadı.");
            }
        }

        public static void AlbumMenu()
        {
            Console.WriteLine("Albüm İşlemleri Menüsü");
            Console.WriteLine("1. Albüm Ekle");
            Console.WriteLine("2. Albüm Güncelle");
            Console.WriteLine("3. Albüm Sil");
            Console.WriteLine("4. Albüm Listele");
            Console.WriteLine("5. Albüm Ara");
            Console.WriteLine("6. Ana Menüye Dön");
            Console.Write("\nSeçiminiz: ");
            var secim = Console.ReadLine();
            switch (secim)
            {
                case "1":
                    AlbumEkle();
                    break;
                case "2":
                    AlbumGuncelle();
                    break;
                case "3":
                    AlbumSil();
                    break;
                case "4":
                    AlbumListele();
                    break;
                case "5":
                    AlbumAra();
                    break;
                case "6":
                    return;
                default:
                    Console.WriteLine("Geçersiz seçim!");
                    break;
            }
        }

        public static void AlbumEkle()
        {
            Console.WriteLine("Yeni Albüm Ekleme Ekranı");
            Console.Write("Albüm Adı: ");
            var albumAdi = Console.ReadLine();
            Console.Write("Albüm Fiyat: ");
            var fiyat = double.Parse(Console.ReadLine());
            Console.Write("Sanatci ID: ");
            var sanatciID = int.Parse(Console.ReadLine());

            var album = new Album
            {
                AlbumAdi = albumAdi,
                Fiyat = fiyat,
                YayimTarihi = DateTime.Now,
                SanatciID = sanatciID,
                AlbumDurumu = AlbumDurumu.Aktif
            };

            var albumManager = new AlbumManager<Album>();
            albumManager.Ekle(album);
            Console.WriteLine("Album başarıyla eklendi!");
        }

        public static void AlbumGuncelle()
        {
            Console.WriteLine("Album Güncelleme Ekranı");
            Console.Write("Güncellenecek Album ID: ");
            var albumId = int.Parse(Console.ReadLine());

            var albumManager = new AlbumManager<Album>();
            var album = albumManager.Bul(albumId);
            if (album == null)
            {
                Console.WriteLine("Album bulunamadı!");
                return;
            }

            Console.Write("Yeni Album Adı (Mevcut: " + album.AlbumAdi + "): ");
            album.AlbumAdi = Console.ReadLine();
            Console.Write("Yeni Fiyat (Mevcut: " + album.Fiyat + "): ");
            album.Fiyat = double.Parse(Console.ReadLine());
            Console.Write("Yeni Sanatci ID (Mevcut: " + album.SanatciID + "): ");
            album.SanatciID = int.Parse(Console.ReadLine());
            Console.WriteLine("Yeni Durum (1-Aktif, 2-Pasif): ");
            album.AlbumDurumu = (Console.ReadLine() == "1") ? AlbumDurumu.Aktif : AlbumDurumu.Pasif;

            albumManager.Guncelle(album);
            Console.WriteLine("Album başarıyla güncellendi!");
        }

        public static void AlbumSil()
        {
            Console.WriteLine("Album Silme Ekranı");
            Console.Write("Silinecek Album ID: ");
            var albumId = int.Parse(Console.ReadLine());

            var albumManager = new AlbumManager<Album>();
            albumManager.Sil(albumId);
            Console.WriteLine("Album başarıyla silindi!");
        }

        public static void AlbumListele()
        {
            Console.WriteLine("Album Listeleme Ekranı");
            var albumManager = new AlbumManager<Album>();
            var albumler = albumManager.ListeleJoin("Sanatci").OrderBy(x=>x.AlbumID);

            foreach (var album in albumler)
            {
                Console.WriteLine($"Album ID: {album.AlbumID}, Album Adı: {album.AlbumAdi}, Album Fiyat: {album.Fiyat}, Album Durumu: {album.AlbumDurumu}, Sanatci ID: {album.Sanatci.SanatciID} Sanatci Adi: {album.Sanatci.SanatciAdi}");
            }
        }

        public static void AlbumAra()
        {
            Console.WriteLine("Album Arama Ekranı");
            Console.Write("Aranacak Album ID: ");
            int albumId = Convert.ToInt32(Console.ReadLine());
            var albumManager = new AlbumManager<Album>();
            Album album = albumManager.Bul(albumId);

            if (album != null)
            {
                Console.WriteLine($"Album ID: {album.AlbumID}, Album Adı: {album.AlbumAdi}, Album Fiyat: {album.Fiyat}, Album Durumu: {album.AlbumDurumu}");
            }
            else
            {
                Console.WriteLine("Album bulunamadı.");
            }
        }

        public static void SarkiMenu()
        {
            Console.WriteLine("Sarki İşlemleri Menüsü");
            Console.WriteLine("1. Sarki Ekle");
            Console.WriteLine("2. Sarki Güncelle");
            Console.WriteLine("3. Sarki Sil");
            Console.WriteLine("4. Sarki Listele");
            Console.WriteLine("5. Sarki Ara");
            Console.WriteLine("6. Ana Menüye Dön");
            Console.Write("\nSeçiminiz: ");
            var secim = Console.ReadLine();
            switch (secim)
            {
                case "1":
                    SarkiEkle();
                    break;
                case "2":
                    SarkiGuncelle();
                    break;
                case "3":
                    SarkiSil();
                    break;
                case "4":
                    SarkiListele();
                    break;
                case "5":
                    SarkiAra();
                    break;
                case "6":
                    return;
                default:
                    Console.WriteLine("Geçersiz seçim!");
                    break;
            }
        }

        public static void SarkiEkle()
        {
            Console.WriteLine("Yeni Sarki Ekleme Ekranı");
            Console.Write("Sarki Adı: ");
            var sarkiAdi = Console.ReadLine();
            Console.Write("Album ID: ");
            var albumID = int.Parse(Console.ReadLine());

            var sarki = new Sarki
            {
                SarkiAdi = sarkiAdi,
                AlbumId = albumID,
            };
            var sarkiManager = new SarkiManager<Sarki>();
            sarkiManager.Ekle(sarki);
            Console.WriteLine("Sarki başarıyla eklendi!");
        }

        public static void SarkiGuncelle()
        {
            Console.WriteLine("Sarki Güncelleme Ekranı");
            Console.Write("Güncellenecek Sarki ID: ");
            var sarkiId = int.Parse(Console.ReadLine());

            var sarkiManager = new SarkiManager<Sarki>();
            var sarki = sarkiManager.Bul(sarkiId);
            if (sarki == null)
            {
                Console.WriteLine("Sarki bulunamadı!");
                return;
            }

            Console.Write("Yeni Sarki Adı (Mevcut: " + sarki.SarkiAdi + "): ");
            sarki.SarkiAdi = Console.ReadLine();
            Console.Write("Yeni Album ID (Mevcut: " + sarki.SarkiID + "): ");
            sarki.AlbumId = int.Parse(Console.ReadLine());

            sarkiManager.Guncelle(sarki);
            Console.WriteLine("Sarki başarıyla güncellendi!");
        }

        public static void SarkiSil()
        {
            Console.WriteLine("Sarki Silme Ekranı");
            Console.Write("Silinecek Sarki ID: ");
            var sarkiId = int.Parse(Console.ReadLine());

            var sarkiManager = new SarkiManager<Sarki>();
            sarkiManager.Sil(sarkiId);
            Console.WriteLine("Sarki başarıyla silindi!");
        }

        public static void SarkiListele()
        {
            Console.WriteLine("Sarki Listeleme Ekranı");
            var sarkiManager = new SarkiManager<Sarki>();
            var sarkilar = sarkiManager.ListeleJoin("Album");

            foreach (var sarki in sarkilar)
            {
                Console.WriteLine($"Sarki ID: {sarki.SarkiID}, Sarki Adı: {sarki.SarkiAdi}, Albüm ID: {sarki.Album.AlbumID}, Albüm Adi: {sarki.Album.AlbumAdi} /*Sanatci ID: {sarki.Album.Sanatci.SanatciID} Sanatci Adi: {sarki.Album.Sanatci.SanatciAdi}*/");
            }
        }

        public static void SarkiAra()
        {
            Console.WriteLine("Sarki Arama Ekranı");
            Console.Write("Aranacak Sarki ID: ");
            int sarkiId = Convert.ToInt32(Console.ReadLine());
            var sarkiManager = new SarkiManager<Sarki>();
            Sarki sarki = sarkiManager.Bul(sarkiId);

            if (sarki != null)
            {
                Console.WriteLine($"Sarki ID: {sarki.SarkiID}, Sarki Adı: {sarki.SarkiAdi}");
            }
            else
            {
                Console.WriteLine("Sarki bulunamadı.");
            }
        }

        public static void AlbumRaporYazdir(List<Album> albumler)
        {
            foreach (var album in albumler)
            {
                var sanatciAdi = album.Sanatci != null ? album.Sanatci.SanatciAdi : "Sanatci Bilgisi Yok";
                Console.WriteLine($"ID: {album.AlbumID}, Adı: {album.AlbumAdi}, Adı: {album.Fiyat}, Ekleme Tarihi: {album.YayimTarihi}, Durum: {album.AlbumDurumu}, Sanatci: {sanatciAdi}");
            }
        }

        public static void AlbumRaporlari()
        {
            Console.WriteLine("Raporlar Ekranı");
            Console.WriteLine("1. En Son Eklenen 10 Albüm");
            Console.WriteLine("2. Sanatçılara Göre Albümler");
            Console.WriteLine("3. Satışı Durdurulan Albümler");
            Console.WriteLine("4. Fiyatına Göre Albümler");
            Console.Write("Seçiminiz: ");
            var secim = Console.ReadLine();

            var albumManager = new AlbumManager<Album>();
            List<Album> raporListesi;

            switch (secim)
            {
                case "1":
                    raporListesi = albumManager.EnSonEklenenOnAlbum();
                    AlbumRaporYazdir(raporListesi);
                    break;
                case "2":
                    Console.Write("Sanatci Adı Giriniz: ");
                    string sanatciAdi = Console.ReadLine();
                    raporListesi = albumManager.SanatcilaraGoreAlbumler(sanatciAdi);
                    AlbumRaporYazdir(raporListesi);
                    break;
                case "3":
                    raporListesi = albumManager.SatisiDurdurulanAlbumler();
                    AlbumRaporYazdir(raporListesi);
                    break;
                case "4":
                    raporListesi = albumManager.FiyatinaGoreAlbumler();
                    AlbumRaporYazdir(raporListesi);
                    break;
                default:
                    Console.WriteLine("Geçersiz seçim!");
                    break;
            }
        }
    }
}
