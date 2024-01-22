using KahveciSimulasyonuDLL;
using KahveciSimulasyonuDLL.Enums;
using KahveciSimulasyonuDLL.Managers;
using KahveciSimulasyonuDLL.Models;


//// Kahve Dükkanı ve Çalışanları İnitialize Et
KahveDukkani starbucks = new KahveDukkani();

// Kahve Dükkanı ve Çalışanları İnitialize Et
starbucks.CalisanEkle(new Calisan { Isim = "Ali", Durum = CalisanDurumu.Musait, Konum = CalisanKonumu.Kasa });
starbucks.CalisanEkle(new Calisan { Isim = "Murat", Durum = CalisanDurumu.Musait, Konum = CalisanKonumu.Kasa });
starbucks.CalisanEkle(new Calisan { Isim = "Ayşe", Durum = CalisanDurumu.Musait, Konum = CalisanKonumu.UrunHazirlama });


// Ürünleri ve Envanterleri İnitialize Et
Urun americano = new Urun { Ad = "Americano", Tip = UrunTipi.Americano, HazirlanmaSuresi = 2, Fiyat = 15, BegenilmeOrani = 80 };
Urun latte = new Urun { Ad = "Latte", Tip = UrunTipi.Latte, HazirlanmaSuresi = 3, Fiyat = 20, BegenilmeOrani = 90 };
Envanter vanilya = new Envanter { Ad = "Vanilya", EkstraSure = 1, EkstraFiyat = 2 };

starbucks.Urunler.Add(americano);
starbucks.Urunler.Add(latte);
starbucks.Envanterler.Add(vanilya);

// Müşterileri İnitialize Et ve Sipariş Verdir
Musteri musteri1 = new Musteri { Isim = "Mehmet" };
Siparis siparis1 = musteri1.SiparisVer();
siparis1.Urun = americano;
starbucks.SiparisAl(siparis1);



Musteri musteri2 = new Musteri { Isim = "Aylin" };
Siparis siparis2 = musteri2.SiparisVer();
siparis2.Urun = latte;
siparis2.Ekstralar.Add(vanilya);
starbucks.SiparisAl(siparis2);

// Sipariş Hazırla ve Teslim Et
starbucks.SiparisHazirla();
starbucks.SiparisTeslimEt(siparis1);
starbucks.SiparisTeslimEt(siparis2);






