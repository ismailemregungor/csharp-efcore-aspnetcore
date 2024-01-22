using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events.Magaza
{
    internal interface IDepo
    {
        public void UrunleriListele();
        public void UrunEkle(Urun urun);
        public void UrunCikar(int id);
    }
}
