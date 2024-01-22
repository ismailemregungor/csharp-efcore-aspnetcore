using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events.Magaza
{
    public delegate void DepoDolduEventHandler(object sender);
    internal class Depo : IDepo
    {
        public event DepoDolduEventHandler DepoDoldu;
        List<Urun> _urunler;

        public int Kapasite { get; set; }

        public Depo(int kapasite)
        {
            _urunler = new List<Urun>();
            Kapasite = kapasite;   
        }
        public void UrunleriListele()
        {
            foreach (Urun urun in _urunler)
            {
                Console.WriteLine($"Ürün ID: {urun.UrunId}, Adı: {urun.UrunAdi}, Fiyatı: {urun.UrunFiyati}, Kategorisi: {urun.UrunKategorisi}");
            }
        }
        public void UrunEkle(Urun urun)
        {
            if (Kapasite > _urunler.Count)
            {
                _urunler.Add(urun);
            }
            else
            {
                DepoDoldu?.Invoke(urun);
            }
        }
        public void UrunCikar(int id)
        {
            foreach (Urun urun in _urunler)
            {
                if (urun.UrunId == id)
                {
                    _urunler.Remove(urun);
                }
            }
        }
    }
}
