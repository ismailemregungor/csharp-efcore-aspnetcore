using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EFCoreDataLoading.Models
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

            optionsBuilder.UseLazyLoadingProxies();
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
                    .HasForeignKey(d => d.KategoriId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            OnModelCreatingPartial(modelBuilder);

        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
