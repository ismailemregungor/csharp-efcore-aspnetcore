//// 2 tam sayıyı, 3 tamsayıyı, 4 tamsayıyı toplayan methodları yazınız.

//// 1.yöntem
//int Topla(params int[] sayilar)
//{
//	int toplam = 0;
//	foreach (var sayi in sayilar)
//	{
//		toplam = sayi + toplam;
//	}
//	return toplam;
//}

//Console.WriteLine(Topla(1, 2));
//Console.WriteLine(Topla(1, 2, 3));
//Console.WriteLine(Topla(1, 2, 3, 4));

//// 2.yöntem
//int Topla2(params int[] sayilar)
//{
//	return sayilar.Sum();
//}

//Console.WriteLine(Topla2(1, 2));
//Console.WriteLine(Topla2(1, 2, 3));
//Console.WriteLine(Topla2(1, 2, 3, 4));


//// Default (Optional) Parameters
//void Process1(int a, int b, int c = 1)
//{
//    Console.WriteLine($"{a} {b} {c}");
//}

//Process1(1, 2);
//Process1(11, 22, 33);

//// Named Parameters
//void Process2(int a, int b, int c = 1)
//{
//    Console.WriteLine($"{a} {b} {c}");
//}

//Process2(c: 111, b: 123, a: 321);
//Process2(b: 123, a: 321);
///*
// * Eğer named parametreler tanımlandığı sırada gönderilirse c yazmaya gerek yok
// * sıralı gönderilmez ise yazmak gerekir.
// */
//Process2(a: 123, b: 321, 30);

//// 0 ve 1 durumu kontrol edilmediği için - sonsuza kadar gider ve
//// stackte bulunan method stacki doldurur bu yüzden stack owerflow hatası verir
//int Faktoriyel(int sayi)
//{
//    return sayi * Faktoriyel(sayi - 1);
//}

//Console.WriteLine(Faktoriyel(5));

//int Faktoriyel2(int sayi)
//{
//    // if(sayi == 1) return 1;
//    if (sayi <= 1)
//        return 1;
//    return sayi * Faktoriyel2(sayi - 1);
//}

//Console.WriteLine(Faktoriyel2(5));

//ref out

//int sayi = int.Parse(Console.ReadLine());

//if (int.TryParse(Console.ReadLine(), out int sayi))
//{
//    Console.WriteLine(sayi);
//}
//else
//    Console.WriteLine("Girilen değer tamsayıya çevrilemez!");

// Aşağıdaki metodun içerisindeki a ve b parametrelerinin değerini dış dünyaya return kullanmadan aktaralım

// 1.yöntem ref ile
//void MetodA(ref int a, ref int b)
//{
//    a = 111;
//    b = 222;
//}

//// int c, d; --> ref'de değişkenleri initialize etmek yani ilk değer ataması gerekir.
//int c = 0, d = 0;
//MetodA(ref c, ref d);

//Console.WriteLine(c + " " + d);

//// 2.yöntem out ile

//void MetodB(out int a, out int b)
//{
//    a = 111;
//    b = 222;
//}
//// int e, f; --> out'dae değişkenleri initialize etmek yani ilk değer ataması gerekmez.
//// out'a sonradan gelen güncellemeyle değişken tanımlaması sadece out olan yerde de yapılabilir.
//int e, f;
//MetodB(out e, out f);

//Console.WriteLine(e+ " " + f);


//int[] dizi = { 1, 2, 3, 4, 5 };

//Console.WriteLine("Dizi Öncesi:");
//foreach (var eleman in dizi)
//{
//    Console.Write(eleman + " ");
//}
//Console.WriteLine();

//int yeniBoyut = 8; 
//Array.Resize(ref dizi, yeniBoyut);

//Console.WriteLine("Dizi Sonrası:");
//foreach (var eleman in dizi)
//{
//    Console.Write(eleman + " ");
//}
//Console.WriteLine();




// rastgele oluşturulmuş 50 elemanlı bir dizi içerisindeki tek sayıları bulan ve döndüren method?

//// out ile
//void GetTekSayilar(out int[] tekSayilar)
//{
//    Random random = new Random();
//    int[] sayilar = new int[50];
//    tekSayilar = new int[sayilar.Length];

//    for (int i = 0; i < sayilar.Length; i++)
//    {
//        sayilar[i] = random.Next(1, 100);
//        if (sayilar[i] % 2 == 1)
//        {
//            tekSayilar[i] = sayilar[i];
//        }
//    }
//}
//Random random = new Random();
//GetTekSayilar(out int[] tekSayilar);

//Console.WriteLine("Tek Sayılar:");
//foreach (var sayi in tekSayilar)
//{
//    Console.WriteLine(sayi);
//}

//

// Rastgele sayılardan oluşan dizi methodu
int[] GetRandomValue(int length)
{
    int[] array = new int[length];
	for (int i = 0; i < array.Length; i++)
		array[i] = new Random().Next(1,101);
    return array;
}

int[] numbers = GetRandomValue(50);

// int diziyi ekrana yazdıran method
void DisplayValue(int[] numbers)
{
	foreach (var number in numbers)
		Console.WriteLine(number);
}

// DisplayValue(numbers);


int[] GetOddValues(int[] numbers)
{
	int[] oddNumbers = new int[numbers.Length];
	int counter = 0;
	foreach (var number in numbers)
	{
		if (number % 2 == 1)
		{
			counter++;
			Array.Resize(ref oddNumbers, counter);
			oddNumbers[counter - 1] = number;
		}
	}
	return oddNumbers;
}

DisplayValue(GetOddValues(numbers));


// LINQ ve Lambda Expression kullanımı ile çözümü

// DisplayValue(numbers.Where(sayi => sayi % 2 == 1).ToArray());
