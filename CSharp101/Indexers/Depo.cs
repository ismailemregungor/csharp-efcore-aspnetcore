using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    internal class Depo
    {
        private string[] _urunler = { "kalem", "silgi", "pergel", "gönye" };

        public string this[int indis]
        {
            get { return _urunler[indis];}
            set { _urunler[indis] = value;}
        }

    }
}
