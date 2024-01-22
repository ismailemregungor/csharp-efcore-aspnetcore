using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonTasks.StockManagement.Models.Personel
{
    internal class YariZamanliPersonel : Personel
    {
        public int CalismaSaati { get; set; }
        public decimal SaatUcret { get; set; }
        public YariZamanliPersonel(string ad, string soyad, int calismaSaati, decimal saatUcret) : base(ad, soyad)
        {
            CalismaSaati = calismaSaati;
            SaatUcret = saatUcret;
        }

        public override decimal MaasHesapla()
        {
            decimal prim = CalismaSaati * SaatUcret * 0.01m;
            return (CalismaSaati * SaatUcret) + prim;
        }

        public override string MaaşBilgisiGetir()
        {
            return $"{Ad} {Soyad} (Yari Zamanli): Maaş = {MaasHesapla()}";
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
            YariZamanliPersonel yariZamanli = new YariZamanliPersonel(ad, soyad, calismaSaati, saatUcret);
            personeller.Add(yariZamanli);
            Console.WriteLine("Yarı zamanlı personel eklendi.");
        }

    }
}
