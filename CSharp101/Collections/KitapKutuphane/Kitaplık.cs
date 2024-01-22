using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.KitapKutuphane
{
    internal class Kitaplık
    {
        private ArrayList _kitaplar = new ArrayList();

        public void Ekle(Kitap kitap)
        {
            _kitaplar.Add(kitap);
        }

        public ArrayList Listele()
        {
            return _kitaplar;
        }
    }
}
