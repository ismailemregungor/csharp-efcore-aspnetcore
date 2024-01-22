//using Events.Events1;

//// 4. adım: Event'in olduğu sınıfı oluştur(instance)
//Button button = new Button();
//// 5.adım: Olay ile olay oluştuğunda çalışacak metodu yaz ve ilişkilendir(+=).
//button.Tikla += Button_Tikla;
//void Button_Tikla()
//{
//    Console.WriteLine("Button Çalıştı!");
//}

//// 6.adım: Eventi Çalıştır.
//button.Calistir();

// * Suyun kaynamasını simule eden İsitici nesnesini OOP'ye göre modelleyiniz ve çalıştırınız.
// */

//using Events.Events2;

//Isitici isitici = new Isitici();

//isitici.KabarciklanmaEvent += Isitici_KabarciklanmaEvent;
//void Isitici_KabarciklanmaEvent(string message)
//{
//    Console.WriteLine(message);
//}

//isitici.SesEvent += Isitici_SesEvent;
//void Isitici_SesEvent(string message)
//{
//    Console.WriteLine(message);
//}

//isitici.KaynamaEvent += Isitici_KaynamaEvent;

//void Isitici_KaynamaEvent(string message)
//{
//    Console.WriteLine(message);
//}

//isitici.Isit();

// * Suyun kaynamasını simule eden İsitici nesnesini OOP'ye göre modelleyiniz ve çalıştırınız.
// */

// * Neef For Speed'deki gibi bir araba ile yolculuk yaparken aracın lastiklerinden herhangi
// * birinin patlamasını simule eden kodu OOP'de eventleri kullanarak yazınız?
// */

//using Events.NFS;

//Araba araba = new Araba();
//araba.LastikPatladiEvent += Araba_LastikPatladiEvent;

//void Araba_LastikPatladiEvent(string message)
//{
//    Console.WriteLine(message);
//}

//araba.YolculukBaslat();

/*
 * Neef For Speed'deki gibi bir araba ile yolculuk yaparken aracın lastiklerinden herhangi
 * birinin patlamasını simule eden kodu OOP'de eventleri kullanarak yazınız?
 */

/*
 * Belirli sayıda ürün kapasitesi olan bir depo nesnesi tanmlayalım.
 * Depo dolduğunda tetiklenen ve kullanıcıyı uyaran kodu OOP prensiplerini kullanarak yaz.
 * tetikleme işlemini delegate'e tanımlanan event ya da eventlerle yap.
 * Depoya; ürün ekleme, ürün listeleme, ürün çıkarma gibi işlemler olmalı.
 * Urun Classı(UrunId, UrunAdi, UrunFiyati, UrunKategorisi)
 */

using Events.Magaza;

Depo depo = new Depo(6);
depo.DepoDoldu += Depo_DepoDoldu;

void Depo_DepoDoldu(object sender)
{
    Console.WriteLine($"{((Urun)sender).UrunAdi} bu ürün depo dolduğu için eklenemedi!");
}

depo.UrunEkle(new Urun { UrunId = 1, UrunAdi = "Ürün 1", UrunFiyati = 10, UrunKategorisi = "Kategori A" });
depo.UrunEkle(new Urun { UrunId = 2, UrunAdi = "Ürün 2", UrunFiyati = 10, UrunKategorisi = "Kategori B" });
depo.UrunEkle(new Urun { UrunId = 3, UrunAdi = "Ürün 3", UrunFiyati = 10, UrunKategorisi = "Kategori C" });
depo.UrunEkle(new Urun { UrunId = 4, UrunAdi = "Ürün 4", UrunFiyati = 10, UrunKategorisi = "Kategori D" });
depo.UrunEkle(new Urun { UrunId = 5, UrunAdi = "Ürün 5", UrunFiyati = 10, UrunKategorisi = "Kategori E" });
depo.UrunleriListele();
//depo.UrunCikar(1);


