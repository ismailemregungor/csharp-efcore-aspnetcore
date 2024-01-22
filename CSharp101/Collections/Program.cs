//using System.Collections;

//// ArrayList oluşturma
//ArrayList arrayList = new ArrayList();

//// ArrayList Count ve Capacity prop'ları
//Console.WriteLine($"Adet = {arrayList.Count} Kapasite = {arrayList.Capacity}");

//// ArrayList'e döngü ile veri ekleme
//for (int i = 0; i < 3; i++)
//{
//    arrayList.Add(10);
//}
//Console.WriteLine($"Adet = {arrayList.Count} Kapasite = {arrayList.Capacity}");

//// ArrayList'e manuel veri ekleme
//arrayList.Add("ieg");
//arrayList.Add('i');

//Console.WriteLine($"Adet = {arrayList.Count} Kapasite = {arrayList.Capacity}");
//Console.WriteLine();

//// Arraylisti foreach ile gezme
//foreach (var obj in arrayList)
//{
//    Console.WriteLine(obj);
//}
//Console.WriteLine();

//// Arraylisti for ile gezme
//for (int i = 0; i < arrayList.Count; i++)
//{
//    Console.WriteLine(arrayList[i]);
//}
//Console.WriteLine();

//// AddRange()
//int[] sayilar = { 44, 55, 77, 99 };
//arrayList.AddRange(sayilar);

//foreach (var obj in arrayList)
//{
//    Console.WriteLine(obj);
//}

//// veriler aynı tip ise çalışır farklı tiplerde hata verir çözümğ interface kullanımı.
//arrayList.Sort();


//using System.Collections;

//Stack stack = new Stack();
//stack.Push(123);
//stack.Push(126);
//stack.Push(127);

//Console.WriteLine(stack.Peek());
//Console.WriteLine(stack.Count);
//Console.WriteLine(stack.Pop());
//Console.WriteLine(stack.Count);

//foreach (var item in stack)
//{
//    Console.WriteLine(item);
//}

//using System.Collections;

//Queue queue = new Queue();
//queue.Enqueue("İstanbul");
//queue.Enqueue("Ankara");
//queue.Enqueue("Bursa");

//Console.WriteLine(queue.Peek());
//Console.WriteLine(queue.Count);
//Console.WriteLine(queue.Dequeue());
//Console.WriteLine(queue.Count);

//foreach (var item in queue)
//{
//    Console.WriteLine(item);
//}

//using System.Collections;

//Hashtable hashtable = new Hashtable();
//hashtable.Add(34, "İstanbul");
//hashtable.Add(06, "Ankara");
//hashtable.Add(35, "İzmir");

//Console.WriteLine(hashtable[34]);

/*
 * Birden fazla kitap nesnesinin tutulduğu bir kitaplık nesnesi
 * oluşturup, tüm kitapları listeleyen, ekleyen kodu yazınız.
 * KitapId, KitapAdi, YazarAdi, KitapFiyatı
 */

using Collections.BookLibrary;
using Collections.KitapKutuphane;

Library library = new Library();

Book book1 = new Book(1, "Harry Potter and the Philosopher's Stone", "J.K. Rowling", 2599);
Book book2 = new Book(2, "To Kill a Mockingbird", "Harper Lee", 1999);

library.KitapEkle(book1);
library.KitapEkle(book2);
library.KitapListele();





