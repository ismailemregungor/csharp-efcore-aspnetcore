using EFCoreSinavProvaCA1.Enums;
using EFCoreSinavProvaCA1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreSinavProvaCA1.Data
{
    public class KitapManager<TEntity> : ICRUD<TEntity> where TEntity : class
    {

        private DbSet<TEntity> _dbSet; // --> tabloya karşılık gelecek
        private KitapContext _context; // --> veritabanına karşılık gelecek

        public KitapManager()
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
            return _dbSet.Include("Kitap").Where(predicate).ToList();
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

        public List<Kitap> EnSonEklenenOnKitap()
        {
            return _dbSet.OfType<Kitap>()
                         .Include(k => k.Yayinevi)
                         .OrderByDescending(k => k.EklemeTarih)
                         .Take(10)
                         .ToList();
        }

        public List<Kitap> YayinEvlerineGoreKitaplar(string yayineviAdi)
        {
            return _dbSet.OfType<Kitap>()
                         .Include(k => k.Yayinevi)
                         .Where(k => k.Yayinevi.YayineviAdi == yayineviAdi)
                         .ToList();
        }

        public List<Kitap> SatisiDurdurulanKitaplar()
        {
            return _dbSet.OfType<Kitap>()
                         .Include(k => k.Yayinevi) 
                         .Where(k => k.KitapDurumu == KitapDurumu.Pasif)
                         .ToList();
        }

        public List<Kitap> FiyatinaGoreKitaplar()
        {
            return _dbSet.OfType<Kitap>()
                         .Include(k => k.Yayinevi)
                         .OrderBy(k => k.Fiyat)
                         .ToList();
        }
    }
}
