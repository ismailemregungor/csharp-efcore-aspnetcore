using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalDLL
{
    public class Hasta : Kisi
    {
        public Cinsiyet Cinsiyet { get; set; }
        public KanGrubu KanGrubu { get; set; }

        public List<Randevu> Randevular { get; set; }

        public List<Recete> Receteler { get; set; }

        public Hasta()
        {
            Randevular = new List<Randevu>();
            Receteler = new List<Recete>();
        }

        public override string ToString()
        {
            return $"Ad: {Ad}, Soyad: {Soyad}, Yaş: {Yas}, Cinsiyet: {Cinsiyet}, Kan Grubu: {KanGrubu}";
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

        public void ReceteEkle(Recete recete)
        {
            Receteler.Add(recete);
        }

        public void ReceteSil(Recete recete)
        {
            Receteler.Remove(recete);
        }

        

        public void ReceteleriListele()
        {
            foreach (var recete in Receteler)
            {
                Console.WriteLine(recete);
            }
        }

    }
}
