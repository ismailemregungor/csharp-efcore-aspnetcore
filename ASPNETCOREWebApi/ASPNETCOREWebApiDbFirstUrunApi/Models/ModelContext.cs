﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ASPNETCOREWebApiDbFirstUrunApi.Models
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
                optionsBuilder.UseOracle("User Id=urun; Password=urun; Data Source = (DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = 127.0.0.1)(PORT = 1521)))(CONNECT_DATA = (SERVER=DEDICATED)(SID = orcl)))");
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("URUN")
                .UseCollation("USING_NLS_COMP");

            modelBuilder.Entity<Kategoriler>(entity =>
            {
                entity.HasKey(e => e.KategoriId);

                entity.ToTable("KATEGORILER");

                entity.Property(e => e.KategoriId)
                    .HasPrecision(10)
                    .HasColumnName("KategoriID");
            });

            modelBuilder.Entity<Urunler>(entity =>
            {
                entity.HasKey(e => e.UrunId);

                entity.ToTable("URUNLER");

                entity.HasIndex(e => e.KategoriId, "IX_URUNLER_KategoriID");

                entity.Property(e => e.UrunId)
                    .HasPrecision(10)
                    .HasColumnName("UrunID");

                entity.Property(e => e.KategoriId)
                    .HasPrecision(10)
                    .HasColumnName("KategoriID");

                entity.HasOne(d => d.Kategori)
                    .WithMany(p => p.Urunlers)
                    .HasForeignKey(d => d.KategoriId);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
