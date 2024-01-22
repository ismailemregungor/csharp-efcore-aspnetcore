//int a, b = 2, c = 0;

//int[] numbers = { 43, 4566, 67, 33 };
//Console.WriteLine("1. İşlem");
//Console.WriteLine("2. İşlem");
//Console.WriteLine("3. İşlem");

//try
//{
//    a = b / c;
//    Console.WriteLine(a);
//    Console.WriteLine(numbers[10]);
//}
//catch (DivideByZeroException ex)
//{
//    Console.WriteLine("Divide Log: " + ex.Message);
//}
//catch (IndexOutOfRangeException ex)
//{
//    Console.WriteLine("Index Log: " + ex.Message);
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}

//try
//{
//	 throw new NotImplementedException();
//}
//finally
//{
//	Console.WriteLine("İstisna olsa da olmasada çalış!");
//}

//using Exceptions;

//int sayi = Convert.ToInt32(Console.ReadLine());

//try
//{
//	if (sayi == 5)
//	{
//		throw new NotFiveException();
//	}
//}
//catch (Exception ex)
//{

//	Console.WriteLine(ex.Message);
//}
//finally
//{
//	Console.WriteLine("İstisna olsa da olmasa da çalışır");
//}


/*
 * Bir metoda parametre olarak gönderilen bir string ifade içerisindeki karakter sayısı
 * ve kelime sayısını bulan ve bu verileri dışarıya aktaran metodu c# dili ile yazınız.
 */

//// 1.yöntem
//string metin = Console.ReadLine();
//int karakterSayisi, kelimeSayisi;

//static void HesaplaKarakterKelime(string metin, out int karakterSayisi, out int kelimeSayisi)
//{
//    karakterSayisi = metin.Length;
//    string[] kelimeler = metin.Split(' ');
//    kelimeSayisi = kelimeler.Length;
//}

//// 2.yöntem
//HesaplaKarakterKelime(metin, out karakterSayisi, out kelimeSayisi);
//Console.WriteLine("Karakter Sayısı: " + karakterSayisi);
//Console.WriteLine("Kelime Sayısı: " + kelimeSayisi);

//int KelimeKarakterSayisiBul(string str, out int karakterSayisi)
//{
//    karakterSayisi = str.Length;
//    return str.Split(' ').Length;
//}

//Console.WriteLine("Mesaj Giriniz: ");
//string mesaj = Console.ReadLine();

//int kelimeSayisi = KelimeKarakterSayisiBul(mesaj, out int karakterSayisi);
//Console.WriteLine($"KelimeSayisi = {kelimeSayisi}  Karakter Sayisi = {karakterSayisi}");

/*
 * 1 adet tombala kartı(1-90 arası 15 sayılık)için değerleri oluşturan metodu C# dili ile yazınız. 
 * 
 */

//int[] TombalaKartiOlustur(out int KacKezCalisti)
//{
//    int[] sayilar = new int[15];
//    int sayac = 0;
//    KacKezCalisti = 0;

//    while (sayac < sayilar.Length)
//    {
//        int sayi = new Random().Next(1, 91);
//        if (!sayilar.Contains(sayi))
//        {
//            sayilar[sayac] = sayi;
//            sayac++;
//        }
//        KacKezCalisti++;
//    }
//    return sayilar;
//}

//void EkranaYaz(int[] sayilar)
//{
//    foreach (var sayi in sayilar)
//    {
//        Console.Write(sayi + " ");
//        Console.WriteLine();
//    }
//}

//for (int i = 0; i < 3; i++)
//{
//    EkranaYaz(TombalaKartiOlustur(out int KacKezCalisti));
//    Console.WriteLine($"Döngü {KacKezCalisti} defa çalıştı");
//}


/*
 * Rastgele oluşturulmuş 20 değer arasında aynı değer varsa ekranda zemin rengi
 * kırmızı olacak şekilde yazınız.
 */

//int[] GetRandomValue(int length)
//{
//    int[] array = new int[length];
//    for (int i = 0; i < array.Length; i++)
//        array[i] = new Random().Next(1, 101);
//    return array;
//}

//void DisplayValue(int[] numbers)
//{
//    foreach (var number in numbers)
//        Console.WriteLine(number);
//}
//bool TekrarEdenSayilar(int[] array)
//{
//    return array.Distinct().Count() < array.Length;
//}

