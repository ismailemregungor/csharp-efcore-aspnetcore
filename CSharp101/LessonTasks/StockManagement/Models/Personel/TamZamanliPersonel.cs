using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonTasks.StockManagement.Models.Personel
{
    internal class TamZamanliPersonel : Personel
    {
        public decimal TabanUcret { get; set; }
        public decimal Prim { get; set; }

        public TamZamanliPersonel(string ad, string soyad, decimal tabanUcret, decimal prim) : base(ad, soyad)
        {
            TabanUcret = tabanUcret;
            Prim = prim;
        }

        public override decimal MaasHesapla()
        {
            decimal toplamPrim = 0;
            if (Prim <= 100000)
            {
                toplamPrim = Prim * 0.01m;
            }
            else if (Prim > 100000 && Prim <= 250000)
            {
                toplamPrim = Prim * 0.02m;
            }
            else
            {
                toplamPrim = Prim * 0.03m;
            }
            return TabanUcret + toplamPrim;
        }

        public override string MaaşBilgisiGetir()
        {
            return $"{Ad} {Soyad} (Tam Zamanlı): Maaş = {MaasHesapla()}";
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
