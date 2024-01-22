using LessonTasks.StockManagement.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace LessonTasks.StockManagement.Models.Stok
{
    internal class Yumurta : Urun, ISKT, IKirilabilir
    {
        public DateTime SKT { get; set; }
        public bool KırıkMı { get; set; }
        public override string ToString()
        {
            return $"{UrunId}{UrunAdi}{UrunFiyati}KiirkMi = {KırıkMı}";
        }
    }
}
