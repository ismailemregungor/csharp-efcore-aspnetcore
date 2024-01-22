using Banka.Models.IslemModels;
using Banka.Models.Musteri;
using Banka.Models.Vezne;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka
{
    public class Banka
    {
        public List<Vezne> Vezneler { get; private set; }
        public Queue<Musteri> MusteriKuyrugu { get; private set; }

        public Banka()
        {
            Vezneler = new List<Vezne>();
            MusteriKuyrugu = new Queue<Musteri>();
        }

        public void MusteriEkle(Musteri musteri)
        {
            MusteriKuyrugu.Enqueue(musteri);
        }

        public void VezneEkle(Vezne vezne)
        {
            Vezneler.Add(vezne);
        }

        public void IslemYap()
        {
            foreach (Vezne vezne in Vezneler)
            {
                if (vezne.MusaitMi && MusteriKuyrugu.Count > 0)
                {
                    var musteri = MusteriKuyrugu.Dequeue();
                    var islem = RastgeleIslemOlustur();
                    Console.WriteLine($"{musteri.Ad} isimli müşteri vezneden çağrıldı.");
                    vezne.IslemYap(islem);
                }
            }
        }

        private Islem RastgeleIslemOlustur()
        {
            var rastgele = new Random();
            var islemTuru = rastgele.Next(3);
            switch (islemTuru)
            {
                case 0:
                    return new Havale();
                case 1:
                    return new ParaCekme();
                case 2:
                    return new ParaYatirma();
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }

}
