using EFCoreSinavProvaCA2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreSinavProvaCA2.Data
{
    public class KullaniciManager<TEntity> : ICRUD<TEntity> where TEntity : class
    {
        private DbSet<TEntity> _dbSet; // Tabloya karşılık gelir.
        private MagazaContext _context; // Veritabanına karşılık gelir.

        public KullaniciManager()
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

        // Belirtilen kullanıcı adına sahip bir Kullanici öğesini bulur ve döndürür.
        public Kullanici BulKullaniciAdiIle(string kullaniciAdi)
        {
            var kullanici = _context.Kullanicilar.FirstOrDefault(k => k.KullaniciAdi == kullaniciAdi);
            if (kullanici != null)
            {
                _context.Entry(kullanici).State = EntityState.Detached; // Nesneyi context'ten ayır
            }
            return kullanici;
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
