using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonTasks.StockManagement.Models.Personel
{
    internal abstract class Personel
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }

        public Personel(string ad, string soyad)
        {
            Ad = ad;
            Soyad = soyad;
        }

        public abstract decimal MaasHesapla();
        public abstract string MaaşBilgisiGetir();
    }
}
