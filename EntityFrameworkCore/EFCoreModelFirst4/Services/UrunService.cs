using EFCoreModelFirst4.Data;
using EFCoreModelFirst4.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreModelFirst4.Services
{
    public class UrunService
    {
        UrunContext context = new UrunContext();

        public void AddUrun(Urun urun)
        {
            context.Urunler.Add(urun);
            context.SaveChanges();
        }

        public Urun GetUrunById(int id)
        {
            return context.Urunler.Find(id);
        }

        public IEnumerable<Urun> GetAllUrunler()
        {
            return context.Urunler.Include(u => u.Kategori).OrderBy(u => u.UrunID).ToList();
        }

        public IEnumerable<Urun> GetUrunlerByKategoriAdi(string kategoriAdi)
        {
            return context.Urunler.Include(u => u.Kategori).Where(u => u.Kategori.KategoriAdi == kategoriAdi).ToList();
        }

        public void UpdateUrun(Urun urun)
        {
            context.Urunler.Update(urun);
            context.SaveChanges();
        }

        public void DeleteUrun(int id)
        {
            var urun = context.Urunler.Find(id);
            if (urun != null)
            {
                context.Urunler.Remove(urun);
                context.SaveChanges();
            }
        }
    }
}
