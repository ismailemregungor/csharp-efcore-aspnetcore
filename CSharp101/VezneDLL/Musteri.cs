using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaDLL
{
    public class Musteri: Kisi
    {
        public string? HesapNo { get; set; }
        public double Bakiye { get; set; }
        public Islem IslemTipi { get; set; }

        public override string ToString()
        {
            return base.ToString() + $" {HesapNo} {Bakiye} {IslemTipi} ";
        }
    }
}
