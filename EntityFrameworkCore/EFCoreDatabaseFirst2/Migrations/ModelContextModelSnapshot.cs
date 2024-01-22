﻿// <auto-generated />
using EFCoreDatabaseFirst2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oracle.EntityFrameworkCore.Metadata;

#nullable disable

namespace EFCoreDatabaseFirst2.Migrations
{
    [DbContext(typeof(ModelContext))]
    partial class ModelContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("URUN2")
                .UseCollation("USING_NLS_COMP")
                .HasAnnotation("ProductVersion", "6.0.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            OracleModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EFCoreDatabaseFirst2.Models.Kategoriler", b =>
                {
                    b.Property<int>("KategoriId")
                        .ValueGeneratedOnAdd()
                        .HasPrecision(10)
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("KATEGORI_ID");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KategoriId"), 1L, 1);

                    b.Property<string>("KategoriAdi")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("NVARCHAR2(30)")
                        .HasColumnName("KATEGORI_ADI");

                    b.HasKey("KategoriId");

                    b.ToTable("KATEGORILER", "URUN2");

                    b.HasData(
                        new
                        {
                            KategoriId = 11,
                            KategoriAdi = "Oyuncak"
                        },
                        new
                        {
                            KategoriId = 12,
                            KategoriAdi = "Kitap"
                        },
                        new
                        {
                            KategoriId = 13,
                            KategoriAdi = "Hobi"
                        },
                        new
                        {
                            KategoriId = 14,
                            KategoriAdi = "Bahce"
                        });
                });

            modelBuilder.Entity("EFCoreDatabaseFirst2.Models.Urunler", b =>
                {
                    b.Property<int>("UrunId")
                        .ValueGeneratedOnAdd()
                        .HasPrecision(10)
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("URUN_ID");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UrunId"), 1L, 1);

                    b.Property<double>("Fiyat")
                        .HasColumnType("BINARY_DOUBLE")
                        .HasColumnName("FIYAT");

                    b.Property<int>("KategoriId")
                        .HasPrecision(10)
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("KATEGORI_ID");

                    b.Property<string>("UrunAdi")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("URUN_ADI");

                    b.HasKey("UrunId");

                    b.HasIndex(new[] { "KategoriId" }, "IX_URUNLER_KATEGORI_ID");

                    b.ToTable("URUNLER", "URUN2");

                    b.HasData(
                        new
                        {
                            UrunId = 100,
                            Fiyat = 750.0,
                            KategoriId = 11,
                            UrunAdi = "Tren"
                        },
                        new
                        {
                            UrunId = 101,
                            Fiyat = 750.0,
                            KategoriId = 11,
                            UrunAdi = "Ucak"
                        },
                        new
                        {
                            UrunId = 102,
                            Fiyat = 100.0,
                            KategoriId = 12,
                            UrunAdi = "Empati"
                        },
                        new
                        {
                            UrunId = 103,
                            Fiyat = 100.0,
                            KategoriId = 12,
                            UrunAdi = "Simyacı"
                        },
                        new
                        {
                            UrunId = 104,
                            Fiyat = 100.0,
                            KategoriId = 12,
                            UrunAdi = "Da Vinci Sifresi"
                        },
                        new
                        {
                            UrunId = 105,
                            Fiyat = 300.0,
                            KategoriId = 13,
                            UrunAdi = "Satranc Seti"
                        },
                        new
                        {
                            UrunId = 106,
                            Fiyat = 300.0,
                            KategoriId = 13,
                            UrunAdi = "Monopoly"
                        });
                });

            modelBuilder.Entity("EFCoreDatabaseFirst2.Models.Urunler", b =>
                {
                    b.HasOne("EFCoreDatabaseFirst2.Models.Kategoriler", "Kategori")
                        .WithMany("Urunlers")
                        .HasForeignKey("KategoriId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kategori");
                });

            modelBuilder.Entity("EFCoreDatabaseFirst2.Models.Kategoriler", b =>
                {
                    b.Navigation("Urunlers");
                });
#pragma warning restore 612, 618
        }
    }
}
