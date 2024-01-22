using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalDLL
{
    public class Ilac
    {
        public string Ad { get; set; }
        public int Adet { get; set; }

        public override string ToString()
        {
            return $"Ad: {Ad}, Açıklama: {Adet}";
        }

    }
}
