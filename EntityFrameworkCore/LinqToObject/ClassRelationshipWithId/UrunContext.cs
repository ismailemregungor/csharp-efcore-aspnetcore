using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToObject._2
{
    public class UrunContext
    {
        public List<Urun> Urunler { get; set; }
        public List<Kategori> Kategoriler { get; set; }

        public UrunContext()
        {
            Urunler = new List<Urun>()
            {
                new Urun(){ UrunId = 123, UrunAdi = "Defter", Fiyat = 44, KategoriId = 1},
                new Urun(){ UrunId = 124, UrunAdi = "Pergel", Fiyat = 55, KategoriId = 1},
                new Urun(){ UrunId = 125, UrunAdi = "Maket Uçak", Fiyat = 1200, KategoriId = 2},
                new Urun(){ UrunId = 126, UrunAdi = "Anahtarlık", Fiyat = 20, KategoriId = 3},
                new Urun(){ UrunId = 127, UrunAdi = "İsimlik", Fiyat = 25, KategoriId = 3},
                new Urun(){ UrunId = 128, UrunAdi = "T-Shirt", Fiyat = 100, KategoriId = 4}
            };

            Kategoriler = new List<Kategori>()
            {
                new Kategori(){ KategoriId = 1, KategoriAdi = "Kırtasiye"},
                new Kategori(){ KategoriId = 2, KategoriAdi = "Hobi"},
                new Kategori(){ KategoriId = 3, KategoriAdi = "Hediyelik"},
                new Kategori(){ KategoriId = 4, KategoriAdi = "Tekstil"}
            };
        }
    }
}
