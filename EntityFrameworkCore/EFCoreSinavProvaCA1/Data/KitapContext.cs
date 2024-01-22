using EFCoreSinavProvaCA1.Config;
using EFCoreSinavProvaCA1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreSinavProvaCA1.Data
{
    public class KitapContext : DbContext
    {
        public KitapContext()
        {

        }

        public KitapContext(DbContextOptions<KitapContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseOracle("User Id = kitap1; Password = kitap1; Data Source = (DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = 127.0.0.1)(PORT = 1521)))(CONNECT_DATA = (SERVER = DEDICATED)(SID = orcl)))");
        }

        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<Kitap> Kitaplar { get; set; }
        public DbSet<Yayinevi> Yayinevleri { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new Kullanici_CFG());
            modelBuilder.ApplyConfiguration(new Yayinevi_CFG());
            modelBuilder.ApplyConfiguration(new Kitap_CFG());
        }
    }
}
