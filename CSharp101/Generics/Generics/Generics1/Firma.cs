using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.Generics.Generics1
{
    internal class Firma
    {
        public void DiziYazdir(string[] dizi)
        {
            foreach (string eleman in dizi)
            {
                Console.WriteLine(eleman);
            }
        }

        public void DiziYazdir(double[] dizi)
        {
            foreach (double eleman in dizi)
            {
                Console.WriteLine(eleman);
            }
        }

        public void DiziYazdir(int[] dizi)
        {
            foreach (int eleman in dizi)
            {
                Console.WriteLine(eleman);
            }
        }

        public void GenericDiziYazdir<T>(T[] genericdizi)
        {
            foreach (T eleman in genericdizi)
            {
                Console.WriteLine(eleman);
            }
        }
    }
}
