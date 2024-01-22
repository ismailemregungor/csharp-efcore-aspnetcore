using BurgerKingDLL;

BurgerKing burgerKing = new BurgerKing();

// Müşteri oluşturulur.
Musteri musteri1 = new Musteri("Ahmet");

// Sipariş ve hamburger oluşturulur.
Siparis siparis1 = new Siparis();

Hamburger hamburger1 = new Hamburger(HamburgerTipi.Cheeseburger);

// Malzemeler oluşturulur ve hamburger'e eklenir.
Malzeme ekmek = new Malzeme(MalzemeTipi.Ekmek);
Malzeme kofte = new Malzeme(MalzemeTipi.Kofte);
hamburger1.MalzemeEkle(ekmek);
hamburger1.MalzemeEkle(kofte);

// Hamburger siparişe eklenir.
siparis1.HamburgerEkle(hamburger1);

// Sipariş müşteriye atanır.
musteri1.SiparisVer(siparis1);

// Müşteri ve sipariş hamburgerciye eklenir.
burgerKing.MusteriEkle(musteri1);
burgerKing.SiparisAl(siparis1);

burgerKing.SiparisHazirla(siparis1);
burgerKing.MusterileriListele();
musteri1.SiparisiGoster();

