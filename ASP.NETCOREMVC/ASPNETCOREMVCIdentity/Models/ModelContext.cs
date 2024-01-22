using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ASPNETCOREMVCIdentity.Models
{
    public partial class ModelContext : IdentityDbContext
    {
        public ModelContext()
        {
        }

        public ModelContext(DbContextOptions<ModelContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Brand> Brands { get; set; } = null!;
        public virtual DbSet<Category> Categories { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            base.OnConfiguring(optionsBuilder);
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseOracle("User Id=product; Password=product; Data Source = (DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = 127.0.0.1)(PORT = 1521)))(CONNECT_DATA = (SERVER=DEDICATED)(SID = orcl)))");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            modelBuilder.HasDefaultSchema("PRODUCT")
                .UseCollation("USING_NLS_COMP");

            modelBuilder.Entity<Brand>(entity =>
            {
                entity.ToTable("BRANDS");

                entity.Property(e => e.BrandId)
                    .HasPrecision(10)
                    .HasColumnName("BRAND_ID");

                entity.Property(e => e.Name).HasColumnName("NAME");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("CATEGORIES");

                entity.Property(e => e.CategoryId)
                    .HasPrecision(10)
                    .HasColumnName("CATEGORY_ID");

                entity.Property(e => e.Name).HasColumnName("NAME");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("PRODUCTS");

                entity.HasIndex(e => e.BrandId, "IX_PRODUCTS_BRAND_ID");

                entity.HasIndex(e => e.CategoryId, "IX_PRODUCTS_CATEGORY_ID");

                entity.Property(e => e.ProductId)
                    .HasPrecision(10)
                    .HasColumnName("PRODUCT_ID");

                entity.Property(e => e.BrandId)
                    .HasPrecision(10)
                    .HasColumnName("BRAND_ID");

                entity.Property(e => e.CategoryId)
                    .HasPrecision(10)
                    .HasColumnName("CATEGORY_ID");

                entity.Property(e => e.Description).HasColumnName("DESCRIPTION");

                entity.Property(e => e.Imagepath).HasColumnName("IMAGEPATH");

                entity.Property(e => e.Name).HasColumnName("NAME");

                entity.Property(e => e.Price).HasColumnName("PRICE");

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.BrandId);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.CategoryId);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
