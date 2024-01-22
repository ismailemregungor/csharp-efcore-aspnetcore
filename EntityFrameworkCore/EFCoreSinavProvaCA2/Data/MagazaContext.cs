using EFCoreSinavProvaCA2.Config;
using EFCoreSinavProvaCA2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreSinavProvaCA2.Data
{
    public class MagazaContext : DbContext
    {
        public MagazaContext()
        {

        }

        public MagazaContext(DbContextOptions<MagazaContext> options) : base(options)
        {

        }

        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<Album> Albumler { get; set; }

        public DbSet<Sanatci> Sanatcilar { get; set; }
        public DbSet<Sarki> Sarkilar { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseOracle("User Id = magaza1; Password = magaza1; Data Source = (DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = 127.0.0.1)(PORT = 1521)))(CONNECT_DATA = (SERVER = DEDICATED)(SID = orcl)))");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new Kullanici_CFG());
            modelBuilder.ApplyConfiguration(new Album_CFG());
            modelBuilder.ApplyConfiguration(new Sanatci_CFG());
            modelBuilder.ApplyConfiguration(new Sarki_CFG());
        }
    }
}
