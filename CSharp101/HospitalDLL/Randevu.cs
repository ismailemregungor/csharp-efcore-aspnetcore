using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalDLL
{
    public class Randevu
    {
        public DateTime Tarih { get; set; }
        public Hasta Hasta { get; set; }
        public Doktor Doktor { get; set; }

        public Randevu(Doktor doktor, Hasta hasta, DateTime tarih)
        {
            Tarih = tarih;
            Hasta = hasta;
            Doktor = doktor;
        }

        public override string ToString()
        {
            return $"Tarih: {Tarih}, Doktor: {Doktor}, Hasta: {Hasta}";
        }

    }
}
