using Banka.Models.Musteri;
using Banka.Models.Vezne;
using Banka;

Banka.Banka banka = new Banka.Banka();

banka.VezneEkle(new Vezne(new Personel("Personel1")));
banka.VezneEkle(new Vezne(new Personel("Personel2")));
banka.VezneEkle(new Vezne(new Personel("Personel3")));

banka.MusteriEkle(new Musteri("Müşteri1"));
banka.MusteriEkle(new Musteri("Müşteri2"));
banka.MusteriEkle(new Musteri("Müşteri3"));
banka.MusteriEkle(new Musteri("Müşteri4"));
banka.MusteriEkle(new Musteri("Müşteri5"));

banka.IslemYap();
banka.IslemYap();
banka.IslemYap();
banka.IslemYap();

Console.WriteLine("İşlemler tamamlandı.");