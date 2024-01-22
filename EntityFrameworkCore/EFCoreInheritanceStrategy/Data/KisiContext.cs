using EFCoreInheritanceStrategy.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreInheritanceStrategy.Data
{
    public class KisiContext : DbContext
    {
        public KisiContext()
        {

        }

        public KisiContext(DbContextOptions<KisiContext> options) : base(options)
        {

        }

        public DbSet<Kisi> Kisiler { get; set; }
        public DbSet<Personel> Personeller { get; set; }
        public DbSet<Musteri> Musteriler { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseOracle("User Id=kisi; Password=kisi; Data Source = (DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = 127.0.0.1)(PORT = 1521)))(CONNECT_DATA = (SERVER=DEDICATED)(SID = orcl)))");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // TPH
            //base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<Kisi>()
            //    .HasDiscriminator<char>("Tip")
            //    .HasValue<Personel>('P')
            //    .HasValue<Musteri>('M');

            // TPT
            modelBuilder.Entity<Personel>().ToTable("PERSONELLER");
            modelBuilder.Entity<Musteri>().ToTable("MUSTERILER");

        }
    }
}
