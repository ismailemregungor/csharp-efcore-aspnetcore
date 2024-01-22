using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LessonTasks.StokYonetimi.Models;

namespace LessonTasks.StokYonetimi.Managers
{
    internal class StokManager
    {
        private List<Urun> stok;

        public StokManager()
        {
            stok = new List<Urun>();
        }

        public void UrunEkle(Urun urun)
        {
            stok.Add(urun);
        }

        public List<Urun> TumUrunleriGetir()
        {
            return stok;
        }

        public List<Urun> BozukUrunleriGetir(string durum)
        {
            List<Urun> bozukUrunler = new List<Urun>();
            foreach (var urun in stok)
            {
                if (urun is Yumurta && ((Yumurta)urun).BozukMu(durum))
                {
                    bozukUrunler.Add(urun);
                }
            }
            return bozukUrunler;
        }

        public List<Urun> KirikUrunleriGetir(string durum)
        {
            List<Urun> kirikUrunler = new List<Urun>();
            foreach (var urun in stok)
            {
                if (urun is Yumurta && ((Yumurta)urun).KirikMi(durum))
                {
                    kirikUrunler.Add(urun);
                }
            }
            return kirikUrunler;
        }

        public List<Urun> SonKullanmaTarihiGecmisUrunleriGetir(DateTime tarih)
        {
            List<Urun> gecmisUrunler = new List<Urun>();
            foreach (var urun in stok)
            {
                if (urun is Yumurta && ((Yumurta)urun).SonKullanmaTarihiGecmisMi(tarih))
                {
                    gecmisUrunler.Add(urun);
                }
            }
            return gecmisUrunler;
        }

        public List<Urun> DeformeOlmusUrunleriGetir(string durum)
        {
            List<Urun> deformeliUrunler = new List<Urun>();
            foreach (var urun in stok)
            {
                if (urun is Yumurta && ((Yumurta)urun).DeformeOlmusMu(durum))
                {
                    deformeliUrunler.Add(urun);
                }
            }
            return deformeliUrunler;
        }
    }
}
