Console.WriteLine("Ödeme Yöntemi: 1: Kredi Kartı 2:EFT 3:Paypal");
int secim1 = int.Parse(Console.ReadLine());

if (secim1 == 1)
    Console.WriteLine("Kredi Karti");
if (secim1 == 2)
    Console.WriteLine("EFT");
if (secim1 == 3)
    Console.WriteLine("Paypal");

Console.WriteLine("**********************************************");
Console.WriteLine("Ödeme Yöntemi: 1: Kredi Kartı 2:EFT 3:Paypal");
int secim2 = int.Parse(Console.ReadLine());

if (secim2 == 1)
    Console.WriteLine("Kredi Karti");
else if (secim2 == 2)
    Console.WriteLine("EFT");
else if (secim2 == 3)
    Console.WriteLine("Paypal");


if (5 == 5 && 4 == 4)
{
    Console.WriteLine("Doğru!");
}

char secenek = Convert.ToChar(Console.ReadLine());
if (secenek == 'e' || secenek == 'E')
{
    Console.WriteLine("Çıkış başarılı!");
}

int secim2 = int.Parse(Console.ReadLine());
switch(secim2)
{
    case 1:
        Console.WriteLine("1");
        break;
    case 2:
        Console.WriteLine("2");
        break;  
    case 3:
    case 4:
        Console.WriteLine("3 veya 4");
        break;
    default:
        Console.WriteLine("1 2 3 4 değil");
        break;
}