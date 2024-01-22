//using Constructors.Constructors1;

//Console.WriteLine();
//Category category = new Category(123,"ie");
//Category category1 = new Category()
//{
//    CategoryId = 1,
//    Name = "ieg"
//};

//// Anonymous Type(Object)
//var fn = new { ID = 123, Ad = "aaaa" };

//Book book = new Book { BookId = 11, Price = 12, Name = "Olasılıksız" };

//using Constructors.Constructors2;

//Console.WriteLine();

//Book book = new Book()
//{

//};

//Book book1 = new Book()
//{
//   BookId = 1
//};

//Book book2 = new Book()
//{
//   BookId = 1,
//   Name = "deneme1"
//};

//Book book3 = new Book()
//{
//    BookId = 1,
//    Name = "deneme2",
//    Price = 30000
//};

//Book book4 = new Book()
//{
//    BookId = 1,
//    Name = "deneme3",
//    Price = 30000,
//    Description = "acıklama"
//};

//Book book = new Book(0);
//Console.WriteLine(book);

//Book book1 = new Book(1, "deneme1");
//Console.WriteLine(book1);

//Book book3 = new Book(2, "deneme2", 30000);
//Console.WriteLine(book3);

//Book book4 = new Book(2, "deneme3", 30000, "aciklama3");
//Console.WriteLine(book3);

//using Constructors.Constructors3;

//Console.WriteLine();
//Product product = new Product(1, "Test", -100);

//Urun urun = new Urun(2, "Test", -100);
//Console.WriteLine(urun.UrunFiyati);

using Constructors.ReadonlyVSConst;

Matematik matematik = new Matematik();
Console.WriteLine(matematik);

Islemler islemler = new Islemler(1.5);
// islemler.katsayi = 1.4;
Console.WriteLine(islemler.katsayi);
