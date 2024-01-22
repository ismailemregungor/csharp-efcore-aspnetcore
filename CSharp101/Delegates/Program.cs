//using Delegates.Delegates;

// * DelegatesIntro
// */

//Temsilci t = new Temsilci(DelegatesIntro.Merhaba);

////t += DelegatesIntro.Merhaba;
////t += DelegatesIntro.Hi;
////t += DelegatesIntro.Hola;
////t += DelegatesIntro.Merhaba;
////t += DelegatesIntro.Merhaba;
////t -= DelegatesIntro.Merhaba;

//// delegate'i kendisiyle toplar veya çıkartır
//// t += t;
//// t -= t;

//// Delegate bu methodu taşıyamaz çünkü imzaları aynı değil
//// t += DelegatesIntro.Gunaydin;

//// Delegate bu methodu taşıyamaz çünkü imzaları aynı değil
//// t += DelegatesIntro.IyiGunler;

//// delegate'e bağlı tüm metodları çalıştırır.
//t();

// * Multicast Delegates
// */

//foreach (Delegate @delegate in t.GetInvocationList())
//{
//    // Console.WriteLine(@delegate.Method.Name);
//	if (@delegate.Method.Name == "Hola")
//	{
//		@delegate.DynamicInvoke();
//	}
//}


// * Anononim Metodlar:
// * Bir metodun adını yazmadan metod tanımlama işlemidir.
// * Tanımlı olan temsilcinin return type ve parametre durumuna göre metod yazılmalıdır.
// */
//using Delegates.AnonymousMethods.AnonymousMethods1;

//Temsilci t = delegate()
//{
//    Console.WriteLine("Anonim Method");
//};

//t+= delegate ()
//{
//    Console.WriteLine("Anonim Method");
//};

//t();

//using Delegates.MulticastDelegates.AnonymousMethods2;

// * Multicast delegate'lerde taşınan metodlar geriye değer döndürüyorsa;
// * sadece en son çalışan metodun değeri döner.
// * Arada çağrılan metodların geriye dönen değerleri yakalanamaz.
// * Bu nedenle genellikle parametre üzerinden dönen değer yakalanamaya çalışır.
// * örnek --> void EventHandler(object sender, EventArgs e)
// */

//int Bes()
//{
//    return 5;
//}

//int On()
//{
//    return 10;
//}

//int Yirmi()
//{
//    return 20;
//}

//Temsilci t = new Temsilci(Bes);
//t += On;
//t += Yirmi;

//Console.WriteLine(t());


// * Liste içerisindeki çift sayıları bulunuz.
// */

//// 1.yöntem

//List<int> sayilar = new List<int> { 34, 45, 6, 7, 88, 33, 145, 777 };

//foreach (int sayi in sayilar)
//{
//    if (sayi % 2 == 0)
//    {
//        Console.WriteLine(sayi);
//    }
//}

//// 2.yöntem
//void Yazdir(List<int> sayilar)
//{
//    foreach (int sayi in sayilar)
//    {
//        Console.WriteLine(sayi);
//    }
//}
//bool CiftSayilar(int sayi)
//{
//    return sayi % 2 == 0;
//}
//bool TekSayilar(double sayi)
//{
//    return sayi % 2 == 1;
//}

//Predicate<int> predicate = new Predicate<int>(CiftSayilar);
//Yazdir(sayilar.FindAll(predicate));

//// 3.yöntem

//List<int> ciftSayilar = sayilar.FindAll(CiftSayilar);
//Yazdir(ciftSayilar);

// * TekSayilar metodunun imzası metoda uygun olmadığından çalışmaz.
// * TekSayilar metodunun parametre tipi int olması gerekirken double olmuş
// */
////List<int> tekSayilar = sayilar.FindAll(TekSayilar);
////Yazdir(tekSayilar);

//// 4.yöntem

//Yazdir(sayilar.FindAll(delegate(int sayi)
//{
//    return sayi % 2 == 0;
//}));

//// 5.yöntem

//Yazdir(sayilar.FindAll(x => x % 2 == 0));
//// x --> delegate(int sayi)
//// { } --> =>
//// return sayi % 2 == 0; x % 2 == 0

/*
 * Kitap verilerinin tutulduğu liste üzerinde çalışan 
 * aşağıdaki raporları metod yazarak geliştiriniz.
 * 
 * 1-KitapId'ye göre kitap listeleme
 * 2-KitapFiyatı'na göre kitapları listeleme
 * 3-KitapKategorisi'ne göre kitap listeleme
 */

using Delegates.Delegates.Delegates1;

List<Kitap> kitaplar = new List<Kitap>()
{
    new Kitap
    {
        KitapId = 101,
        KitapAdi = "Denemeler",
        KitapFiyatı = 100,
        KitapKategorisi ="Deneme"
    },

    new Kitap
    {
        KitapId = 105,
        KitapAdi = "Büyük Umutlar",
        KitapFiyatı = 100,
        KitapKategorisi ="Roman"
    },

    new Kitap
    {
        KitapId = 106,
        KitapAdi = "Cehennem",
        KitapFiyatı = 100,
        KitapKategorisi ="Roman"
    },

        new Kitap
    {
        KitapId = 105,
        KitapAdi = "İngilizce-Turkce Sozluk",
        KitapFiyatı = 100,
        KitapKategorisi ="Sozluk"
    }
};

void KitapIdGoreListele(int kitapId)
{
    List<Kitap> sonuclar = kitaplar.FindAll(kitap => kitap.KitapId == kitapId);
    Console.WriteLine("Kitap ID'ye Göre Listeleme:");
    foreach (Kitap kitap in sonuclar)
    {
        Console.WriteLine($"{kitap.KitapId} - {kitap.KitapAdi}");
    }
}

void KitapFiyatiGoreListele(double kitapFiyati)
{
    List<Kitap> sonuclar = kitaplar.FindAll(kitap => kitap.KitapFiyatı == kitapFiyati);
    Console.WriteLine("Kitap Fiyatina Göre Listeleme:");
    foreach (Kitap kitap in sonuclar)
    {
        Console.WriteLine($"{kitap.KitapId} - {kitap.KitapAdi}");
    }
}

void KitapKategorisiGoreListele(string kitapKategorisi)
{
    List<Kitap> sonuclar = kitaplar.FindAll(kitap => kitap.KitapKategorisi == kitapKategorisi);
    Console.WriteLine("Kitap Fiyatina Göre Listeleme:");
    foreach (Kitap kitap in sonuclar)
    {
        Console.WriteLine($"{kitap.KitapId} - {kitap.KitapAdi}");
    }
}
//KitapIdGoreListele(101);
//KitapIdGoreListele(105);
//KitapIdGoreListele(106);
//KitapFiyatiGoreListele(100);
//KitapKategorisiGoreListele("Roman");



void Yazdir(List<Kitap> kitapListesi)
{
    foreach (Kitap kitap in kitaplar)
    {
        Console.WriteLine(kitap);
    }
}
List<Kitap> Ara(Predicate<Kitap> predicate)
{
    return kitaplar.FindAll(predicate);
}

Console.WriteLine("KitapId'ye göre = ");
Yazdir(Ara(x => x.KitapId == 101));
Console.WriteLine("KitapFiyati'na göre = ");
Yazdir(Ara(x => x.KitapFiyatı == 100));
Console.WriteLine("KitapFiyati'na göre = ");
Yazdir(Ara(x => x.KitapKategorisi == "Roman"));