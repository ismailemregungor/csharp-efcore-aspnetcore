using Banka.Models.IslemModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Models.Vezne
{
    public class Vezne
    {
        public bool MusaitMi { get; private set; } = true;
        public Personel Personel { get; private set; }

        public Vezne(Personel personel)
        {
            Personel = personel;
        }

        public void IslemYap(Islem islem)
        {
            MusaitMi = false;
            Console.WriteLine($"{Personel.Ad}, bir müşteriye {islem.IslemAdi} işlemi için hizmet veriyor. Süre: {islem.Sure} dakika.");
            Thread.Sleep(islem.Sure * 1000);
            MusaitMi = true;
        }
    }
}
