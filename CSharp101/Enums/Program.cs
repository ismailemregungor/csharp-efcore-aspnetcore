// * Ekrana farklı renklerle "Merhaba" yazan C# kodu.
// */

//for (int i = 0; i < 16; i++)
//{
//    Console.ForegroundColor = (ConsoleColor)i;
//    Console.WriteLine("Merhaba");
//}

//foreach (string name in Enum.GetNames(typeof(ConsoleColor)))
//{
//    Console.WriteLine(name);
//}



using Enums;


Gunler1 gun1 = Gunler1.Pazartesi;
Gunler1 gun2 = Gunler1.Carsamba;
Console.WriteLine((int)gun1);
Console.WriteLine((int)gun2);

Personel personel = new Personel()
{
    PersonelId = 1,
    Ad = "ie",
    Soyad = "g",
    TatilGunleri = Gunler1.Pazar
};
