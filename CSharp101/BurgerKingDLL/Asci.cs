using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerKingDLL
{
    public class Asci
    {
        public bool Musait { get; private set; } = true;
        public void HamburgerHazirla(Siparis siparis)
        {
            siparis.Durum = SiparisDurumu.Hazir;
        }
    }
}
