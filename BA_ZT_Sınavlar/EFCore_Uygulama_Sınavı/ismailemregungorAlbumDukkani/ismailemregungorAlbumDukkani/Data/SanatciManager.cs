using ismailemregungorAlbumDukkani.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ismailemregungorAlbumDukkani.Data
{
    public class SanatciManager<TEntity> : ICRUD<TEntity> where TEntity : class
    {
        private DbSet<TEntity> _dbSet; // --> tabloya karşılık gelecek
        private MagazaContext _context; // --> veritabanına karşılık gelecek
        public SanatciManager()
        {
            _context = new MagazaContext();
            _dbSet = _context.Set<TEntity>();
        }

        // Belirtilen ID'ye sahip bir TEntity öğesini bulur ve döndürür.
        public TEntity Bul(int id)
        {
            var x = _dbSet.Find(id);
            _context.Entry(x).State = EntityState.Detached;
            return x;
        }

        // Belirtilen sanatçı adına sahip bir Sanatci öğesini bulur ve döndürür.
        public Sanatci BulSanatciAdiIle(string sanatciAdi)
        {
            var sanatci = _context.Sanatcilar.FirstOrDefault(k => k.SanatciAdi == sanatciAdi);
            if (sanatci != null)
            {
                _context.Entry(sanatci).State = EntityState.Detached; // Nesneyi context'ten ayır
            }
            return sanatci;
        }

        // TEntity türündeki bir öğeyi veritabanına ekler.
        public void Ekle(TEntity entity)
        {
            _dbSet.Add(entity);
            _context.SaveChanges();
        }

        // Veritabanındaki bir TEntity öğesini günceller.
        public void Guncelle(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }

        // Tüm TEntity öğelerini bir liste olarak döndürür.
        public List<TEntity> Listele()
        {
            return _dbSet.ToList();
        }

        // Belirtilen bir koşulu sağlayan TEntity öğelerini bir liste olarak döndürür.
        public List<TEntity> Listele(Func<TEntity, bool> predicate)
        {
            return _dbSet.Include("Kullanici").Where(predicate).ToList();
        }

        // Belirtilen bir ilişkisel özellik (navigation property) ile birleştirilmiş TEntity öğelerini bir liste olarak döndürür.
        public List<TEntity> ListeleJoin(string navigationPropertyName)
        {
            return _dbSet.Include(navigationPropertyName).ToList();
        }

        // Belirtilen ID'ye sahip bir TEntity öğesini siler.
        public void Sil(int id)
        {
            _dbSet.Remove(_dbSet.Find(id));
            _context.SaveChanges();
        }
    }
}
