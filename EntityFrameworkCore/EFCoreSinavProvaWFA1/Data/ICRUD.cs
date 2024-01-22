using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreSinavProvaWFA1.Data
{
    public interface ICRUD<TEntity> where TEntity : class
    {
        void Ekle(TEntity entity);

        void Guncelle(TEntity entity);

        void Sil(int id);

        List<TEntity> Listele();

        TEntity Bul(int id);

        List<TEntity> Listele(Func<TEntity, bool> predicate);

        List<TEntity> ListeleJoin(string tabloAdi);
    }
}
