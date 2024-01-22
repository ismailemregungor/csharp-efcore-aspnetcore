using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalDLL
{
    public class Doktor : Kisi
    {
        public int DeneyimYılı { get; set; }

        public Cinsiyet Cinsiyet { get; set; }
        public List<Randevu> Randevular { get; set; }

        public Doktor()
        {
            Randevular = new List<Randevu>();
        }

        public override string ToString()
        {
            return $"Ad: {Ad}, Soyad: {Soyad}, Cinsiyet: {Cinsiyet}, Deneyim Yılı: {DeneyimYılı}";
        }

        public void RandevuEkle(Randevu randevu)
        {
            Randevular.Add(randevu);
        }

        public void RandevuSil(Randevu randevu)
        {
            Randevular.Remove(randevu);
        }

        public void RandevularıListele()
        {
            foreach (var randevu in Randevular)
            {
                Console.WriteLine(randevu);
            }
        }

    }
}
