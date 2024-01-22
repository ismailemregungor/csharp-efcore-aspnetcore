using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors.Constructors3
{
    internal class Urun
    {

        public Urun(int UrunId, string UrunAdi, double Fiyat) 
        {
            
        }

        public int UrunId { get; set; }
        public string UrunAdi { get; set;}

        private double _fiyat;

        public double UrunFiyati 
        {
            get { return _fiyat; }
            set
            {
                if (value > 0)
                {
                    _fiyat = value;
                }
                else
                {

                }
            } 
        }
    }
}
