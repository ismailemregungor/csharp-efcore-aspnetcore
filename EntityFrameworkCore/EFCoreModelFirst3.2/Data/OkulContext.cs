using EFCoreModelFirst3._2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreModelFirst3._2.Data
{
    public class OkulContext : DbContext
    {
        public OkulContext()
        {

        }

        public OkulContext(DbContextOptions<OkulContext> options) : base(options)
        {

        }
        public DbSet<Ogrenci> Ogrenciler { get; set; }
        public DbSet<Ders> Dersler { get; set; }
        public DbSet<Egitmen> Egitmenler { get; set; }
        public DbSet<HarfNotu> HarfNotları { get; set; }
        public DbSet<OgrenciDers> OgrenciDersleri { get; set; }
        public DbSet<EgitmenDers> EgitmenDersleri { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseOracle("User Id=okul2; Password=okul2; Data Source = (DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = 127.0.0.1)(PORT = 1521)))(CONNECT_DATA = (SERVER=DEDICATED)(SID = orcl)))");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Ogrenci>().HasData(
               new Ogrenci { OgrenciID = 1, Ad = "Cevdet", Soyad = "Yılmaz" },
               new Ogrenci { OgrenciID = 2, Ad = "Selami", Soyad = "Dursun" },
               new Ogrenci { OgrenciID = 3, Ad = "Dursun", Soyad = "Durmasın" });
            modelBuilder.Entity<Ders>().HasData(
                new Ders { DersID = 10, DersAdi = "Mat101", Kredi = 4 },
                new Ders { DersID = 11, DersAdi = "Mat102", Kredi = 4 },
                new Ders { DersID = 12, DersAdi = "Fiz101", Kredi = 3 },
                new Ders { DersID = 13, DersAdi = "PolifoniI", Kredi = 3 },
                new Ders { DersID = 14, DersAdi = "Kimya", Kredi = 3 }
                );
            modelBuilder.Entity<Egitmen>().HasData(
                new Egitmen { EgitmenID = 20, Ad = "Cevat", Soyad = "Kulyutmaz" },
                new Egitmen { EgitmenID = 21, Ad = "Cavit", Soyad = "Sifirci" }
                );
            modelBuilder.Entity<EgitmenDers>().HasData(
                new EgitmenDers { EgitmenDersID = 1, DersID = 10, EgitmenID = 20 },
                new EgitmenDers { EgitmenDersID = 2, DersID = 11, EgitmenID = 20 },
                new EgitmenDers { EgitmenDersID = 3, DersID = 12, EgitmenID = 20 },
                new EgitmenDers { EgitmenDersID = 4, DersID = 13, EgitmenID = 21 },
                new EgitmenDers { EgitmenDersID = 5, DersID = 14, EgitmenID = 21 }
                );
            modelBuilder.Entity<OgrenciDers>().HasData(
                new OgrenciDers { OgrenciDersID = 1, OgrenciID = 1, DersID = 10, Not = 78 },
                new OgrenciDers { OgrenciDersID = 2, OgrenciID = 1, DersID = 13, Not = 55 },
                new OgrenciDers { OgrenciDersID = 3, OgrenciID = 1, DersID = 14, Not = 66 },
                new OgrenciDers { OgrenciDersID = 4, OgrenciID = 2, DersID = 10, Not = 66 },
                new OgrenciDers { OgrenciDersID = 5, OgrenciID = 3, DersID = 11, Not = 50 }
                );
        }
    }
}
