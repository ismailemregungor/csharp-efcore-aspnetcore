using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerKingDLL
{
    public class Kasa
    {
        public Musteri Musteri { get; private set; }

        public Siparis Siparis { get; private set; }

        public void SiparisAl(Siparis siparis)
        {
            Siparis = siparis;
            Musteri = siparis.Musteri;
        }
    }
}
