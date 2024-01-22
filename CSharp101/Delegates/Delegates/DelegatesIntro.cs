using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates.Delegates
{
    delegate void Temsilci();
    delegate string Temsilci2(string ad);
    public static class DelegatesIntro
    {
        public static void Merhaba()
        {
            Console.WriteLine("Merhaba...");
        }

        public static void Hi()
        {
            Console.WriteLine("Hi...");
        }

        public static void Hola()
        {
            Console.WriteLine("Hola...");
        }

        public static string Gunaydin()
        {
            return "Gündaydin...";
        }

        public static string IyiGunler(string ad)
        {
            return "İyi Günler..." + ad;
        }
    }
}
