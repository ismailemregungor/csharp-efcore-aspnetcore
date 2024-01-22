using EFCoreSinavProvaCA2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreSinavProvaCA2.Data
{
    public class SarkiManager<TEntity> : ICRUD<TEntity> where TEntity : class
    {
        private DbSet<TEntity> _dbSet; // --> tabloya karşılık gelecek
        private MagazaContext _context; // --> veritabanına karşılık gelecek
        public SarkiManager()
        {
            _context = new MagazaContext();
            _dbSet = _context.Set<TEntity>();
        }

        public TEntity Bul(int id)
        {
            var x = _dbSet.Find(id);
            _context.Entry(x).State = EntityState.Detached;
            return x;
        }

        public Sarki BulSarkiAdiIle(string sarkiAdi)
        {
            var sarki = _context.Sarkilar.FirstOrDefault(k => k.SarkiAdi == sarkiAdi);
            if (sarki != null)
            {
                _context.Entry(sarki).State = EntityState.Detached; // Nesneyi context'ten ayır
            }
            return sarki;
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
