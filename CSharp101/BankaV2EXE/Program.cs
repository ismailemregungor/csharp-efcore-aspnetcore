
using BankaV2DLL;

Banka banka = new Banka();

Personel personel1 = new Personel("Personel 1");
Personel personel2= new Personel("Personel 2");
Personel personel3 = new Personel("Personel 3");

Vezne vezne1 = new Vezne(personel1);
Vezne vezne2 = new Vezne(personel2);
Vezne vezne3 = new Vezne(personel3);

banka.Vezneler.Add(vezne1);
banka.Vezneler.Add(vezne2);
banka.Vezneler.Add(vezne3);

Musteri musteri1 = new Musteri
{
    Ad = "Musteri 1",
    Islem = new Islem(IslemTipi.ParaCekme)
};

Musteri musteri2 = new Musteri
{
    Ad = "Musteri 2",
    Islem = new Islem(IslemTipi.ParaYatirma)
};

Musteri musteri3 = new Musteri
{
    Ad = "Musteri 3",
    Islem = new Islem(IslemTipi.Havale)
};

banka.MusteriEkle(musteri1);
banka.MusteriEkle(musteri2);
banka.MusteriEkle(musteri3);

banka.MusteriListele();

banka.IslemYap();


