using EFCoreDataLoading.Models;
using Microsoft.EntityFrameworkCore;

ModelContext context = new ModelContext();

/*
 * 1-Eager Loading
 */

//var result1 = context.Urunlers;
//Console.WriteLine(result1.ToQueryString());
//foreach (var item in result1)
//{
//    Console.WriteLine($"{item.UrunId} {item.UrunAdi} {item.Fiyat} {item.Kategori.KategoriId}");
//}
////Hata verir : join olmadan kategori adına ulaşma çalışıyoruz.

////Çözüm: EagerLoading - Include

//var result2 = context.Urunlers.Include("Kategori");
//Console.WriteLine(result2.ToQueryString());

//foreach (var item in result2)
//{
//    Console.WriteLine($"{item.UrunId} {item.UrunAdi} {item.Fiyat} {item.Kategori.KategoriId}");
//}

/*
 * 2-Explict Loading
 */

//var oyuncakKategori = context.Kategorilers.FirstOrDefault(x => x.KategoriAdi == "Oyuncak");

//Console.WriteLine($"{oyuncakKategori.KategoriId} {oyuncakKategori.KategoriAdi} {oyuncakKategori.Urunlers.Count()}");

//// Çalıştığında alt elemanlar gelir.
//// Many yani Icollection için Collection kullanılır.

//context.Entry(oyuncakKategori).Collection(x=>x.Urunlers).Load();

//Console.WriteLine($"{oyuncakKategori.KategoriId} {oyuncakKategori.KategoriAdi} {oyuncakKategori.Urunlers.Count()}");

//foreach (var item in oyuncakKategori.Urunlers)
//{
//    Console.WriteLine($"{item.UrunId} {item.UrunAdi}");
//}

//// Eğer ürün üzerinden kategoriye gidilecekse:

//var tren = context.Urunlers.FirstOrDefault(x=>x.UrunId == 100);

//context.Entry(tren).Reference(x=>x.Kategori).Load();
//Console.WriteLine(tren.UrunId + " " + tren.Kategori.KategoriAdi);


/*
 * 3-Lazy Loading
 * Nuget > Microsoft.EntityFrameworkCore.Proxies indir
 * Navigation Property'ler virtual olarak işaretlenir.
 * Context sınıfındaki OnConfugiring() metodu içerisinde aşağıdaki kod eklenmeli
optionsBuilder.UseLazyLoadingProxies();
 */


//var result1 = context.Urunlers;
//Console.WriteLine(result1.ToQueryString());
//foreach (var item in result1)
//{
//    Console.WriteLine($"{item.UrunId} {item.UrunAdi} {item.Fiyat} {item.Kategori.KategoriId}");
//}

/*
 * FromSqlRaw():
 * EntityFrameworkCore'da istenildiğinde SQL cümleleri yazılarak sorgular çalıştırılabilir.
 */

var result = context.Urunlers.FromSqlRaw("SELECT * FROM URUNLER");

foreach (var item in result)
{
    Console.WriteLine($"{item.UrunId} {item.UrunAdi}");
}

