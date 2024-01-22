using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalDLL
{
    public class Hastane
    {
        public string Ad { get; set; }
        public List<Departman> Departmanlar { get; set; }
        public List<Hasta> Hastalar { get; set; }

        public Hastane(string ad)
        {
            Ad = ad;
            Departmanlar = new List<Departman>();
            Hastalar = new List<Hasta>();
        }

        public override string ToString()
        {
            return $"Hastane Adı: {Ad}";
        }

        public void DepartmanEkle(Departman departman)
        {
            Departmanlar.Add(departman);
        }

        public void DepartmanSil(Departman departman)
        {
            Departmanlar.Remove(departman);
        }

        public void DepartmanlarıListele()
        {
            foreach (var departman in Departmanlar)
            {
                Console.WriteLine(departman);
            }
        }


        public Departman DepartmanBul(string ad)
        {
            return Departmanlar.Find(d => d.Ad == ad);
        }

        public void HastaEkle(Hasta hasta)
        {
            Hastalar.Add(hasta);
            Console.WriteLine($"{hasta.Ad} isimli hasta sisteme eklenmiştir.");
        }

    }
}
