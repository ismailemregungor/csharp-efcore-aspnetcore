using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalDLL
{
    public class Hemsire: Kisi
    {
        public Cinsiyet Cinsiyet { get; set; }
        public int DeneyimYılı { get; set; }

        public override string ToString()
        {
            return $"Ad: {Ad}, Soyad: {Soyad}, Cinsiyet: {Cinsiyet}, Deneyim Yılı: {DeneyimYılı}";
        }

    }
}
