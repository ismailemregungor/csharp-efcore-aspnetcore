using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekendTasks.FirmaYonetimi
{
    internal interface IPersonelManager
    {
        void Ekle(Personel personel);
        void Guncelle(Personel personel);
        void Sil(int id);
        List<Personel> TumPersoneller();
        List<Personel> AdreseGorePersoneller(string adres);
        Personel Ara(int id);
    }
}
