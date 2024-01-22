using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    public class ValueTypeVSReferenceType
    {
        static void Islem(int sayi)
        {
            sayi = 999;
        }

        static void Islem(int[] sayilar)
        {
            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = 999;
            }
        }

        static void DiziYaz(int[] sayilar)
        {
            foreach (var sayi in sayilar)
            {
                Console.Write(sayi + " ");
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            int number = 111;
            Console.WriteLine("Metodu Çağırmadan Önce " + number);
            Islem(number);
            Console.WriteLine("Metodu Çağırdıktan Sonra " + number);

            int[] numbers = { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine("Metodu Çağırmadan Önce ");
            DiziYaz(numbers);
            Islem(numbers);
            Console.WriteLine("Metodu Çağırdıktan Sonra ");
            DiziYaz(numbers);

            /*
             *Sistem değer tipli bir parametrenin bir kopyasını oluşturuyor ve onu gönderiyor.
             *Bu yüzden orjinel değeri değişmiyor kopyasının değeri değişiyor.
             *Ama referans tipli bir parametrenin direk ramdeki adresi gönderilir ve 
             *orjinal değer üzerinden işlem yapar ve değerler değişir.
             *Çünkü değer tiplerinin bellek kapladığı alan küçükken
             *referans tiplerin bellekte kapladığı alan çok büyük olabilir.
             *Özetle:
             *Değerli tipl iverilerin kopyasını al gönder
             *Referans tipli verilerin bellekteki adresini al gönder
             *
             *Bu olay performans ve bellek yönetimi için böyle geliştirilmiştir.
             */

        }
    }
}
