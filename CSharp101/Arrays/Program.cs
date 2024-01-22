//int[] dizi1 = new int[10];
//Console.WriteLine(dizi1.Rank);

//int[,] dizi2 = new int[10,10];
//Console.WriteLine(dizi2.Rank);

//int[,,] dizi3 = new int[10, 10, 10];
//Console.WriteLine(dizi3.Rank);

//int[][] jaggedArray = new int[5][];
//jaggedArray[0] = new int[5];
//jaggedArray[2] = new int[10];
//jaggedArray[3] = new int[3];

//int[][,] jaggedArray2 = new int[5][,];
//jaggedArray2[0] = new int[5,5];
//jaggedArray2[2] = new int[10,5];
//jaggedArray2[3] = new int[3,5];


//int[] dizi1 = new int[10];
//int[] dizi2 = { 45, 56, 445, 332, 11 };

//for (int i = 0; i<dizi1.Length; i++ )
//{
//    Console.WriteLine(dizi1[i]);
//}

//integer tipinde sayi türünde struct oluşturma ve sayinin init değeri 0
//int sayi = new int();
//Console.WriteLine(sayi);


////nullable variables
//char? c = null;

//// iki byte toplanırsa sonuc int olmalı
//byte b1 = 0, b2=1, b3 = 2;
//b1 = b2 + b3;

//int[] items = { 45, 56, 445, 332, 11 };

//foreach (var item in items)
//{
//    Console.WriteLine(item);
//}

// Kullanıcı tarafından girilmiş olan 5 tam sayıdan en kucugunu bulan kodu dizi kullanarak c# diliyle yaz.

//int[] numbers = new int[5];

//int min = numbers[0];

//for (int i = 0; i < numbers.Length; i++)
//{
//Console.Write($" {i + 1}. sayıyı girin: ");
//numbers[i] = int.Parse(Console.ReadLine());

//if (numbers[i] < min)
//    {
//        min = numbers[i];
//    }
//Console.WriteLine(min);
//}

//int[] numbers = new int[5];
//for (int i = 0; i < numbers.Length; i++)
//{
//    numbers[i] = int.Parse(Console.ReadLine());
//}

//Array.Sort(numbers);
//Console.WriteLine(numbers[0]);
//Console.WriteLine(numbers[numbers.Length-1]);

// 50 kişilik bir sınıfta sınav yapılmıştır. öğrencilerin 1-10 arası notlar verilmiştir.
// notların frekansını bulan kodu C# dili ile dizi kullanarak en kısa yol ile çözünüz.

//Random random = new Random();
//int[] notlar = new int[50];
//int[] frekanslar = new int[11];

//for (int i=0; i<notlar.Length; i++)
//{
//    notlar[i] = random.Next(1, 10);
//    frekanslar[notlar[i]]++;
//}

//for (int not = 1; not <= 10; not++)
//{
//    Console.WriteLine($"Not {not}: {frekanslar[not]} kişi");
//}

// // Geciktirme-Delay işlemi
//for (int i = 0; i < 100; i++) ;
//    Console.WriteLine("i");

//for (int i = 0; i < 10; i++)
//{
//	//for (int j = 0; j < 99999999; j++)
//		Thread.Sleep(1000);
//        Console.WriteLine(i);
//}



