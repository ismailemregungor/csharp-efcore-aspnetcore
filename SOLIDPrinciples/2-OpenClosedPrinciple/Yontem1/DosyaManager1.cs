using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_OpenClosedPrinciple.Yontem1
{
    public class DosyaManager1
    {
        public string Oku(IDosya dosya, string path)
        {
            return dosya.DosyadanOku(path);
        }
    }
}
