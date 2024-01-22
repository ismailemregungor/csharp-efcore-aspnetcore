using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Interfaces2
{
    internal class Depo : IEnumerable
    {
        // ArrayList _urunler1 = new ArrayList();
        string[] _urunler = { "kalem", "silgi", "defter" };

        public IEnumerator GetEnumerator()
        {
            return _urunler.GetEnumerator();
        }
    }
}
 