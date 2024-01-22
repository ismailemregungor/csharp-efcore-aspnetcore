namespace ASP.NETCOREMVCKitap.Models
{
    public static class KitapDB
    {
        static int counter = 0;
        public static int Identity { get => ++counter; }
        public static List<Kitap> Kitaplar { get; set; }
        public static List<Kategori> Kategoriler { get; set; }
        public static List<Yazar> Yazarlar { get; set; }

        static KitapDB()
        {
            Kitaplar = new List<Kitap>();
            Kategoriler = new List<Kategori>() {
                new Kategori { KategoriID=1, KategoriAdi="Roman" },
                new Kategori { KategoriID=2, KategoriAdi="Makale" },
                new Kategori { KategoriID=3, KategoriAdi="Atlas" }

            };

            Yazarlar = new List<Yazar>()
            {
                new Yazar { YazarID=1, YazarAdSoyad="Dan Brown"},
                new Yazar { YazarID=2, YazarAdSoyad="Cevdet Korkmaz"},
                new Yazar { YazarID=3, YazarAdSoyad="Piri Reis"},
                new Yazar { YazarID=4, YazarAdSoyad="Adam Faver"}
            };
        }
    }
}
