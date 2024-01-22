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
    public class KategoriService
    {
        UrunContext context = new UrunContext();

        public void AddKategori(Kategori kategori)
        {
            context.Kategoriler.Add(kategori);
            context.SaveChanges();
        }

        public IEnumerable<Kategori> GetAllKategoriler()
        {
            return context.Kategoriler.ToList();
        }
    }
}
