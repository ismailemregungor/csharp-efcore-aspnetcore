using EFCoreModelFirst4.Data;
using EFCoreModelFirst4.Models;
using EFCoreModelFirst4.Services;

//UrunContext context = new UrunContext();

//var urunService = new UrunService();
//var kategoriService = new KategoriService();

////var kategoriler = new List<Kategori>
////            {
////                new Kategori {KategoriID = 1, KategoriAdi = "Elektronik" },
////                new Kategori {KategoriID = 2, KategoriAdi = "Kitap" },
////                new Kategori {KategoriID = 3, KategoriAdi = "Giyim" },
////                new Kategori {KategoriID = 4, KategoriAdi = "Gıda" },
////                new Kategori {KategoriID = 5, KategoriAdi = "Oyuncak" }
////            };

////context.Kategoriler.AddRange(kategoriler);
////context.SaveChanges();


////var urunler = new List<Urun>
////            {
////                new Urun { UrunAdi = "Laptop", UrunFiyati = 5000, KategoriID = 1 },
////                new Urun { UrunAdi = "Mouse", UrunFiyati = 150, KategoriID = 1 },
////                new Urun { UrunAdi = "Roman", UrunFiyati = 30, KategoriID = 2 },
////                new Urun { UrunAdi = "Bilim Kurgu Kitabı", UrunFiyati = 45, KategoriID = 2 },
////                new Urun { UrunAdi = "T-Shirt", UrunFiyati = 80, KategoriID = 3 },
////                new Urun { UrunAdi = "Pantolon", UrunFiyati = 200, KategoriID = 3 },
////                new Urun { UrunAdi = "Çikolata", UrunFiyati = 10, KategoriID = 4 },
////                new Urun { UrunAdi = "Peynir", UrunFiyati = 22, KategoriID = 4 },
////                new Urun { UrunAdi = "Oyuncak Araba", UrunFiyati = 150, KategoriID = 5 },
////                new Urun { UrunAdi = "Lego Seti", UrunFiyati = 250, KategoriID = 5 }
////            };

////context.Urunler.AddRange(urunler);
////context.SaveChanges();


//Console.WriteLine("Kategori Listesi");
//var kategoriler = kategoriService.GetAllKategoriler();
//foreach (var k in kategoriler)
//{
//    Console.WriteLine($"ID: {k.KategoriID}, Kategori Adı: {k.KategoriAdi}");
//}


//Console.WriteLine("Ürün Listesi");
//var urunler = urunService.GetAllUrunler();
//foreach (var u in urunler)
//{
//    Console.WriteLine($"ID: {u.UrunID}, Ürün Adı: {u.UrunAdi}, Fiyatı: {u.UrunFiyati}, Kategori: {u.Kategori.KategoriAdi}");
//}


//Console.WriteLine("Elektronik Kategorisindeki Ürünler");
//var elektronikUrunler = urunService.GetUrunlerByKategoriAdi("Elektronik");
//foreach (var u in elektronikUrunler)
//{
//    Console.WriteLine($"ID: {u.UrunID}, Ürün Adı: {u.UrunAdi}, Fiyatı: {u.UrunFiyati}");
//}


//Console.WriteLine("ID'ye Göre Ürün Getirme");
//var urun = urunService.GetUrunById(5); 
//if (urun != null)
//{
//    Console.WriteLine($"ID: {urun.UrunID}, Ürün Adı: {urun.UrunAdi}, Fiyatı: {urun.UrunFiyati}");
//}
//else
//{
//    Console.WriteLine("Aranan ürün bulunamadı!");
//}


////    Console.WriteLine("Ürün Güncelleme");
////var guncellenecekUrun = urunService.GetUrunById(1);
////if (guncellenecekUrun != null)
////{
////    guncellenecekUrun.UrunFiyati = 5500; 
////    urunService.UpdateUrun(guncellenecekUrun);
////    Console.WriteLine($"ID: {guncellenecekUrun.UrunID} olan ürün güncellendi.");
////}
////else
////{
////    Console.WriteLine("Güncellenecek ürün bulunamadı!");
////}


////Console.WriteLine("Ürün Silme");
////var silinecekUrunId = 10; 
////var silinecekUrun = urunService.GetUrunById(silinecekUrunId);
////if (silinecekUrun != null)
////{
////    urunService.DeleteUrun(silinecekUrunId);
////    Console.WriteLine($"ID: {silinecekUrunId} olan ürün silindi.");
////}
////else
////{
////    Console.WriteLine("Silinecek ürün bulunamadı!");
////}


var urunService = new UrunService();
var kategoriService = new KategoriService();

