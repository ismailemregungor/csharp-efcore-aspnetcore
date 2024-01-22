using EFCoreIntro;
using EFCoreIntro.ExtensionMethods;
// * var keyword
// */

//var d1 = 10;
//var d2 = 20;
////var d1 = "ieg";

// * C# 4.0 dynmaic keyword
// */

//dynamic d10 = "ieg";
//d10 = 123;
//d10 = 110;

//object obj1 = 12;
////int sayi1 = obj1; --> tip dönüşümü gerekir.

//dynamic obj2 = 13;
//int sayi2 = obj2;

/*
 * Object Initializer
 * 
 */



/*
 * Extension Methods
 */


int number = 10;
Console.WriteLine(number.KareAl());
Console.WriteLine(number.KupAl());
Console.WriteLine(number.IkiyeBol());
Console.WriteLine(18.0.IstenilenSayiyaBol(6));

string original = "ieg";
Console.WriteLine(original.TersCevir());


/*
 * Expression Tree
 */




/*
 * LINQ sorguları iki şekilde yazılır:
 * 1-ExpressionTree
 * 2-Like SQL
 */


