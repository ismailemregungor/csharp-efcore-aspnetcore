using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.ClassTypes2
{
    internal class Asker
    {
        private static int askerSayisi = 0;

        public Asker()
        {
            askerSayisi++;
            Console.WriteLine("Toplam Asker Sayısı = " + askerSayisi);
        }
    }
}
