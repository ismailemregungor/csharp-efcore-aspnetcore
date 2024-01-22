﻿// <auto-generated />
using System;
using EFCoreSinavProvaCA2.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oracle.EntityFrameworkCore.Metadata;

#nullable disable

namespace EFCoreSinavProvaCA2.Migrations
{
    [DbContext(typeof(MagazaContext))]
    [Migration("20231112162250_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            OracleModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EFCoreSinavProvaCA2.Models.Album", b =>
                {
                    b.Property<int>("AlbumID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("ALBUM_ID");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AlbumID"), 1L, 1);

                    b.Property<string>("AlbumAdi")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("NVARCHAR2(200)");

                    b.Property<int>("AlbumDurumu")
                        .HasColumnType("NUMBER(10)");

                    b.Property<double>("Fiyat")
                        .HasColumnType("BINARY_DOUBLE");

                    b.Property<int>("SanatciID")
                        .HasColumnType("NUMBER(10)");

                    b.Property<DateTime>("YayimTarihi")
                        .HasColumnType("TIMESTAMP(7)");

                    b.HasKey("AlbumID");

                    b.HasIndex("SanatciID");

                    b.ToTable("ALBUMLER", (string)null);
                });

            modelBuilder.Entity("EFCoreSinavProvaCA2.Models.Kullanici", b =>
                {
                    b.Property<int>("KullaniciID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("KULLANICI_ID");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KullaniciID"), 1L, 1);

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("NVARCHAR2(50)");

                    b.Property<string>("KullaniciAdi")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("NVARCHAR2(50)");

                    b.Property<string>("Sifre")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Soyad")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("NVARCHAR2(50)");

                    b.HasKey("KullaniciID");

                    b.ToTable("KULLANICILAR", (string)null);

                    b.HasData(
                        new
                        {
                            KullaniciID = 1,
                            Ad = "Admin-1",
                            KullaniciAdi = "Admin-1",
                            Sifre = "c9a1a6dcb58e47d08f2e6ef0dea893242bf7073de60cb6e577b7fbe892213a93",
                            Soyad = "Admin-1"
                        });
                });

            modelBuilder.Entity("EFCoreSinavProvaCA2.Models.Sanatci", b =>
                {
                    b.Property<int>("SanatciID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("SANATCI_ID");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SanatciID"), 1L, 1);

                    b.Property<string>("SanatciAdi")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("NVARCHAR2(200)");

                    b.HasKey("SanatciID");

                    b.ToTable("SANATCILAR", (string)null);
                });

            modelBuilder.Entity("EFCoreSinavProvaCA2.Models.Sarki", b =>
                {
                    b.Property<int>("SarkiID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("SARKI_ID");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SarkiID"), 1L, 1);

                    b.Property<int>("AlbumId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("SarkiAdi")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("NVARCHAR2(200)");

                    b.HasKey("SarkiID");

                    b.HasIndex("AlbumId");

                    b.ToTable("SARKILAR", (string)null);
                });

            modelBuilder.Entity("EFCoreSinavProvaCA2.Models.Album", b =>
                {
                    b.HasOne("EFCoreSinavProvaCA2.Models.Sanatci", "Sanatci")
                        .WithMany("Albumler")
                        .HasForeignKey("SanatciID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sanatci");
                });

            modelBuilder.Entity("EFCoreSinavProvaCA2.Models.Sarki", b =>
                {
                    b.HasOne("EFCoreSinavProvaCA2.Models.Album", "Album")
                        .WithMany("Sarkilar")
                        .HasForeignKey("AlbumId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Album");
                });

            modelBuilder.Entity("EFCoreSinavProvaCA2.Models.Album", b =>
                {
                    b.Navigation("Sarkilar");
                });

            modelBuilder.Entity("EFCoreSinavProvaCA2.Models.Sanatci", b =>
                {
                    b.Navigation("Albumler");
                });
#pragma warning restore 612, 618
        }
    }
}
