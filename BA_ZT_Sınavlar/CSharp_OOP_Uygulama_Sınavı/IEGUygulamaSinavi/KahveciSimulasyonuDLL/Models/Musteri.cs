using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveciSimulasyonuDLL.Models
{
    public class Musteri : Kisi
    {
        public Siparis SiparisVer()
        {
            Console.WriteLine($"{Isim} adlı müşteri sipariş verdi.");
            var siparis = new Siparis { Musteri = this };
            return siparis;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
