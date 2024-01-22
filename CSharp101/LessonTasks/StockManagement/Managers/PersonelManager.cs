using LessonTasks.StockManagement.Models.Personel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonTasks.StockManagement.Managers
{
    internal class PersonelManager
    {
        private List<Personel> personeller = new List<Personel>();

        public void Baslat()
        {
            bool cikis = false;
            do
            {
                Console.Clear();
                Console.WriteLine("Personel Maaş Hesaplama Uygulaması");
                Console.WriteLine("1-Menü");
                Console.WriteLine("2-Personel verileri gir");
                Console.WriteLine("3-Listele");
                Console.WriteLine("4-Çıkış");
                string secim = Console.ReadLine();

                switch (secim)
                {
                    case "1":
                        break;
                    case "2":
                        PersonelVerisiGir();
                        break;
                    case "3":
                        PersonelListele();
                        break;
                    case "4":
                        cikis = true;
                        break;
                    default:
                        Console.WriteLine("Geçersiz seçenek!");
                        break;
                }
            } while (!cikis);
        }

        private void PersonelVerisiGir()
        {
            Console.Clear();
            Console.WriteLine("Personel Türünü Seçin (1-Tam Zamanlı, 2-Yarı Zamanlı):");
            string turSecim = Console.ReadLine();

            if (turSecim == "1")
            {
                TamZamanliPersonel.PersonelEkle(personeller);

            }
            else if (turSecim == "2")
            {
                YariZamanliPersonel.PersonelEkle(personeller);
            }
            else
            {
                Console.WriteLine("Geçersiz seçim!");
            }

            Console.Write("Devam etmek için bir tuşa basın...");
            Console.ReadKey();
        }

        private void PersonelListele()
        {
            Console.Clear();
            Console.WriteLine("Personel Listesi:");
            foreach (var personel in personeller)
            {
                Console.WriteLine(personel.MaaşBilgisiGetir());
            }

            Console.Write("Devam etmek için bir tuşa basın...");
            Console.ReadKey();
        }

        public static void PersonelEkle(List<Personel> personeller)
        {
            Console.Write("Ad: ");
            string ad = Console.ReadLine();
            Console.Write("Soyad: ");
            string soyad = Console.ReadLine();
            Console.Write("Çalıştığı Saat: ");
            int calismaSaati = Convert.ToInt32(Console.ReadLine());
            Console.Write("Saat Ücret: ");
            decimal saatUcret = Convert.ToDecimal(Console.ReadLine());
            TamZamanliPersonel tamZamanliPersonel = new TamZamanliPersonel(ad, soyad, calismaSaati, saatUcret);
            personeller.Add(tamZamanliPersonel);
            Console.WriteLine("Tam zamanlı personel eklendi.");
        }
    }
}

