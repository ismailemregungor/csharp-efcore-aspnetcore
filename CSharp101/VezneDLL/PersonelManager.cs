using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaDLL
{
    public class PersonelManager : IManagerIslemleri<Personel>
    {
        private List<Personel> _personeller = new List<Personel>();

        public void Ekle(Personel entity)
        {
            _personeller.Add(entity);
        }

        public List<Personel> Listele()
        {
            return _personeller;
        }
    }
}
