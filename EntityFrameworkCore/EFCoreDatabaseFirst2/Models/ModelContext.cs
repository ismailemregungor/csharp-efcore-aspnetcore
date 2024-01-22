using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EFCoreDatabaseFirst2.Models
{
    public partial class ModelContext : DbContext
    {
        public ModelContext()
        {
        }

        public ModelContext(DbContextOptions<ModelContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Kategoriler> Kategorilers { get; set; } = null!;
        public virtual DbSet<Urunler> Urunlers { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseOracle("User Id=urun2; Password=urun2; Data Source = (DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = 127.0.0.1)(PORT = 1521)))(CONNECT_DATA = (SERVER=DEDICATED)(SID = orcl)))");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("URUN2")
                .UseCollation("USING_NLS_COMP");

            modelBuilder.Entity<Kategoriler>(entity =>
            {
                entity.HasKey(e => e.KategoriId);

                entity.ToTable("KATEGORILER");

                entity.Property(e => e.KategoriId)
                    .HasPrecision(10)
                    .HasColumnName("KATEGORI_ID");

                entity.Property(e => e.KategoriAdi)
                    .HasMaxLength(30)
                    .HasColumnName("KATEGORI_ADI");
            });

            modelBuilder.Entity<Urunler>(entity =>
            {
                entity.HasKey(e => e.UrunId);

                entity.ToTable("URUNLER");

                entity.HasIndex(e => e.KategoriId, "IX_URUNLER_KATEGORI_ID");

                entity.Property(e => e.UrunId)
                    .HasPrecision(10)
                    .HasColumnName("URUN_ID");

                entity.Property(e => e.Fiyat).HasColumnName("FIYAT");

                entity.Property(e => e.KategoriId)
                    .HasPrecision(10)
                    .HasColumnName("KATEGORI_ID");

                entity.Property(e => e.UrunAdi).HasColumnName("URUN_ADI");

                entity.HasOne(d => d.Kategori)
                    .WithMany(p => p.Urunlers)
                    .HasForeignKey(d => d.KategoriId);
            });

            OnModelCreatingPartial(modelBuilder);

            //Initial Data

            modelBuilder.Entity<Kategoriler>().HasData(
                new Kategoriler { KategoriId = 11, KategoriAdi = "Oyuncak" },
                new Kategoriler { KategoriId = 12, KategoriAdi = "Kitap" },
                new Kategoriler { KategoriId = 13, KategoriAdi = "Hobi" },
                new Kategoriler { KategoriId = 14, KategoriAdi = "Bahce" }
                );

            modelBuilder.Entity<Urunler>().HasData(
                new Urunler { UrunId = 100, UrunAdi = "Tren", Fiyat = 750, KategoriId = 11 },
                new Urunler { UrunId = 101, UrunAdi = "Ucak", Fiyat = 750, KategoriId = 11 },
                new Urunler { UrunId = 102, UrunAdi = "Empati", Fiyat = 100, KategoriId = 12 },
                new Urunler { UrunId = 103, UrunAdi = "Simyacı", Fiyat = 100, KategoriId = 12 },
                new Urunler { UrunId = 104, UrunAdi = "Da Vinci Sifresi", Fiyat = 100, KategoriId = 12 },
                new Urunler { UrunId = 105, UrunAdi = "Satranc Seti", Fiyat = 300, KategoriId = 13 },
                new Urunler { UrunId = 106, UrunAdi = "Monopoly", Fiyat = 300, KategoriId = 13 }
                );
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
