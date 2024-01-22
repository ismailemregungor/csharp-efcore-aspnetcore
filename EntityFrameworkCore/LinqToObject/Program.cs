
//using LinqToObject;

//List<Kitap> kitaplar = new List<Kitap>()
//{
//    new Kitap{Id = 1, Adi = "Deneme1", Fiyat = 90, Kategori = "Deneme1"},
//    new Kitap{Id = 2, Adi = "Deneme2", Fiyat = 90, Kategori = "Deneme2"},
//    new Kitap{Id = 3, Adi = "Deneme3", Fiyat = 100, Kategori = "Deneme3"},
//    new Kitap{Id = 4, Adi = "Deneme4", Fiyat = 100, Kategori = "Deneme4"},
//    new Kitap{Id = 5, Adi = "Deneme5", Fiyat = 100, Kategori = "Deneme5"}
//};


// * Fiyatı 90 olan kitapları bulunuz.
// */

//// Foreach

//foreach (Kitap k in kitaplar)
//{
//    if (k.Fiyat == 90)
//    {
//        Console.WriteLine(k);
//    }
//}

//// LINQ ile yapalım.

//void Yaz(IEnumerable<Kitap> kitaplar)
//{
//    foreach (Kitap k in kitaplar)
//    {
//        Console.WriteLine(k);
//    }
//}

//// LINQ - Like SQL

//var result = from k in kitaplar
//             where k.Fiyat == 90
//             select k;

//Yaz(result);


//// LINQ - Expressions Methods

//// x => x
//// x => {...}
//// x => {return ...}
//// {x, y} => {...}

//var result2 = kitaplar.Where(x => x.Fiyat == 90);
//Yaz(result2);


////int id = 2;
////var result3 = from k in kitaplar
////             where k.Id == 2
////             select k;

////id = 3;
////Yaz(result3); // --> id = 3 olan sonucu döndürecektir.

// * LINQ sorguları deffered mode çalışır yani tanımlandığı yerde değil çağrıldığı yerde çalışır.
// * Sorgunun sonuna ToList(), ToArray(), ToDictionary() eklersek immediate mode'da çalışır yani tanımlandığı yerde.
// */

//int id = 2;
//var result3 = (from k in kitaplar
//             where k.Id == 2
//             select k).ToList();

//id = 3;
//Yaz(result3); // --> id = 2 olan sonucu döndürecektir çünkü ToList() kullandık.

// * LINQ Extension Methods
// */

//int[] sayilar = { 2, 4, 5, 6, 11, 7, 3 };
//Console.WriteLine(sayilar.Sum());
//Console.WriteLine(sayilar.Min());
//Console.WriteLine(sayilar.Max());
//Console.WriteLine(sayilar.Average());

/*
 * 
 */

using LinqToObject._2;

// Yazdir Metodu
// --> İstersek parametre olarak List<>'te geçebilirdik ama
// --> IEnumerable'ı parametre geçersek hem koleksiyonlar hemde dizi dahai göndersek kabul eder.

void Yazdir<T>(IEnumerable<T> list)
{
    Console.WriteLine();
    foreach (var item in list)
    {
        Console.WriteLine(item);
    }
}

UrunContext urunContext = new UrunContext();

// Ürünleri fiyatına göre sıralayan linq ifadesini yaziniz.

// LINQ - Like SQL 

var result1 = from x in urunContext.Urunler
              orderby x.Fiyat ascending
              select x;

var result2 = from x in urunContext.Urunler
              orderby x.Fiyat ascending
              select x;

Yazdir(result1);
Yazdir(result2);

// LINQ - Expression Tree

var result3 = urunContext.Urunler.OrderBy(x => x.Fiyat);

Yazdir(result3);

var result4 = urunContext.Urunler.OrderByDescending(x => x.Fiyat);

Yazdir(result4);

// Id'sine göre Z-A'ya Sıralayin

// LINQ - Like SQL

var result5 = from x in urunContext.Urunler
              orderby x.UrunId descending
              select x;

Yazdir(result5);

