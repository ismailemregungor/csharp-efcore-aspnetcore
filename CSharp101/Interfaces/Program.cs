//using Interfaces.Interfaces1;

// * Interfaces1
// */

//Personel personel = new Personel();
//Musteri musteri = new Musteri();

//IArayuz personel1 = new Personel();
//IArayuz musteri1 = new Personel();

////personel1.Islem();
////musteri1.Islem();


// * Interfaces2
// */

//using Interfaces.Interfaces2;

//Depo depo = new Depo();

//foreach (string urun in depo)
//{
//    Console.WriteLine(urun);
//}

// * Interfaces3
// */

//using Interfaces.Interfaces3;
//using Interfaces.Interfaces3.Urun2;
//using System.Collections;


//void Yaz(ArrayList liste)
//{
//	foreach (object o in liste)
//	{
//		Console.Write(o  + " ");
//		Console.WriteLine();
//	}
//}

//ArrayList arrayList1 = new ArrayList();
//ArrayList arrayList2 = new ArrayList();
//ArrayList arrayList3 = new ArrayList();

//arrayList1.Add(10);
//arrayList1.Add(15);
//arrayList1.Add(20);

//arrayList1.Sort();
//Yaz(arrayList1);

//arrayList2.Add("İstanbul");
//arrayList2.Add("Ankara");
//arrayList2.Add("Adana");

//arrayList2.Sort();
//Yaz(arrayList2);

//Urun1 urun = new Urun1();

//arrayList3.Add(new Urun1
//{
//	UrunId = 111,
//    UrunAdi = "Defter",
//    UrunFiyati = 45
//});

//arrayList3.Add(new Urun1
//{
//    UrunId = 134,
//    UrunAdi = "Pergel",
//    UrunFiyati = 90
//});

//arrayList3.Add(new Urun1
//{
//    UrunId = 88,
//    UrunAdi = "AciOlcer",
//    UrunFiyati = 88
//});

//arrayList3.Sort();
//Yaz(arrayList3);

// * Interfaces3
// */

//using Interfaces.Interfaces3.Urun2;
//using System.Collections;

//void Yaz(ArrayList liste)
//{
//    foreach (object o in liste)
//    {
//        Console.Write(o + " ");
//        Console.WriteLine();
//    }
//}

//ArrayList arrayList1 = new ArrayList();
//ArrayList arrayList2 = new ArrayList();
//ArrayList arrayList3 = new ArrayList();

//arrayList1.Add(10);
//arrayList1.Add(15);
//arrayList1.Add(20);

//arrayList1.Sort();
//Yaz(arrayList1);

//arrayList2.Add("İstanbul");
//arrayList2.Add("Ankara");
//arrayList2.Add("Adana");

//arrayList2.Sort();
//Yaz(arrayList2);

//Urun2 urun = new Urun2();

//arrayList3.Add(new Urun2
//{
//    UrunId = 111,
//    UrunAdi = "Defter",
//    UrunFiyati = 45
//});

//arrayList3.Add(new Urun2
//{
//    UrunId = 134,
//    UrunAdi = "Pergel",
//    UrunFiyati = 90
//});

//arrayList3.Add(new Urun2
//{
//    UrunId = 88,
//    UrunAdi = "AciOlcer",
//    UrunFiyati = 88
//});

//arrayList3.Sort();
//Yaz(arrayList3);

//Karsilastir karsilastir = new Karsilastir();
//karsilastir.NeyeGore = "";

//arrayList3.Sort(karsilastir);
//Yaz(arrayList3);

/*
 * Interfaces4
 * 
 * Bardak ve Tomruk diye iki sınıfımız var. Bu sınıflardan bardak kırılabilir, tomruk kırılamaz.
 * Rastgele 10 ürün oluşturup bunlardan sadece kırılabilenleri nesneleri gösteriniz.
 */


//using Interfaces.Interfaces4;
//using System.Collections;

//Random random = new Random();
//ArrayList urunler = new ArrayList();

//for (int i = 0; i < 10; i++)
//{
//    if (random.Next(2) == 0)
//    {
//        urunler.Add(new Bardak());
//    }
//    else
//    {
//        urunler.Add(new Tomruk());
//    }
//}

//Console.WriteLine("Kırılabilir Ürünler:");
//foreach (var urun in urunler)
//{
//    if (urun is IKirilabilir)
//    {
//        ((IKirilabilir)urun).Kiril();
//    }
//}

//Console.WriteLine("Kırılamaz Ürünler:");
//foreach (var urun in urunler)
//{
//    if (urun is IKirilamaz)
//    {
//        ((IKirilamaz)urun).Kirilamaz();
//    }
//}

//using Interfaces.Interfaces4._2;
//using System.Collections;

//ArrayList urunler = new ArrayList();

//for (int i = 0; i < 10; i++)
//{
//    Random random = new Random();
//	if (random.Next(1, 3) == 1)
//	{
//		urunler.Add(new Bardak());
//	}
//	else
//	{
//		urunler.Add(new Tomruk());
//	}
//}

//foreach (object obj in urunler)
//{
//    Console.WriteLine(obj);
//} 

//foreach (object obj in urunler)
//{
//	if (obj is IKirilabilir)
//	{
//        Console.WriteLine(obj);
//    }
//}


/*
 * Interfaces5
 */

/*
 * Interfaces6
 */

/*
 * Interfaces7
 */

// * Interfaces8
// * GTA Vice City oyunundaki garaja giren arabanın istenilen renge göre boyanmasını sağlayan C# 
// * kodunu OOP prensiplerini kullanarak yaz.(Intereface etc.)
// */

//using Interfaces.Interfaces8;

//Garaj garaj = new Garaj();

//Ferrari ferrari = new Ferrari("Ferrari", "Ferrari Modeli");
//garaj.Boya(ferrari, ConsoleColor.Red);

//Bisiklet bisiklet = new Bisiklet("Bisiklet", "Bisiklet Modeli");
//garaj.Boya(bisiklet, ConsoleColor.Blue);

//Limuzin limuzin = new Limuzin("Limuzin", "Limuzin Modeli");
//garaj.Boya(limuzin, ConsoleColor.White);

/*
 * Interfaces8
 * GTA Vice City oyunundaki garaja giren arabanın istenilen renge göre boyanmasını sağlayan C# 
 * kodunu OOP prensiplerini kullanarak yaz.(Intereface etc.)
 */

//using Interfaces.Interfaces8._2;

//Ferrari ferrari = new Ferrari();
//Bmw bmw  = new Bmw();
//Bmx bmx = new Bmx();

//Utility.EkranaYaz(ferrari);
//Utility.EkranaYaz(bmw);
//Utility.EkranaYaz(bmx);

//Boyahane boyahane = new Boyahane();
//boyahane.Boya(ferrari, ConsoleColor.Red);
//boyahane.Boya(bmw, ConsoleColor.Blue);
//// boyahane.Boya(bmx, ConsoleColor.White);

//Utility.EkranaYaz(ferrari);
//Utility.EkranaYaz(bmw);
//Utility.EkranaYaz(bmx);

using Interfaces.Interfaces9;
