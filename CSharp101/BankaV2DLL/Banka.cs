using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaV2DLL
{
    public class Banka
    {
        public List<Vezne> Vezneler { get; set; }
        public Queue<Musteri> MusteriKuyrugu { get; set; }

        public Banka()
        {
            Vezneler = new List<Vezne>();
            MusteriKuyrugu = new Queue<Musteri>();
        }

        public void MusteriEkle(Musteri musteri)
        {
            MusteriKuyrugu.Enqueue(musteri);
            Console.WriteLine($"{musteri.Ad} isimli müşteri kuyruğa eklendi.");
        }

        public Musteri MusteriCikar()
        {
            if (MusteriKuyrugu.Count > 0)
            {
                var musteri = MusteriKuyrugu.Dequeue();
                Console.WriteLine($"{musteri.Ad} isimli müşteri kuyruktan çıkarılmıştır.");
                return musteri;
            }
            else
            {
                Console.WriteLine("Kuyruk boş. Müşteri çıkarılamaz.");
                return null;
            }
        }

        public void MusteriListele()
        {
            foreach (Musteri musteri in MusteriKuyrugu)
            {
                Console.WriteLine($"{musteri.Ad}");
            }
        }

        public void IslemYap()
        {
            if (MusteriKuyrugu.Count > 0)
            {
                var musaitVezne = Vezneler.FirstOrDefault(vezne => vezne.Durum == VezneDurumu.Musait);
                if (musaitVezne != null)
                {
                    var musteri = MusteriKuyrugu.Dequeue();
                    musaitVezne.IslemYap(musteri);
                }
                else
                {
                    Console.WriteLine("Tüm vezne personelleri meşgul. Lütfen bekleyiniz.");
                }
            }
            else
            {
                Console.WriteLine("Müşteri kuyruğunda kimse yok.");
            }
        }
    }
}
