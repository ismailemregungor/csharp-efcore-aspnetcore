using EFCoreDatabaseFirst2.Models;

Console.WriteLine();

ModelContext modelContext = new ModelContext();

var urunler = modelContext.Urunlers;

//Güncelle
var urun = urunler.Find(102);
urun.UrunAdi = ".............";

urunler.Remove(urunler.Find(103));
var yeniUrun = new Urunler { UrunId = 123, UrunAdi = "Bisiklet", Fiyat = 3000, KategoriId = 13 };

modelContext.Urunlers.Add(yeniUrun);

Console.WriteLine("Yeni Ürün State:  " + modelContext.Entry(yeniUrun).State.ToString());

// Değişiklikleri Database'e 
modelContext.SaveChanges();

void Listele<T>(List<T> values)
{
    Console.WriteLine();
    foreach (T value in values)
	{
		Console.WriteLine(value + " " + modelContext.Entry(value).State.ToString());
        Console.WriteLine();
    }
}

//Listele(urunler.ToList());
Listele(modelContext.Urunlers.ToList());
Listele(modelContext.Kategorilers.ToList());