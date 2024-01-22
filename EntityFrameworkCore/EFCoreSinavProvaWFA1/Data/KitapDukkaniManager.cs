using EFCoreSinavProvaWFA1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreSinavProvaWFA1.Data
{
    public class KitapDukkaniManager<TEntity> : ICRUD<TEntity> where TEntity : class
    {

        private DbSet<TEntity> _dbSet; // --> tabloya karşılık gelecek
        private KitapDukkaniContext _context; // --> veritabanına karşılık gelecek

        public KitapDukkaniManager()
        {
            _context = new KitapDukkaniContext();
            _dbSet = _context.Set<TEntity>();
        }

        public TEntity Bul(int id)
        {
            var x = _dbSet.Find(id);
            _context.Entry(x).State = EntityState.Detached;
            return x;
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
            return _dbSet.Where(predicate).ToList();
        }

        public List<TEntity> ListeleJoin(string tabloAdi)
        {
            return _dbSet.Include(tabloAdi).ToList();
        }

        public void Sil(int id)
        {
            _dbSet.Remove(_dbSet.Find(id));
            _context.SaveChanges();
        }


        public List<Kitap> GetSonEklenenKitaplar(int count = 10)
        {
            return _dbSet.OfType<Kitap>().OrderByDescending(k => k.KitapID).Take(count).ToList();
        }

        public List<Kitap> GetYayinEvlerineGoreKitaplar()
        {
            return _dbSet.OfType<Kitap>().Include(k => k.YayinEvi).ToList();
        }

        public List<Kitap> GetSatisiDurdurulanKitaplar()
        {
            return _dbSet.OfType<Kitap>().Where(k => k.Durum == false).ToList();
        }

        public List<Kitap> GetFiyatinaGoreKitaplar()
        {
            return _dbSet.OfType<Kitap>().OrderBy(k => k.Fiyat).ToList();
        }
    }
}
