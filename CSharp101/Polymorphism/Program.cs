//using Polymorphism.Poly1;

// * Poly1
// */

//Araba araba = new Araba();
//Ferrari ferrari= new Ferrari();
//Serce serce = new Serce();

//araba.Sur();
//ferrari.Sur();
//serce.Sur();

//Araba araba1= new Araba();
//Araba ferrari1 = new Ferrari();
//Araba serce1 = new Serce();

//araba1.Sur();
//ferrari1.Sur();
//serce1.Sur();

//Console.WriteLine(ferrari1.ToString());

/*
 * Poly2
 * Daire, Silindir, Koni örneğini polymorphizm kullanarak tekrar yazınız.
 */

using Polymorphism.Poly2;
using System.Collections;

Daire daire = new Daire()
{
    r = 5
};

Daire silindir = new Silindir()
{
    r = 5,
    h = 16
};

Silindir koni = new Silindir()
{
    r = 5,
    h = 10
};


Console.WriteLine(daire.AlanHesapla());
Console.WriteLine(silindir.AlanHesapla());
Console.WriteLine(koni.AlanHesapla());

ArrayList sekiller = new ArrayList();
sekiller.Add(daire);
sekiller.Add(silindir);
sekiller.Add(koni);

foreach (Daire sekil in sekiller)
{
    Console.WriteLine(sekil.AlanHesapla());
}