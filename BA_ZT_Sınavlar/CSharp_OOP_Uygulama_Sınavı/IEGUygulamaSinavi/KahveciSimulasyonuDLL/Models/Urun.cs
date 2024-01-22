using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KahveciSimulasyonuDLL.Enums;

namespace KahveciSimulasyonuDLL.Models
{
    public class Urun
    {
        public string Ad { get; set; }
        public UrunTipi Tip { get; set; }
        public int HazirlanmaSuresi { get; set; }
        public int Fiyat { get; set; }
        public double BegenilmeOrani { get; set; }

    }
}
