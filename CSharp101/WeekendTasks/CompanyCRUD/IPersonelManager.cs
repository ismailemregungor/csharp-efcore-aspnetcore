using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekendTasks.CompanyCRUD
{
    internal interface IPersonelManager
    {
        void Ekle(Personel personel);
        void Sil(int id);
        Personel GetirIdIle(int id);
        List<Personel> GetirHepsi();
        List<Personel> GetirIlceyeGore(string ilce);
        void Guncelle(Personel personel);
    }
}
