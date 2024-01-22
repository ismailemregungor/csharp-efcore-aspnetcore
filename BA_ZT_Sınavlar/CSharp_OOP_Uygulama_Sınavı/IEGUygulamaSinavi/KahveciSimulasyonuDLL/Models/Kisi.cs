using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveciSimulasyonuDLL.Models
{
    public abstract class Kisi
    {
        public string Isim { get; set; }

        public override string ToString()
        {
            return $"İsim: {Isim}";
        }
    }
}
