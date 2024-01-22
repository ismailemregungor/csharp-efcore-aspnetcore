using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaDLL
{
    public class MusteriManager : IManagerIslemleri<Musteri>
    {
        private Queue<Musteri> _musteriler = new Queue<Musteri>();
        public void Ekle(Musteri entity)
        {
            _musteriler.Enqueue(entity);
        }

        public List<Musteri> Listele()
        {
            return _musteriler.ToList();
        }

        public Musteri Cikar()
        {
            return _musteriler.Dequeue();
        }
    }
}
