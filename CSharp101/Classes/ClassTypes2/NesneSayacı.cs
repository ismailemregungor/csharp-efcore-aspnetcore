using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.ClassTypes2
{
    internal class NesneSayacı
    {
        private static int nesneSayisi = 0;

        public static int YeniNesne()
        {
            return ++nesneSayisi;
        }
    }
}