// LINQ - Expression Tree  

var result6 = urunContext.Urunler.OrderByDescending(x => x.UrunId);
Yazdir(result6);

// Sort() methodu

var result7 = urunContext.Urunler.OrderBy(x => x.UrunId.ToString()).ToList();
result7.Sort((a, b) => string.Compare(b.UrunId.ToString(), a.UrunId.ToString()));

Yazdir(result7);

// IComparable Interface'i ve CompareTo metodu ve Sort ile

var result8 = urunContext.Urunler.ToList();
result8.Sort();

Yazdir(result8);

/*
 * Urunler verisindeki id değerleri yerine Kategori isimleri gelsin. LINQ kullan
 * 1 - Like SQL ile
 * 2 - Expression Tree ile
 */

var urunlerWithKategoriLikeSQL = from urun in urunContext.Urunler
                              join kategori in urunContext.Kategoriler 
                              on urun.KategoriId equals kategori.KategoriId
                              select new
                              {
                                  urun.UrunId,
                                  urun.UrunAdi,
                                  urun.Fiyat,
                                  kategori.KategoriAdi
                              };

Yazdir(urunlerWithKategoriLikeSQL);

// Expression Tree 

var urunlerWithKategoriExpression = urunContext.Urunler
    .Join(urunContext.Kategoriler, urun => urun.KategoriId, kategori => kategori.KategoriId, (urun, kategori) => new
    {
        urun.UrunId,
        urun.UrunAdi,
        urun.Fiyat,
        kategori.KategoriAdi
    });

Yazdir(urunlerWithKategoriExpression);

/*
 * Kategorisi "Kırtasiye" olan ürünleri getiren sorguyu yazınız. LINQ kullan.
 * 1 - Like SQL ile
 * 2 - Expression Tree ile
 */

// LINQ - Like SQL

var urunlerWithKategoriKırtasiyeLikeSQL =
                                 from urun in urunContext.Urunler
                                 join kategori in urunContext.Kategoriler
                                 on urun.KategoriId equals kategori.KategoriId
                                 where kategori.KategoriAdi == "Kırtasiye"
                                 select urun;

Yazdir(urunlerWithKategoriKırtasiyeLikeSQL);

// LINQ - Expression Tree

var kirtasiyeUrunlerExpression = urunContext.Urunler
    .Join(urunContext.Kategoriler, urun => urun.KategoriId, kategori => kategori.KategoriId, (urun, kategori) => new
    {
        urun,
        kategori.KategoriAdi
    })
    .Where(uk => uk.KategoriAdi == "Kırtasiye")
    .Select(uk => uk.urun);

Yazdir(kirtasiyeUrunlerExpression);

/*
 * en pahalı 3 ürünü join ile getiren sorguyu yazınız.
 * 1 - Like SQL ile
 * 2 - Expression Tree ile
 */

/*
 * Tüm extension methodlar için Like SQL kullanımına özel
 * keywordler oluşturulmamaıştır.
 * Eğer başka ifadeleri kullanacak isek önceki ifade paranteze alınıp
 * istenilen extension method sonuna yazılır.
 */

var enPahaliUrunlerLikeSQL =      (from urun in urunContext.Urunler
                                  join kategori in urunContext.Kategoriler
                                  on urun.KategoriId equals kategori.KategoriId
                                  orderby urun.Fiyat descending
                                  select new
                                  {
                                       urun.UrunId,
                                       urun.UrunAdi,
                                       urun.Fiyat,
                                       kategori.KategoriAdi

                                  }).Take(3);

Yazdir(enPahaliUrunlerLikeSQL);


var enPahaliUrunlerExpression = urunContext.Urunler.Join(urunContext.Kategoriler, urun => urun.KategoriId, kategori => kategori.KategoriId,
    (urun, kategori) => new { urun.UrunId, urun.UrunAdi, urun.Fiyat, kategori.KategoriAdi }).OrderByDescending(u => u.Fiyat).Take(3);

Yazdir(enPahaliUrunlerExpression);