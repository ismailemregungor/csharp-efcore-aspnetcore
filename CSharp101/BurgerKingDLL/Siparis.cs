using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerKingDLL
{
    public class Siparis
    {
        public SiparisDurumu Durum { get; set; }
        public List<Hamburger> Hamburgerler { get; private set; }
        public Musteri Musteri { get; set; }

        public Siparis()
        {
            Hamburgerler = new List<Hamburger>();
            Durum = SiparisDurumu.Hazirlaniyor;
        }

        public void HamburgerEkle(Hamburger hamburger)
        {
            Hamburgerler.Add(hamburger);
        }
    }
}
