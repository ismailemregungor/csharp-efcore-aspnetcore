using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_OpenClosedPrinciple.Yontem2
{
    internal class DosyaManager2
    {
        public string Oku(Dosya dosya, string path)
        {
            return dosya.DosyadanOku(path);
        }
    }
}
