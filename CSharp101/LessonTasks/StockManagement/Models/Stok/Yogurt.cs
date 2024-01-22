using LessonTasks.StockManagement.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace LessonTasks.StockManagement.Models.Stok
{
    internal class Yogurt : Urun, ISKT, IBozulabilir
    {
        public DateTime SKT { get; set; }
        public bool BozukMu { get; set; }
        public string BozulmaNedeni { get; set; }

        public override string ToString()
        {
            return $"{UrunId}{UrunAdi}{UrunFiyati}BozukMu = {BozukMu} Bozulma Nedeni = {BozulmaNedeni}";
        }
    }
}
