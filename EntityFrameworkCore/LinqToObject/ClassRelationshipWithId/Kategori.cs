using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToObject._2
{
    public class Kategori
    {
        public int KategoriId { get; set; }

        public string KategoriAdi { get; set; }

        public override string ToString()
        {
            return $"{KategoriId} {KategoriAdi}";
        }

    }
}
