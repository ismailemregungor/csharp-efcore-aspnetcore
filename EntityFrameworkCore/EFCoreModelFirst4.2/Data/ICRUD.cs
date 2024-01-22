using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreModelFirst4._2.Data
{
    public interface ICRUD<TEntity> where TEntity : class
    {
        void Ekle(TEntity entity);

        void Guncelle(TEntity entity);

        void Sil(int entityID);

        List<TEntity> Listele();

        TEntity Bul(int entityID);

        List<TEntity> Listele(Func<TEntity, bool> predicate);

        List<TEntity> ListeleJoin(string tabloAdi);

    }
}