while (true)
{
    Console.WriteLine("\nLütfen bir işlem seçiniz:");
    Console.WriteLine("1: Ürün Ekle");
    Console.WriteLine("2: Ürün ID'ye Göre Listele");
    Console.WriteLine("3: Tüm Ürünleri Listele");
    Console.WriteLine("4: Kategoriye Göre Ürün Listele");
    Console.WriteLine("5: Ürün Güncelle");
    Console.WriteLine("6: Ürün Sil");
    Console.WriteLine("7: Kategori Ekle");
    Console.WriteLine("8: Kategori Listele");
    Console.WriteLine("9: Programdan Çık");

    string secim = Console.ReadLine();
    switch (secim)
    {
        case "1":
            UrunYeni(urunService, kategoriService);
            break;
        case "2":
            UrunAraId(urunService);
            break;
        case "3":
            UrunListele(urunService);
            break;
        case "4":
            UrunleriKategoriyeGoreListele(urunService);
            break;
        case "5":
            UrunGuncelle(urunService);
            break;
        case "6":
            UrunSil(urunService);
            break;
        case "7":
            KategoriYeni(kategoriService);
            break;
        case "8":
            KategoriListele(kategoriService);
            break;
        case "9":
            Console.WriteLine("Programdan çıkılıyor.");
            return; // Bu programdan çıkış için güvenli bir yol.
        default:
            Console.WriteLine("Geçersiz seçim. Lütfen tekrar deneyiniz.");
            break;
    }
}


static void UrunYeni(UrunService urunService, KategoriService kategoriService)
{
    Console.WriteLine("Yeni Ürün Ekleme:");
    Console.Write("Ürün Adı: ");
    string urunAdi = Console.ReadLine();
    Console.Write("Ürün Fiyatı: ");
    double urunFiyati = double.Parse(Console.ReadLine());
    Console.Write("Kategori ID: ");
    int kategoriId = int.Parse(Console.ReadLine());

    Urun yeniUrun = new Urun
    {
        UrunAdi = urunAdi,
        UrunFiyati = urunFiyati,
        KategoriID = kategoriId
    };

    urunService.AddUrun(yeniUrun);
    Console.WriteLine("Ürün eklendi.");
}

static void UrunListele(UrunService urunService)
{
    Console.WriteLine("Ürün Listesi:");
    var urunler = urunService.GetAllUrunler();
    foreach (var urun in urunler)
    {
        Console.WriteLine(urun.ToString());
    }
}

static void UrunGuncelle(UrunService urunService)
{
    Console.Write("Güncellenecek Ürün ID: ");
    int id = int.Parse(Console.ReadLine());
    var urun = urunService.GetUrunById(id);
    if (urun != null)
    {
        Console.Write("Yeni Ürün Adı (Mevcut: " + urun.UrunAdi + "): ");
        urun.UrunAdi = Console.ReadLine();
        Console.Write("Yeni Ürün Fiyatı (Mevcut: " + urun.UrunFiyati + "): ");
        urun.UrunFiyati = double.Parse(Console.ReadLine());

        urunService.UpdateUrun(urun);
        Console.WriteLine("Ürün güncellendi.");
    }
    else
    {
        Console.WriteLine("Ürün bulunamadı.");
    }
}

static void UrunSil(UrunService urunService)
{
    Console.Write("Silinecek Ürün ID: ");
    int id = int.Parse(Console.ReadLine());
    urunService.DeleteUrun(id);
    Console.WriteLine("Ürün silindi.");
}

static void KategoriYeni(KategoriService kategoriService)
{
    Console.WriteLine("Yeni Kategori Ekleme:");
    Console.Write("Kategori Adı: ");
    string kategoriAdi = Console.ReadLine();

    Kategori yeniKategori = new Kategori
    {
        KategoriAdi = kategoriAdi
    };

    kategoriService.AddKategori(yeniKategori);
    Console.WriteLine("Kategori eklendi.");
}

static void KategoriListele(KategoriService kategoriService)
{
    Console.WriteLine("Kategori Listesi:");
    var kategoriler = kategoriService.GetAllKategoriler();
    foreach (var kategori in kategoriler)
    {
        Console.WriteLine(kategori.ToString());
    }
}

static void UrunAraId(UrunService urunService)
{
    Console.Write("Aranacak Ürünün ID'sini Girin: ");
    int id;
    if (int.TryParse(Console.ReadLine(), out id))
    {
        var urun = urunService.GetUrunById(id);
        if (urun != null)
            Console.WriteLine($"Bulunan Ürün: {urun.UrunAdi}, Fiyatı: {urun.UrunFiyati}, Kategori: {urun.Kategori?.KategoriAdi}");
        else
            Console.WriteLine("Ürün bulunamadı.");
    }
    else
    {
        Console.WriteLine("Geçersiz ID formatı.");
    }
}

static void UrunleriKategoriyeGoreListele(UrunService urunService)
{
    Console.Write("Listelenecek Kategorinin Adını Girin: ");
    string kategoriAdi = Console.ReadLine();
    var urunler = urunService.GetUrunlerByKategoriAdi(kategoriAdi);
    if (urunler.Any())
    {
        foreach (var urun in urunler)
        {
            Console.WriteLine($"Ürün ID: {urun.UrunID}, Adı: {urun.UrunAdi}, Fiyatı: {urun.UrunFiyati}, Kategori: {urun.Kategori.KategoriAdi}");
        }
    }
    else
    {
        Console.WriteLine("Bu kategoriye ait ürün bulunamadı veya geçersiz kategori adı.");
    }
}