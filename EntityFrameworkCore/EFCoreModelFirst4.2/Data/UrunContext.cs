using EFCoreModelFirst4._2.Configuration;
using EFCoreModelFirst4._2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreModelFirst4._2.Data
{
    public class UrunContext: DbContext
    {
        public UrunContext()
        {

        }
        public UrunContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Urun> Urunler { get; set; }

        public DbSet<Kategori> Kategoriler { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseOracle("User Id=urun2; Password=urun2; Data Source = (DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = 127.0.0.1)(PORT = 1521)))(CONNECT_DATA = (SERVER=DEDICATED)(SID = orcl)))");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<Kategori>(entity =>
            //{
            //    entity.ToTable("KATEGORILER");
            //    entity.Property(e => e.KategoriID).HasColumnName("KATEGORI_ID");
            //    entity.Property(e => e.KategoriAdi)
            //        .HasColumnName("KATEGORI_ADI")
            //        .HasColumnType("CHAR")
            //        .HasMaxLength(30)
            //        .IsRequired();

            //    // Seed data
            //    entity.HasData(
            //        new Kategori() { KategoriID = 1, KategoriAdi = "Kırtasiye" },
            //        new Kategori() { KategoriID = 2, KategoriAdi = "Elektronik" },
            //        new Kategori() { KategoriID = 3, KategoriAdi = "Tekstil" }
            //    );
            //});

            //modelBuilder.Entity<Urun>(entity =>
            //{
            //    entity.ToTable("URUNLER");
            //    entity.Property(e => e.UrunID).HasColumnName("URUN_ID");
            //    entity.Property(e => e.UrunAdi).HasColumnName("URUN_ADI");
            //    entity.Property(e => e.Fiyat).HasColumnName("FIYAT").HasColumnType("NUMBER(10,2)");
            //    entity.Property(e => e.KategoriID).HasColumnName("KATEGORI_ID");

            //    // Foreign Key ilişkisi
            //    entity.HasOne(d => d.Kategori)
            //          .WithMany(p => p.Urunler)
            //          .HasForeignKey(d => d.KategoriID)
            //          .OnDelete(DeleteBehavior.Restrict); 
            //});

            modelBuilder.ApplyConfiguration(new Kategori_CFG());
            modelBuilder.ApplyConfiguration(new Urun_CFG());
        }
    }
}