//void KırmızıyaBoya()
//{
//    int[] rastgeleDegerler = GetRandomValue(20);

//    if (TekrarEdenSayilar(rastgeleDegerler))
//    {
//        Console.BackgroundColor = ConsoleColor.Red;
//        Console.ForegroundColor = ConsoleColor.Black;
//        Console.Clear();
//        DisplayValue(rastgeleDegerler);
//        Console.ResetColor(); 
//    }
//    else
//    {
//        DisplayValue(rastgeleDegerler);
//    }
//}

//KırmızıyaBoya();

int[] DiziOlustur(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 101);
    return array;
}

//bool DiziyiKontrolEt(int[] dizi)
//{
//    for (int i = 0; i < dizi.Length; i++)
//    {
//        for (int j = i + 1; j < dizi.Length; j++)
//        {
//            if (dizi[i] == dizi[j])
//            {
//                return true;
//            }
//        }
//    }
//    return false;
//}

//void DiziYazdir(int[] sayilar, bool ayniMi)
//{
//    if (ayniMi)
//    {
//        Console.BackgroundColor = ConsoleColor.Red;
//    }
//    else
//    {
//        Console.BackgroundColor = ConsoleColor.Black;

//    }

//    foreach (var sayi in sayilar)
//    {
//        Console.Write(sayi + " ");
//        Console.WriteLine(sayilar);
//    }
//}

//for (int i = 0; i < 5; i++)
//{
//    int[] sayilar = DiziOlustur(20);
//    DiziYazdir(sayilar, DiziyiKontrolEt(sayilar));
//}


/*
 * 100 öğrencinin 1-10 arası notlarının frekansını bulup en yüksek frekansı olan 3 notu bulan metodu C# ile bulunuz.
 */


//Random random = new Random();
//int[] notlar = new int[100];
//int[] frekanslar = new int[11];

//for (int i = 0; i < notlar.Length; i++)
//{
//    notlar[i] = random.Next(1, 10);
//    frekanslar[notlar[i]]++;
//}

//for (int not = 1; not <= 10; not++)
//{
//    Console.WriteLine($"Not {not}: {frekanslar[not]} kişi");
//}

//void EnYuksekFrekansıBul(int[] frekanslar, int kacNot)
//{
//    int[] enYuksekFrekansNotlari = new int[kacNot];

//    for (int i = 0; i < kacNot; i++)
//    {
//        int enYuksekFrekans = frekanslar.Max();
//        int enYuksekFrekansNot = Array.IndexOf(frekanslar, enYuksekFrekans);

//        frekanslar[enYuksekFrekansNot] = 0; 
//        enYuksekFrekansNotlari[i] = enYuksekFrekansNot;
//    }

//    Console.WriteLine($"En Yüksek {kacNot} Frekanslı Notlar:");
//    foreach (var not in enYuksekFrekansNotlari)
//    {
//        Console.Write(not + " ");
//    }
//}

//EnYuksekFrekansıBul(frekanslar, 3);

//int[] NotlariOlustur(int ogrenciSayisi)
//{
//    int[] notlar = new int[ogrenciSayisi];
//    for (int i = 0; i < ogrenciSayisi; i++)
//    {
//        notlar[i] = new Random().Next(1, 11);
//    }
//    return notlar;
//}

//int[] FrekansHesapla(int[] notlar)
//{
//    int[] frekanslar = new int[11];
//    for (int i = 0; i < notlar.Length; i++)
//    {
//        frekanslar[notlar[i]]++;
//    }
//    return frekanslar;
//}

//void DiziYazdir(int[] dizi)
//{
//    for (int i = 1; i < dizi.Length; i++)
//    {
//        Console.WriteLine($"{i} {dizi[i]}");
//    }
//}

//int[] data = NotlariOlustur(100);
////FrekansHesapla(data);
////DiziYazdir(FrekansHesapla(data));
//int[] frekanslar = FrekansHesapla(data);
//int[] ydkFrekanslar = new int[frekanslar.Length];
//Array.Copy(frekanslar,ydkFrekanslar, frekanslar.Length);
//DiziYazdir(frekanslar);
//Array.Sort(frekanslar);
//Array.Reverse(frekanslar);

//for (int i = 0; i < 3; i++)
//{
//    Console.Write(frekanslar[i] + "=>" + Array.IndexOf(ydkFrekanslar, frekanslar[i]) + " ");
//}
