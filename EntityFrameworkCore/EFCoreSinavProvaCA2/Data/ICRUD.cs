using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreSinavProvaCA2.Data
{
    public interface ICRUD<TEntity> where TEntity : class
    {
        // TEntity türündeki bir öğeyi veritabanına ekler.
        void Ekle(TEntity entity);

        // Veritabanındaki bir TEntity öğesini günceller.
        void Guncelle(TEntity entity);

        // Veritabanından belirtilen ID'ye sahip bir TEntity öğesini siler.
        void Sil(int id);

        // Tüm TEntity öğelerini bir liste olarak döndürür.
        List<TEntity> Listele();

        // Belirtilen ID'ye sahip bir TEntity öğesini bulur ve döndürür.
        TEntity Bul(int id);

        // Belirtilen bir koşulu sağlayan TEntity öğelerini bir liste olarak döndürür.
        List<TEntity> Listele(Func<TEntity, bool> predicate);

        // Belirtilen bir ilişkisel özellik (navigation property) ile birleştirilmiş TEntity öğelerini bir liste olarak döndürür.
        List<TEntity> ListeleJoin(string navigationPropertyName);
    }

}
