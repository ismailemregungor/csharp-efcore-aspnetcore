/*
 * Soru:
 * A) 
 * Bir market için; çeşitli ürünlerin tutulduğu stok yönetimiyle ilgili bir uygulama geliştirilecektir.
 * Stokta tutulacak ürünler ise(Bulgur, KagitHavlu, Yumurta, SiseSut, Yogurt, Bardak)
 * Tüm bu ürünlerin raporlarının alındığı(stoktaki tüm ürünler)
 * Stoktaki bozuk ürünlerin listesi
 * Stoktaki kırık ürünlerin listesi
 * Stoktaki zamanı geçmiş olan ürünlerin listesi
 * Şeklinde raproları veren console uygulamasını C# dili OOP prensiplerine uygun yazınız.
 * (Class, Inheritance, Polyporphism gerekirse Abstraction StokYonetimini StokManager sınıfı yapmalı)
 */

using LessonTasks.StockManagement.Managers;
using LessonTasks.StockManagement.Models.Personel;
using LessonTasks.StokYonetimi.Managers;
using LessonTasks.StokYonetimi.Models;

//StokManager stokManager = new StokManager();

//while (true)
//{
//    Console.Clear();
//    Console.WriteLine("Stok Yönetimi Programı");
//    Console.WriteLine("1. Yumurta Ekle");
//    Console.WriteLine("2. Yogurt Ekle");
//    Console.WriteLine("3. Sise Sut Ekle");
//    Console.WriteLine("4. Kagit Havlu Ekle");
//    Console.WriteLine("5. Bulgur Ekle");
//    Console.WriteLine("6. Bardak Ekle");
//    Console.WriteLine("7. Tum Urunleri Listele");
//    Console.WriteLine("8. Bozuk Urunleri Listele");
//    Console.WriteLine("9. Kirik Urunleri Listele");
//    Console.WriteLine("10. Son Kullanma Tarihi Gecmis Urunleri Listele");
//    Console.WriteLine("11. Deforme Olan Urunleri Listele");
//    Console.WriteLine("12. Cikis");
//    Console.Write("Seciminizi yapin: ");

//    string secim = Console.ReadLine();

//    switch (secim)
//    {
//        case "1":
//            Yumurta yumurta = UrunEkle<Yumurta>("Yumurta");
//            stokManager.UrunEkle(yumurta);
//            break;
//        case "2":
//            Yogurt yogurt = UrunEkle<Yogurt>("Yogurt");
//            stokManager.UrunEkle(yogurt);
//            break;
//        case "3":
//            SiseSut siseSut = UrunEkle<SiseSut>("Sise Sut");
//            stokManager.UrunEkle(siseSut);
//            break;
//        case "4":
//            KagitHavlu kagitHavlu = UrunEkle<KagitHavlu>("Kagit Havlu");
//            stokManager.UrunEkle(kagitHavlu);
//            break;
//        case "5":
//            Bulgur bulgur = UrunEkle<Bulgur>("Bulgur");
//            stokManager.UrunEkle(bulgur);
//            break;
//        case "6":
//            Bardak bardak = UrunEkle<Bardak>("Bardak");
//            stokManager.UrunEkle(bardak);
//            break;
//        case "7":
//            List<Urun> tumUrunler = stokManager.TumUrunleriGetir();
//            UrunleriListele(tumUrunler);
//            break;
//        //case "8":
//        //    List<Urun> bozukUrunler = stokManager.BozukUrunleriGetir();
//        //    UrunleriListele(bozukUrunler);
//        //    break;
//        //case "9":
//        //    List<Urun> kirikUrunler = stokManager.KirikUrunleriGetir();
//        //    UrunleriListele(kirikUrunler);
//        //    break;
//        case "10":
//            Console.Write("Tarih girin (yyyy-MM-dd): ");
//            if (DateTime.TryParse(Console.ReadLine(), out DateTime tarih))
//            {
//                List<Urun> gecmisUrunler = stokManager.SonKullanmaTarihiGecmisUrunleriGetir(tarih);
//                UrunleriListele(gecmisUrunler);
//            }
//            else
//            {
//                Console.WriteLine("Geçersiz tarih formatı.");
//            }
//            break;
//        //case "11":
//        //    List<Urun> deformeliUrunler = stokManager.DeformeOlmusUrunleriGetir();
//        //    UrunleriListele(deformeliUrunler);
//        //    break;
//        case "12":
//            Environment.Exit(0);
//            break;
//        default:
//            Console.WriteLine("Geçersiz seçim. Lütfen tekrar deneyin.");
//            break;
//    }

//    Console.WriteLine("Devam etmek için bir tuşa basın...");
//    Console.ReadKey();
//}


//    static T UrunEkle<T>(string urunAdi) where T : Urun
//{
//    Console.Write($"{urunAdi} için ürün ID girin: ");
//    int urunId;
//    if (!int.TryParse(Console.ReadLine(), out urunId))
//    {
//        Console.WriteLine("Geçersiz ID formatı. Ürün eklenemedi.");
//        return null;
//    }

//    Console.Write($"{urunAdi} için son kullanma tarihini girin (yyyy-MM-dd): ");
//    if (DateTime.TryParse(Console.ReadLine(), out DateTime sonKullanmaTarihi))
//    {
//        return (T)Activator.CreateInstance(typeof(T), sonKullanmaTarihi, urunId, urunAdi);
//    }
//    else
//    {
//        Console.WriteLine("Geçersiz tarih formatı. Ürün eklenemedi.");
//        return null;
//    }
//}

//static void UrunleriListele(List<Urun> urunler)
//{
//    if (urunler.Count == 0)
//    {
//        Console.WriteLine("Listelenecek ürün bulunamadı.");
//    }
//    else
//    {
//        Console.WriteLine("Urunler:");
//        foreach (var urun in urunler)
//        {
//            Console.WriteLine($"ID: {urun.UrunId}, Ad: {urun.UrunAdi}");
//        }
//    }
//}

/*
 * B)
 * Markette çalışan personellerin verilerini tutan kısmıda geliştiriniz.
 * Çalışanlar tam zamanlı ve yarı zamanlı olarak çalışabilmektedir.
 * Personellerin bilgilerini console ekranı üzerinden raporlayabilmeliyiz.
 * yarı zamanlı calisanlarin saatlik ucretleri ve kaç saat çalıştıkları tutulmali...
 */

MarketManager marketManager = new MarketManager();
marketManager.PersonelManager.Baslat();
marketManager.StokManager.Deneme();


