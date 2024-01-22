// * Generics1
// * Bir firma için string, double, int dizilerindeki değerleri ekrana yazan C# kodunuz yazınız.
// */

//using Generics.Generics1;

//Firma firma = new Firma();

//string[] isimler = { "Ahmet", "Mehmet", "Ayse" };
//double[] maaslar = { 5000.50, 6000.75, 7500.25 };
//int[] yaslar = { 30, 35, 28 };

////farklı tipler için aynı metodu 3 kere yazdık
//Console.WriteLine("İsimler:");
//firma.DiziYazdir(isimler);

//Console.WriteLine("Maaşlar:");
//firma.DiziYazdir(maaslar);

//Console.WriteLine("Yaşlar:");
//firma.DiziYazdir(yaslar);


//// farklı tipler için aynı metodu 1 kere yazıdk
//Console.WriteLine("İsimler:");
//firma.GenericDiziYazdir<string>(isimler);

//Console.WriteLine("Maaşlar:");
//firma.GenericDiziYazdir<double>(maaslar);

//Console.WriteLine("Yaşlar:");
//firma.GenericDiziYazdir<int>(yaslar);

// * Generics2
// */

//using Generics.Generics2;

//Urun<Kitap> urun1 = new Urun<Kitap>();
//urun1.UrunEkle(new Kitap());

//Urun<Bardak> urun2 = new Urun<Bardak>();
//urun2.UrunEkle(new Bardak());

/*
 * GenericCollections1
 */

//using Generics.GenericCollections1;


//List<int> sayilar = new List<int>();
//sayilar.Add(1);

//List<Personel> personel1 = new List<Personel>();

// * Genericcollections
// * 1-Performans
// */

//using System.Collections;

//DateTime baslat, bitir;
//TimeSpan fark;

//ArrayList liste1 = new ArrayList();
//List<int> liste2 = new List<int>();

//int sayac = 9999999;

//baslat = DateTime.Now;

//for (int i = 0; i < sayac; i++)
//{
//    liste1.Add(i);
//    int sayi = (int)liste1[i];
//}
//bitir = DateTime.Now;
//fark = bitir - baslat;
//Console.WriteLine($"ArrayList zaman farkı = {fark.TotalMilliseconds}");

//for (int i = 0; i < sayac; i++)
//{
//    liste2.Add(i);
//    int sayi = liste2[i];
//}
//bitir = DateTime.Now;
//fark = bitir - baslat;
//Console.WriteLine($"List zaman farkı = {fark.TotalMilliseconds}");

// * GenericColelctions
// * 2-Tip Güvenliği
// */

//using System.Collections;

//ArrayList liste1 = new ArrayList();
//liste1.Add(1);
//liste1.Add(2);
//liste1.Add(3);
//// Hata Runtime'da yakalandı
//// liste1.Add("DÖRT");

//int toplam = 0;
//foreach (int sayi in liste1)
//{
//    toplam += sayi;
//}
//Console.WriteLine(toplam);

//List<int> liste2 = new List<int>();
//liste2.Add(1);
//liste2.Add(2);
//liste2.Add(3);

//// Hata Designtime'da yakalandı
////liste2.Add("DÖRT");

// * Normal koleksiyonlarda veri tiplerinden kaynakanan hatalar 
// * designtime(kodu yazarken kızar)'da değil runtime'da(kodu derleyince) verir
// * 
// * Generic koleksiyonları kullandığımızda ise hatalar designtime'da yakalanır.
// * Bu yüzden Generic yapılar tip güvenlidir.
// */

/*
 * Generic Constraints
 * 1-
 */

/*
 * Generic Constraints
 * 2-
 */

using Generics.GenericConstraints.TestClassStruct;
using Generics.GenericConstraints.TestInheritance;
using Generics.GenericConstraints.TestInheritanceInterface;

/*
 * struct
 */
TestStruct<int> hesapla1 = new TestStruct<int>();
// T Değer tipli olmalıdır!
// Hesapla<string> hesapla2 = new Hesapla<string>(); // --> Hata verir

/*
 * class
 */

// T Referans tipli olmalıdır!
//Test<int> test1 = new Test<int>(); // --> Hata verir
TestClass<string> test2 = new TestClass<string>();

/*
 * Inheritance
 */

PersonelIslemleri<GenelMudur> personelIslemleri1 = new PersonelIslemleri<GenelMudur>();
PersonelIslemleri<Hizmetli> personelIslemleri2 = new PersonelIslemleri<Hizmetli>();
// T Personel sınıfından türemiş olmalı
//PersonelIslemleri<Guvenlik> personelIslemleri3 = new PersonelIslemleri<Guvenlik>(); // --> Hata verir

/*
 * Interface
 */

SilahIslemleri<GenelMudur> silahIslemleri1 = new SilahIslemleri<GenelMudur>();
SilahIslemleri<Guvenlik> silahIslemleri2 = new SilahIslemleri<Guvenlik>();
// T ISilahIslemleri interface'ını implemente etmiş olmalı 
// SilahIslemleri<Hizmetli> silahIslemleri3 = new SilahIslemleri<Hizmetli>(); // --> Hata verir

PersonelYonetimi<GenelMudur> personelYonetimi1 = new PersonelYonetimi<GenelMudur>();
// CEO sınıfı default parametresiz constructor'u olmalı
// PersonelYonetimi<CEO> personelYonetimi1 = new PersonelYonetimi<CEO>(); // --> Hata verir

