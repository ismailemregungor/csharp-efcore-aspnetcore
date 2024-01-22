using EFCoreModelFirst2.Data;
using EFCoreModelFirst2.Models;

Console.WriteLine();

PersonelContext context = new PersonelContext();

//context.Bolumler.Add(new Bolum() { BolumAdi = "Muhasebe" });
//context.Bolumler.Add(new Bolum() { BolumAdi = "Satış" });
//context.SaveChanges();

//context.Projeler.Add(new Proje() { ProjeAdi = "KizilElma" });
//context.Projeler.Add(new Proje() { ProjeAdi = "Anka" });
//context.SaveChanges();

//Proje proje = context.Projeler.Find(1);

//Personel personel = new Personel() { Ad = "Cevdet", Soyad = "Korkmaz", BolumID = 1, Proje = proje };
//context.Personeller.Add(personel);
//context.SaveChanges();

/*
 * Olmayan yeni bir bölüme personel veya proje ataması yapmak istersek nasıl yaparız?
 */


// 1. Yöntem

//Proje proje = context.Projeler.Find(2);
//Bolum bolum = new Bolum { BolumAdi = "IK" };
//context.Bolumler.Add(bolum);

//context.Personeller.Add(new Personel
//{
//    Ad = "Selami",
//    Soyad = "Dursun",
//    Bolum = bolum,
//    BolumID = bolum.BolumID,
//    Proje = proje
//});

//context.SaveChanges();

// 2.Yöntem

Proje proje = context.Projeler.Find(2);

Personel personel = new Personel
{
    Ad = "Selami",
    Soyad = "Dursun",
    Bolum = new Bolum 
    { 
        BolumAdi = "IK2" 
    },
    Proje = proje
};

context.Personeller.Add(personel);
context.SaveChanges();


