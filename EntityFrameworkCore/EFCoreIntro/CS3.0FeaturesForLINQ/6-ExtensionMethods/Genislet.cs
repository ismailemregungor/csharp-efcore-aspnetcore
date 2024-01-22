using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreIntro.ExtensionMethods
{
    public static class Genislet
    {
        public static int KareAl(this int sayi)
        {
            return sayi * sayi;
        }

        public static int KupAl(this int sayi)
        {
            return sayi * sayi * sayi;
        }

        public static int IkiyeBol(this int sayi)
        {
            return sayi / 2;
        }

        public static double IstenilenSayiyaBol(this double sayi, int sayi2)
        {
            return sayi / sayi2;
        }

        public static string TersCevir(this string kelime)
        {
            string str =  "";
            for (int i = kelime.Length; i >=0; i--)
            {
                str += kelime[i];
            }
            return str;
        }
    }
}
