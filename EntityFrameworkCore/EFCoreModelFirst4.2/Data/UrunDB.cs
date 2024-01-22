using EFCoreModelFirst4._2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreModelFirst4._2.Data
{
    public class UrunDB
    {
        public BaseManager<Urun> Urunler { get; set; }

        public BaseManager<Kategori> Kategoriler { get; set; }

        public UrunDB()
        {
            Urunler = new BaseManager<Urun>();
            Kategoriler = new BaseManager<Kategori>();
        }
    }
}
