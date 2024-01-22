
using EFCoreInheritanceStrategy.Data;
using EFCoreInheritanceStrategy.Models;

KisiContext context = new KisiContext();

context.Add(new Personel { Ad = "Cevdet", Soyad = "Korkmaz", Maas = 1500 });
context.Add(new Personel { Ad = "Temel", Soyad = "Deniz", Maas = 1600 });
context.Add(new Musteri { Ad = "Dursun", Soyad = "Durmasin", Cari = -1450 });
context.Add(new Musteri { Ad = "Derya", Soyad = "Akarsu", Cari = 3450 });
context.Add(new Musteri { Ad = "Celal", Soyad = " Bayrak", Cari = 120 });

context.SaveChanges();

//foreach (var item in context.Musteriler)
//{
//    Console.WriteLine(item.ID + " " + item.Cari);
//}