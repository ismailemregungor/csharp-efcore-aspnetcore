using LessonTasks.StockManagement.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace LessonTasks.StockManagement.Models.Stok
{
    internal class SiseSut : Urun, ISKT, IBozulabilir, IKirilabilir
    {
        public DateTime SKT { get; set; }
        public bool BozukMu { get; set; }
        public string BozulmaNedeni { get; set; }
        public bool KırıkMı { get; set; }

        public override string ToString()
        {
            return $"{UrunId}{UrunAdi}{UrunFiyati}{SKT}BozukMu = {BozukMu} Bozulma Nedeni = {BozulmaNedeni} KırıkMı = {KırıkMı}";
        }
    }
}
