using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonTasks.StockManagement.Models.Stok
{
    internal abstract class Urun
    {
        public int UrunId { get; set; }
        public string UrunAdi { get; set; }
        public double UrunFiyati { get; set; }
    }
}
