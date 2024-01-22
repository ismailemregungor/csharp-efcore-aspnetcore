using EFCoreSinavProvaCA1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreSinavProvaCA1.Data
{
    public class KullaniciManager<TEntity> : ICRUD<TEntity> where TEntity : class
    {

        private DbSet<TEntity> _dbSet; // --> tabloya karşılık gelecek
        private KitapContext _context; // --> veritabanına karşılık gelecek

        public KullaniciManager()
        {
            _context = new KitapContext();
            _dbSet = _context.Set<TEntity>();
        }
        public TEntity Bul(int id)
        {
            var x = _dbSet.Find(id);
            _context.Entry(x).State = EntityState.Detached;
            return x;
        }

        public Kullanici BulKullaniciAdiIle(string kullaniciAdi)
        {
            var kullanici = _context.Kullanicilar.FirstOrDefault(k => k.KullaniciAdi == kullaniciAdi);
            if (kullanici != null)
            {
                _context.Entry(kullanici).State = EntityState.Detached; // Nesneyi context'ten ayır
            }
            return kullanici;
        }
        public void Ekle(TEntity entity)
        {
            _dbSet.Add(entity);
            _context.SaveChanges();
        }

        public void Guncelle(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public List<TEntity> Listele()
        {
            return _dbSet.ToList();
        }

        public List<TEntity> Listele(Func<TEntity, bool> predicate)
        {
            return _dbSet.Include("Kullanici").Where(predicate).ToList();
        }

        public List<TEntity> ListeleJoin(string navigationPropertyName)
        {
            return _dbSet.Include(navigationPropertyName).ToList();
        }

        public void Sil(int id)
        {
            _dbSet.Remove(_dbSet.Find(id));
            _context.SaveChanges();
        }
    }
}
