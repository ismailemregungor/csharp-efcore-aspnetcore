using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalDLL
{
    public class Recete
    {
        public DateTime Tarih { get; set; }
        public Hasta Hasta { get; set; }

        public Doktor Doktor { get; set; }

        public List<Ilac> Ilaclar { get; set; }

        public override string ToString()
        {
            return $"Tarih: {Tarih}, Doktor: {Doktor}, Hasta: {Hasta}";
        }

        public void İlacEkle(Ilac ilac)
        {
            Ilaclar.Add(ilac);
        }

        public void İlacSil(Ilac ilac)
        {
            Ilaclar.Remove(ilac);
        }

        public void IlaclarıListele()
        {
            foreach (var ilac in Ilaclar)
            {
                Console.WriteLine(ilac);
            }
        }

    }
}
