using HospitalDLL;

using System;

class Program
{
    static void Main()
    {
        Hastane hastane = new Hastane("Örnek Hastane");

        // Departmanları Ekleyelim
        Departman kardiyoloji = new Departman(DepartmanTipi.Kardiyoloji);
        Departman ortopedi = new Departman(DepartmanTipi.Ortopedi);
        hastane.DepartmanEkle(kardiyoloji);
        hastane.DepartmanEkle(ortopedi);

        Console.WriteLine("Hastanedeki Departmanlar:");
        hastane.DepartmanlarıListele();

        // Doktorları Ekleyelim
        Doktor drYilmaz = new Doktor { Ad = "Dr. Yılmaz", Soyad = "Demir", Cinsiyet = Cinsiyet.Erkek};
        Doktor drAyse = new Doktor { Ad = "Dr. Ayşe", Soyad = "Yıldız", Cinsiyet = Cinsiyet.Kadın};
        kardiyoloji.DoktorEkle(drYilmaz);
        ortopedi.DoktorEkle(drAyse);

        Console.WriteLine("\nKardiyoloji Departmanındaki Doktorlar:");
        kardiyoloji.DoktorlarıListele();

        Console.WriteLine("\nOrtapedi Departmanındaki Doktorlar:");
        ortopedi.DoktorlarıListele();

        // Hemşireleri Ekleyelim
        Hemsire hemsireAylin = new Hemsire { Ad = "Aylin", Soyad = "Kara", Cinsiyet = Cinsiyet.Kadın };
        Hemsire hemsireAli = new Hemsire { Ad = "Ali", Soyad = "Ak", Cinsiyet = Cinsiyet.Erkek };
        kardiyoloji.HemsireEkle(hemsireAylin);
        ortopedi.HemsireEkle(hemsireAli);

        Console.WriteLine("\nOrtopedi Departmanındaki Hemşireler:");
        ortopedi.HemsireleriListele();

        Console.WriteLine("\nKariyoloji Departmanındaki Hemşireler:");
        kardiyoloji.HemsireleriListele();

        // Hastaları Ekleyelim
        Hasta hastaMehmet = new Hasta { Ad = "Mehmet", Soyad = "Yılmaz", Cinsiyet = Cinsiyet.Erkek, KanGrubu = KanGrubu.A };
        Hasta hastaAyse = new Hasta { Ad = "Ayşe", Soyad = "Kara", Cinsiyet = Cinsiyet.Kadın, KanGrubu = KanGrubu.B };

        // Randevu Alalım
        Randevu randevu1 = new Randevu(drYilmaz, hastaMehmet, new DateTime(2022, 10, 10));
        Randevu randevu2 = new Randevu(drAyse, hastaAyse, new DateTime(2022, 10, 10));

        drYilmaz.RandevuEkle(randevu1);
        drAyse.RandevuEkle(randevu2);
        Console.WriteLine("\nDr. Yılmaz'ın Randevuları:");
        drYilmaz.RandevularıListele();

        Console.WriteLine("\nDr. Ayse'ın Randevuları:");
        drAyse.RandevularıListele();

        hastaMehmet.RandevuEkle(randevu1);
        Console.WriteLine("\nMehmet'in Randevuları:");
        hastaMehmet.RandevularıListele();

        hastaAyse.RandevuEkle(randevu2);
        Console.WriteLine("\nAyse'in Randevuları:");
        hastaAyse.RandevularıListele();




    }
}



