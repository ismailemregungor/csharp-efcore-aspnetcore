using EFCoreSinavProvaWFA1.Config;
using EFCoreSinavProvaWFA1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreSinavProvaWFA1.Data
{
    public class KitapDukkaniContext : DbContext
    {
        public KitapDukkaniContext()
        {

        }

        public KitapDukkaniContext(DbContextOptions<KitapDukkaniContext> options) : base(options)
        {

        }

        public DbSet<Kitap> Kitaplar { get; set; }
        public DbSet<YayinEvi> YayinEvleri { get; set; }
        public DbSet<Admin> Adminler { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseOracle("User Id=kitapdukkani1; Password=kitapdukkani1; Data Source = (DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = 127.0.0.1)(PORT = 1521)))(CONNECT_DATA = (SERVER=DEDICATED)(SID = orcl)))");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new AdminCFG());
            modelBuilder.ApplyConfiguration(new KitapCFG());
            modelBuilder.ApplyConfiguration(new YayinEviCFG());

            modelBuilder.Entity<Admin>(entity =>
            {
                entity.Property(e => e.Sifre).IsRequired().HasMaxLength(32);
                                                                            
            });

            modelBuilder.Entity<Admin>().HasData(
            new Admin
            {
                AdminID = 1,
                KullaniciAdi = "admin",
                Sifre = "admin" // Bu değer CalculateMD5Hash fonksiyonu ile MD5'e dönüştürülecek
            });
        }
    }
}
