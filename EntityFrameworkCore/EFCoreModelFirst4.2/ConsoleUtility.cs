using EFCoreModelFirst4._2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreModelFirst4._2
{
    public static class ConsoleUtility
    {
        public static Urun UrunVerisiAl(bool idAl = false)
        {
            Urun urun = new Urun();
            if (idAl)
            {
                Console.Write("UrunID si Giriniz ");
                urun.UrunID = int.Parse(Console.ReadLine());
            }
            Console.Write("Urun Adi  Giriniz");
            urun.UrunAdi = Console.ReadLine();

            Console.Write("Fiyat  Giriniz");
            urun.Fiyat = double.Parse(Console.ReadLine());

            Console.Write("Kategori ID Giriniz");
            urun.KategoriID = int.Parse(Console.ReadLine());

            return urun;
        }

        public static void Listele<T>(List<T> liste)
        {
            Console.WriteLine(typeof(T).Name + "  Listesi");
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }
        }

        public static Kategori KategoriVerisiAl(bool idAl = false)
        {
            Kategori kategori = new Kategori();
            if (idAl)
            {
                Console.Write("KategoriID si Giriniz ");
                kategori.KategoriID = int.Parse(Console.ReadLine());
            }
            Console.Write("Kategori Adi  Giriniz");
            kategori.KategoriAdi = Console.ReadLine();

            return kategori;
        }
    }
}
