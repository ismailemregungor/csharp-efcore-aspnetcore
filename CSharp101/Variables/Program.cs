//int sayi = 42;
//uint pozitifsayi = 12345u;
//short kisasayi = -32768;
//ushort pozitifkisasayi = 65535;
//long buyuksayi = 9223372036854775807l;
//ulong buyukpozitifsayi = 18446744073709551615ul;
//float kesirlisayi = 3.14f;
//double ciftkesirlisayi = 2.71828;
//decimal hassassayi = 123.456789m;
//char karakter = 'a';
//bool dogrumu = true;
//byte baytdeger = 200;
//sbyte isaretlibaytdeger = -50;

//Console.WriteLine("Console İşlemleri");
//Console.WriteLine("Ad: ");
//string ad = Console.ReadLine();
//Console.WriteLine(ad);

Console.WriteLine("Sayı: ");
string str1 = Console.ReadLine();
int sayi1 = Convert.ToInt32(str1);
int sonuc1 = (sayi1 * sayi1);
Console.WriteLine("Sonuç: " + sonuc1);

Console.WriteLine("Sayı: ");
string str2 = Console.ReadLine();
int sayi2 = int.Parse(str2);
int sonuc2 = (sayi2 * sayi2);
Console.WriteLine("Sonuç: " + sonuc2);

// String Concation 
Console.WriteLine(sayi1 + " in karesi" + (sayi1 * sayi1));

// Content PlaceHolder
Console.WriteLine("{0} in karesi={1}", sayi1, sayi1 * sayi1);

// String Interpolation
Console.WriteLine($"{sayi1} in karesi={sayi1 * sayi1}");

