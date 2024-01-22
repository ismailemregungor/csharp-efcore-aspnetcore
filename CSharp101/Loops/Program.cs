//for (int i = 0; i<10; i++)
//{
//    Console.WriteLine(i);
//}

//for (int i = 0; i < 10; i++)
//  Console.WriteLine(i);


//for(; ; )
//    Console.WriteLine("sonsuz döngü");

//int i = 0;
//while (i<10)
//{
//    Console.WriteLine(i);
//    i++;
//}
//while (true)
//{
//    Console.WriteLine("sonsuz döngü");
//}

//int i = 0;
//do
//{
//    Console.WriteLine(i);
//    i++;
//} while (i < 10);


//do
//{
//  Console.WriteLine("sonsuz döngü");
//} while (true);

//while (true)
//{
//    Console.WriteLine("break");
//    break;
//}

//for (int i = 0; i < 10; i++)
//{
//    if (i == 5)
//    {
//        continue;
//    }
//    Console.WriteLine(i);

//}

//Random random = new Random();
//Console.WriteLine(random.Next(0, 100));

// Rastgele olusturulan 1-100 arası 50 sayıdan 5'e tam bölünenleri yazdır.

//Random random = new Random();

//for (int i=0; i<50; i++)
//{
//    int randomNumber = random.Next(1, 100);
//    if(randomNumber % 5 == 0)
//    {
//        Console.WriteLine(randomNumber);
//    }
//}

// 10'lu sistemde girilen bir sayıyı 2'li sisteme çeviren kodu yazınız.

//Console.Write("10'luk bir sayı: ");
//int decimalNumber = int.Parse(Console.ReadLine());
//string binaryNumber = "";

//while (decimalNumber > 0)
//{
//    int decimalnum = decimalNumber % 2;
//    binaryNumber = decimalnum + binaryNumber;
//    decimalNumber = decimalNumber / 2;
//}

//Console.WriteLine("2'lik sistemdeki hali: " + binaryNumber);


//Console.Write("10'luk bir sayı: ");
//int sayi = int.Parse(Console.ReadLine());
//string sonuc = "";

//while (sayi > 0)
//{
//    sonuc = (sayi % 2).ToString() + sonuc;
//    sayi = sayi / 2;
//}

//Console.WriteLine(sonuc);

//Kullanıcının girdiği bir metin ifadeyi her harfi bir satıra gelecek şekilde yazınız.

//Console.Write("Bir kelime giriniz: ");
//string kelime = Console.ReadLine();

//for (int i = 0; i < kelime.Length; i++)
//{
//    Console.WriteLine(kelime[i]);
//}


//foreach(char harf in kelime)
//{
//    Console.WriteLine(harf);
//}