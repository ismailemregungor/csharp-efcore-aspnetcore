using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalDLL
{
    public class Departman
    {
        public string Ad { get; set; }
        public DepartmanTipi Tip { get; set; }

        public List<Doktor> Doktorlar { get; set; }

        public List<Hemsire> Hemsireler { get; set; }

        public Departman(DepartmanTipi departmanTipi)
        {
            Tip = departmanTipi;
            Doktorlar = new List<Doktor>();
            Hemsireler = new List<Hemsire>();
        }

        public override string ToString()
        {
            return $"Tipi: {Tip}";
        }

        public void DoktorEkle(Doktor doktor)
        {
            Doktorlar.Add(doktor);
        }

        public void DoktorSil(Doktor doktor)
        {
            Doktorlar.Remove(doktor);
        }

        public Doktor DoktorBul(string ad, string soyad)
        {
            return Doktorlar.Find(d => d.Ad == ad && d.Soyad == soyad);
        }

        public void DoktorlarıListele()
        {
            foreach (var doktor in Doktorlar)
            {
                Console.WriteLine(doktor);
            }
        }

        public void HemsireEkle(Hemsire hemşire)
        {
            Hemsireler.Add(hemşire);
        }

        public void HemsireSil(Hemsire hemşire)
        {
            Hemsireler.Remove(hemşire);
        }

        public Hemsire HemsireBul(string ad, string soyad)
        {
            return Hemsireler.Find(h => h.Ad == ad && h.Soyad == soyad);
        }

        public void HemsireleriListele()
        {
            foreach (var hemsire in Hemsireler)
            {
                Console.WriteLine(hemsire);
            }
        }

    }
}
