using ismailemregungorAlbumDukkani.Data;
using ismailemregungorAlbumDukkani.Enums;
using ismailemregungorAlbumDukkani.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ismailemregungorAlbumDukkani.Utilities
{
    public static class Utility
    {
        // SifrePolitikasiKontrol metodu, bir şifrenin belirtilen politikaya uygun olup olmadığını kontrol eder.
        public static bool SifrePolitikasiKontrol(string sifre)
        {
            return sifre.Length >= 8;
        }

        // HashPassword metodu, verilen bir şifreyi güvenli bir şekilde karmaşık bir özet haline getirir.
        public static string HashPassword(string password)
        {
            using (SHA256 hash = SHA256.Create())
            {
                return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(password)).Select(l => l.ToString("X2")));
            }
        }

        // GirisYap metodu, kullanıcıdan kullanıcı adı ve şifre alarak giriş yapmayı denetler.
        public static bool GirisYap()
        {
            Console.Write("Kullanıcı Adı: ");
            string kullaniciAdi = Console.ReadLine();
            Console.Write("Şifre: ");
            string sifre = Console.ReadLine();

            var kullaniciManager = new KullaniciManager<Kullanici>();
            var kullanici = kullaniciManager.BulKullaniciAdiIle(kullaniciAdi);
            var hashedPassword = HashPassword(sifre);

            if (kullanici != null && hashedPassword == kullanici.Sifre)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Kullanıcı adı veya şifre hatalı.");
                return false;
            }
        }

        // MenuGoster metodu, kullanıcıya ana menüyü gösterir ve seçilen işlemi yönlendirir.
        public static bool MenuGoster()
        {
            Console.WriteLine("\n1. Kullanici İşlemleri");
            Console.WriteLine("2. Sanatci İşlemleri");
            Console.WriteLine("3. Albüm İşlemleri");
            Console.WriteLine("4. Albüm Raporları");
            Console.WriteLine("5. Çıkış Yap");
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
                    AlbumRaporlari();
                    break;
                case "5":
                    return true;
                default:
                    Console.WriteLine("Geçersiz seçim!");
                    break;
            }
            return false;
        }

        // KullaniciMenu metodu, kullanıcı işlemleri alt menüsünü gösterir ve seçilen işlemi yönlendirir.
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

        // KullaniciEkle metodu, kullanıcıdan yeni bir kullanıcı bilgisi alarak veritabanına ekler.
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
            Console.Write("Şifre Tekrar: ");
            var sifreTekrari = Console.ReadLine();

            var kullaniciManager = new KullaniciManager<Kullanici>();

            var mevcutKullanici = kullaniciManager.BulKullaniciAdiIle(kullaniciAdi);
            if (mevcutKullanici != null)
            {
                Console.WriteLine("Bu kullanıcı adı zaten alınmış.");
                return;
            }

            if (sifre != sifreTekrari)
            {
                Console.WriteLine("Şifreler eşleşmiyor.");
                return;
            }
            if (!SifrePolitikasiKontrol(sifre))
            {
                Console.WriteLine("Şifre belirtilen kriterlere uymuyor.");
                return;
            }

            var hashedPassword = HashPassword(sifre);
            
            var kullanici = new Kullanici
            {
                Ad = ad,
                Soyad = soyad,
                KullaniciAdi = kullaniciAdi,
                Sifre = hashedPassword
            };

            kullaniciManager.Ekle(kullanici);
            Console.WriteLine("Kullanıcı başarıyla eklendi!");
        }

        // KullaniciGuncelle metodu, kullanıcının bilgilerini güncellemek için kullanılır.
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

            Console.Write("Yeni Kullanici Adi (Mevcut: " + kullanici.KullaniciAdi + "): ");
            kullanici.KullaniciAdi = Console.ReadLine();

            Console.Write("Yeni Şifre (boş bırakırsanız şifre değişmeyecek): ");
            string yeniSifre = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(yeniSifre))
            {
                if (SifrePolitikasiKontrol(yeniSifre))
                {
                    kullanici.Sifre = HashPassword(yeniSifre);
                }
                else
                {
                    Console.WriteLine("Yeni şifre belirtilen kriterlere uymuyor.");
                    return;
                }
            }
            kullaniciManager.Guncelle(kullanici);
            Console.WriteLine("Kullanıcı başarıyla güncellendi!");
        }

        // KullaniciSil metodu, belirtilen kullanıcıyı veritabanından siler.
        public static void KullaniciSil()
        {
            Console.WriteLine("Kullanıcı Silme Ekranı");
            Console.Write("Silinecek Kullanıcı ID: ");
            int id = int.Parse(Console.ReadLine());

            var kullaniciManager = new KullaniciManager<Kullanici>();
            kullaniciManager.Sil(id);
            Console.WriteLine("Kullanıcı başarıyla silindi!");
        }

        // KullanicilariListele metodu, tüm kullanıcıları listeler.
        public static void KullanicilariListele()
        {
            Console.WriteLine("Kullanıcı Listeleme Ekranı");
            var kullaniciManager = new KullaniciManager<Kullanici>();
            var kullanicilar = kullaniciManager.Listele().OrderBy(k=>k.KullaniciID);
            foreach (var kullanici in kullanicilar)
            {
                Console.WriteLine($"Kullanici ID: {kullanici.KullaniciID}, Kullanici Adı: {kullanici.Ad}, Kullanici Soyadı: {kullanici.Soyad}");
            }
        }

        // KullaniciAra metodu, belirtilen kullanıcı ID'sine sahip kullanıcıyı arar ve bilgilerini gösterir.
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
                Console.WriteLine("Kullanici bulunamadı.");
            }
        }

        // SanatciMenu metodu, sanatçı işlemleri menüsünü görüntüler ve kullanıcının seçim yapmasını sağlar.
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

        // SanatciEkle metodu, yeni bir sanatçı ekler.
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
            Console.WriteLine("Sanatci başarıyla eklendi!");
        }

        // SanatciGuncelle metodu, belirtilen sanatçının bilgilerini günceller.
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

        // SanatciSil metodu, belirtilen sanatçıyı veritabanından siler.
        public static void SanatciSil()
        {
            Console.WriteLine("Sanatci Silme Ekranı");
            Console.Write("Silinecek Sanatci ID: ");
            int id = int.Parse(Console.ReadLine());

            var sanatciManager = new SanatciManager<Sanatci>();
            sanatciManager.Sil(id);
            Console.WriteLine("Sanatci başarıyla silindi!");
        }

        // SanatciListele metodu, tüm sanatçıları listeler.
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

        // SanatciAra metodu, belirtilen sanatçı ID'sine sahip sanatçıyı arar ve bilgilerini gösterir.
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

        // AlbumMenu metodu, albüm işlemleri menüsünü görüntüler ve kullanıcının seçim yapmasını sağlar.
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

        // AlbumEkle metodu, yeni bir albüm ekler.
        public static void AlbumEkle()
        {
            Console.WriteLine("Yeni Albüm Ekleme Ekranı");
            Console.Write("Albüm Adı: ");
            var albumAdi = Console.ReadLine();
            Console.Write("Albüm Fiyat: ");
            var fiyat = double.Parse(Console.ReadLine());
            Console.Write("Sanatci ID: ");
            var sanatciID = int.Parse(Console.ReadLine());
            Console.Write("İndirim Oranı (% cinsinden, indirim yoksa boş bırakın): ");
            string indirimInput = Console.ReadLine();
            double? indirimOrani = string.IsNullOrWhiteSpace(indirimInput) ? null : double.Parse(indirimInput);

            var album = new Album
            {
                AlbumAdi = albumAdi,
                Fiyat = fiyat,
                YayimTarihi = DateTime.Now,
                SanatciID = sanatciID,
                AlbumDurumu = AlbumDurumu.Aktif,
                IndirimOrani = indirimOrani
            };

            var albumManager = new AlbumManager<Album>();
            albumManager.Ekle(album);
            Console.WriteLine("Albüm başarıyla eklendi!");
        }

        // AlbumGuncelle metodu, belirtilen albümün bilgilerini günceller.
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

            Console.Write("Yeni İndirim Oranı (Mevcut: " + album.IndirimOrani + "): ");
            Console.Write("İndirim Oranı (% cinsinden, indirim yoksa 0 girin): ");
            album.IndirimOrani = double.Parse(Console.ReadLine());

            Console.WriteLine("Yeni Durum (1-Aktif, 2-Pasif): ");
            album.AlbumDurumu = (Console.ReadLine() == "1") ? AlbumDurumu.Aktif : AlbumDurumu.Pasif;

            Console.Write("Yeni Sanatci ID (Mevcut: " + album.SanatciID + "): ");
            album.SanatciID = int.Parse(Console.ReadLine());

            albumManager.Guncelle(album);
            Console.WriteLine("Album başarıyla güncellendi!");
        }

        // AlbumSil metodu, belirtilen albümü veritabanından siler.
        public static void AlbumSil()
        {
            Console.WriteLine("Album Silme Ekranı");
            Console.Write("Silinecek Album ID: ");
            var albumId = int.Parse(Console.ReadLine());

            var albumManager = new AlbumManager<Album>();
            albumManager.Sil(albumId);
            Console.WriteLine("Album başarıyla silindi!");
        }

        // AlbumListele metodu, tüm albümleri listeler.
        public static void AlbumListele()
        {
            Console.WriteLine("Album Listeleme Ekranı");
            var albumManager = new AlbumManager<Album>();
            var albumler = albumManager.ListeleJoin("Sanatci").OrderBy(x => x.AlbumID);

            foreach (var album in albumler)
            {
                Console.WriteLine($"Album ID: {album.AlbumID}, Album Adı: {album.AlbumAdi}, Album Fiyat: {album.Fiyat}, Album Durumu: {album.AlbumDurumu}, Sanatci ID: {album.Sanatci.SanatciID} Sanatci Adi: {album.Sanatci.SanatciAdi}");
            }
        }

        // AlbumAra meteodu, belirtilen albüm ID'sine sahip albümü arar ve bilgilerini gösterir.
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

        // AlbumIndirimOraninaGoreYazdir metodu, albüm adı, sanatçı adı ve indirim oranını listeleyen bir rapor oluşturur.
        public static void AlbumIndirimOraninaGoreYazdir(List<Album> albumler)
        {
            foreach (var album in albumler)
            {
                var sanatciAdi = album.Sanatci != null ? album.Sanatci.SanatciAdi : "Sanatci Bilgisi Yok";
                Console.WriteLine($"Adı: {album.AlbumAdi}, Sanatci: {sanatciAdi} İndirim Oranı: {album.IndirimOrani}");
            }
        }

        // AlbumSatisDurumunaGoreYazdir metodu, albüm adı, sanatçı adı ve albüm durumunu listeleyen bir rapor oluşturur.
        public static void AlbumSatisDurumunaGoreYazdir(List<Album> albumler)
        {
            foreach (var album in albumler)
            {
                var sanatciAdi = album.Sanatci != null ? album.Sanatci.SanatciAdi : "Sanatci Bilgisi Yok";
                Console.WriteLine($"Adı: {album.AlbumAdi}, Sanatci: {sanatciAdi} Albüm Durumu: {album.AlbumDurumu}");
            }
        }

        // AlbumTariheGoreYazdir metodu, albüm adı, sanatçı adı ve yayın tarihini listeleyen bir rapor oluşturur.
        public static void AlbumTariheGoreYazdir(List<Album> albumler)
        {
            foreach (var album in albumler)
            {
                var sanatciAdi = album.Sanatci != null ? album.Sanatci.SanatciAdi : "Sanatci Bilgisi Yok";
                Console.WriteLine($"Adı: {album.AlbumAdi}, Sanatci: {sanatciAdi} Yayim Tarihi: {album.YayimTarihi}");
            }
        }

        // AlbumRaporlari metodu, farklı albüm raporlarını görüntülemek için bir menü sağlar.
        public static void AlbumRaporlari()
        {
            Console.WriteLine("Raporlar Ekranı");
            Console.WriteLine("1. Tüm Albümler");
            Console.WriteLine("2. Satışı Durmuş Albümler");
            Console.WriteLine("3. Satışı Devam Eden Albümler");
            Console.WriteLine("4. En Son Eklenen 10 Albüm");
            Console.WriteLine("5. İndirimdeki Albümler");
            Console.Write("Seçiminiz: ");
            var secim = Console.ReadLine();

            var albumManager = new AlbumManager<Album>();
            List<Album> raporListesi;

            switch (secim)
            {
                case "1":
                    AlbumListele();
                    break;
                case "2":
                    raporListesi = albumManager.SatisiDurmusAlbumler();
                    AlbumSatisDurumunaGoreYazdir(raporListesi);
                    break;
                case "3":
                    raporListesi = albumManager.SatisiDevamEdenAlbumler();
                    AlbumSatisDurumunaGoreYazdir(raporListesi);
                    break;
                case "4":
                    raporListesi = albumManager.EnSonEklenenOnAlbum();
                    AlbumTariheGoreYazdir(raporListesi);
                    break;
                case "5":
                    raporListesi = albumManager.IndirimdekiAlbumler();
                    AlbumIndirimOraninaGoreYazdir(raporListesi);
                    break;
                default:
                    Console.WriteLine("Geçersiz seçim!");
                    break;
            }
        }
    }
}
