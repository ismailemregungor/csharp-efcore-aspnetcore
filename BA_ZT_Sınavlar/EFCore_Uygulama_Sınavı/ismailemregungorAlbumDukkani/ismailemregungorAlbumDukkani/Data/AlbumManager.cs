using ismailemregungorAlbumDukkani.Enums;
using ismailemregungorAlbumDukkani.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ismailemregungorAlbumDukkani.Data
{
    public class AlbumManager<TEntity> : ICRUD<TEntity> where TEntity : class
    {
        private DbSet<TEntity> _dbSet; // --> tabloya karşılık gelecek
        private MagazaContext _context; // --> veritabanına karşılık gelecek
        public AlbumManager()
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

        // Belirtilen albüm adına sahip bir Album öğesini bulur ve döndürür.
        public Album BulAlbumAdiIle(string albumAdi)
        {
            var album = _context.Albumler.FirstOrDefault(k => k.AlbumAdi == albumAdi);
            if (album != null)
            {
                _context.Entry(album).State = EntityState.Detached; // Nesneyi context'ten ayır
            }
            return album;
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
            return _dbSet.Include("Sanatci").Where(predicate).ToList();
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

        // En son eklenen on albümü döndürür.
        public List<Album> EnSonEklenenOnAlbum()
        {
            return _dbSet.OfType<Album>()
                         .Include(k => k.Sanatci)
                         .OrderByDescending(k => k.YayimTarihi)
                         .Take(10)
                         .ToList();
        }

        // Satışı durmuş albümleri döndürür.
        public List<Album> SatisiDurmusAlbumler()
        {
            return _dbSet.OfType<Album>()
                         .Include(k => k.Sanatci)
                         .Where(k => k.AlbumDurumu == AlbumDurumu.Pasif)
                         .Select(k => new Album { AlbumAdi = k.AlbumAdi, Sanatci = k.Sanatci, AlbumDurumu = k.AlbumDurumu })
                         .ToList();
        }

        // Satışı devam eden albümleri döndürür.
        public List<Album> SatisiDevamEdenAlbumler()
        {
            return _dbSet.OfType<Album>()
                         .Include(k => k.Sanatci)
                         .Where(k => k.AlbumDurumu == AlbumDurumu.Aktif)
                         .Select(k => new Album { AlbumAdi = k.AlbumAdi, Sanatci = k.Sanatci, AlbumDurumu = k.AlbumDurumu })
                         .ToList();
        }

        // İndirimdeki albümleri döndürür.
        public List<Album> IndirimdekiAlbumler()
        {
            return _dbSet.OfType<Album>()
                         .Include(k => k.Sanatci)
                         .Where(k => k.IndirimOrani.HasValue && k.IndirimOrani.Value > 0)
                         .OrderByDescending(k => k.IndirimOrani.Value)
                         .Select(k => new Album { AlbumAdi = k.AlbumAdi, Sanatci = k.Sanatci, IndirimOrani = k.IndirimOrani })
                         .ToList();
        }
    }
}
