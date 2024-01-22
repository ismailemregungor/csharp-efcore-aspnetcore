
using ForeignKeyDeleteBehaviour.Models;

ModelContext modelContext = new ModelContext();
void Listele<T>(List<T> values)
{
    Console.WriteLine();
    foreach (T value in values)
    {
        Console.WriteLine(value);
        Console.WriteLine();
    }
}

// .OnDelete(DeleteBehavior.NoAction)
// Child kaydı olan kategoriyi sil : Oyuncak 
//var kategori = modelContext.Kategorilers.Find(11);
//modelContext.Kategorilers.Remove(kategori);
//modelContext.SaveChanges();
// Sonuç: Hata verir, çünkü child kayıtlar var.
// Çözüm: Önce tüm child'ları sil sonra kategoriyi sil.
// Bir kayıt Foreign Key olarak başka kaydı refere etmemesi gerekir.

// Hiç child olmayan kategoriyi sil : Bahçe
//var kategori = modelContext.Kategorilers.Find(14);
//modelContext.Kategorilers.Remove(kategori);
//modelContext.SaveChanges();
// Sonuç: 14 id'li bahçe kategorisi silindi. çünkü ilişkili child verisi yoktu.

// .OnDelete(DeleteBehavior.SetNull)
// Child kaydı olan kategoriyi sil : Oyuncak
//var kategori = modelContext.Kategorilers.Find(11);
//modelContext.Kategorilers.Remove(kategori);
//modelContext.SaveChanges();
//Sonuç: Eğer FK olan alan Urun sınıfındaki KategoriId nullable değilse hata verir
// Nullable yaptıktan sonra Oyuncak kategorisi silindi ve child verilerin FK'laru null oldu.
// Orphan Records(Dikkatli olmak gerekir...)


// .OnDelete(DeleteBehavior.Cascade)
// Child kaydı olan kategoriyi sil : Kitap
var kategori = modelContext.Kategorilers.Find(12);
modelContext.Kategorilers.Remove(kategori);
modelContext.SaveChanges();
// Sonuç: Kategori tablosundan istenilen kaydı ve o kayıtla ilişkili child kayıtlarıda siler.

// ClientCascade, ClientSetNull, ClientNoAction
// client ile başalyanlar; Database üzerinde değil context nesnesi üzerinde uygular.

Listele(modelContext.Urunlers.ToList());
Listele(modelContext.Kategorilers.ToList());