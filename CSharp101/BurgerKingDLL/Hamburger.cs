using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerKingDLL
{
    public class Hamburger
    {
        public HamburgerTipi Tip { get; private set; }

        public List<Malzeme> Malzemeler { get; private set; }

        public Hamburger(HamburgerTipi tip)
        {
            Tip = tip;
            Malzemeler = new List<Malzeme>();
        }

        public void MalzemeEkle(Malzeme malzeme)
        {
            Malzemeler.Add(malzeme);
        }
    }
}
