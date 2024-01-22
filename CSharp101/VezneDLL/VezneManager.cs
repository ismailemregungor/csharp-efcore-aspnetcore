using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaDLL
{
    public class VezneManager : IManagerIslemleri<Vezne>
    {
        public List<Vezne> _vezneler = new List<Vezne>();
        public void Ekle(Vezne entity)
        {
            _vezneler.Add(entity);
        }

        public List<Vezne> Listele()
        {
            return _vezneler;
        }

        public void TumMusaitVeznelereMusteriAta()
        {

        }
    }
}
