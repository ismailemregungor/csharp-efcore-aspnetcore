//Soru:UrunAdi, Fiyatı ve Kategori bilgilerini tutan bir Oracle veritabanını EF COre Model First yöntemi ile geliştiriniz? 
//Bilgi ekleme, listeleme(ID ye gore arama, tum urunler, kategori Adına gore urunler), guncelleme ve silme(CRUD) bu işlemleri yapan uygulamayı Console uzerinde yazınız?

//User olusturma...
//create user test2 identified by test2 default tablespace users temporary tablespace temp;
//grant connect, resource, DBA to test2;

//Connection string
//User Id = hr; Password = hr; Data Source = (DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = 127.0.0.1)(PORT = 1521)))(CONNECT_DATA = (SERVER = DEDICATED)(SID = orcl)))

using EFCoreModelFirst4._2.Data;
using EFCoreModelFirst4._2;
using EFCoreModelFirst4._2.Models;

UrunDB urunDB = new UrunDB();

do
{
    Console.WriteLine("1. Ürün Ekle");
    Console.WriteLine("2. Ürün Güncelle");
    Console.WriteLine("3. Ürün Sil");
    Console.WriteLine("4. Tüm Ürünleri Listele");
    Console.WriteLine("5. Ürün Id ye göre ara");
    Console.WriteLine("6.Kategori Adına Göre Ara");
    Console.WriteLine("7. Tüm Kategoriler");
    Console.WriteLine("8. Kategori Ekle");
    Console.WriteLine("9. Kategori Sil");
    Console.WriteLine("0. Çıkış");
    Console.WriteLine("Seçiminiz:");
    int secim = int.Parse(Console.ReadLine());

    switch (secim)
    {
        case 1:
            urunDB.Urunler.Ekle(ConsoleUtility.UrunVerisiAl());
            break;
        case 2:
            Console.WriteLine("Guncellenecek urunun ID sini giriniz");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Eski Değerler");
            Console.WriteLine(urunDB.Urunler.Bul(id));
            Urun urun = ConsoleUtility.UrunVerisiAl();
            urun.UrunID = id;
            urunDB.Urunler.Guncelle(urun);
            break;
        case 3:
            Console.WriteLine("Silinecek Urun Id sini giriniz..");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("Eski Değerler");
            Console.WriteLine(urunDB.Urunler.Bul(id));

            Console.WriteLine("Bu verileri Silmek ister misiniz");
            string eminMisiniz = Console.ReadLine();
            if (eminMisiniz == "E" || eminMisiniz == "e")
                urunDB.Urunler.Sil(id);
            break;
        case 4:
            //ConsoleUtility.Listele(urunDB.Urunler.Listele());
            ConsoleUtility.Listele(urunDB.Urunler.ListeleJoin("Kategori"));

            break;
        case 5:
            break;
        case 6:
            break;
        case 7:
            ConsoleUtility.Listele(urunDB.Kategoriler.Listele());
            Console.ReadLine();
            break;
        case 8:
            urunDB.Kategoriler.Ekle(ConsoleUtility.KategoriVerisiAl());
            Console.ReadLine();
            break;
        default:
            break;
    }

} while (true);


