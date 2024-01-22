using ismailemregungorAlbumDukkani.Config;
using ismailemregungorAlbumDukkani.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ismailemregungorAlbumDukkani.Data
{
    public class MagazaContext : DbContext
    {
        public MagazaContext()
        {

        }

        public MagazaContext(DbContextOptions<MagazaContext> options) : base(options)
        {

        }

        // Kullanıcılar tablosuna karşılık gelir.
        public DbSet<Kullanici> Kullanicilar { get; set; }

        // Sanatcilar tablosuna karşılık gelir.
        public DbSet<Sanatci> Sanatcilar { get; set; }

        // Albümler tablosuna karşılık gelir.
        public DbSet<Album> Albumler { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            // Veritabanı bağlantı ayarlarını yapılandırır.
            optionsBuilder.UseOracle("User Id = magaza; Password = magaza; Data Source = (DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = 127.0.0.1)(PORT = 1521)))(CONNECT_DATA = (SERVER = DEDICATED)(SID = orcl)))");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Veritabanı tablo yapılandırmalarını uygular.
            modelBuilder.ApplyConfiguration(new Kullanici_CFG());
            modelBuilder.ApplyConfiguration(new Sanatci_CFG());
            modelBuilder.ApplyConfiguration(new Album_CFG());

        }
    }
}
