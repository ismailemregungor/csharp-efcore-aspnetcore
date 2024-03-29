﻿// <auto-generated />
using EFCoreInheritanceStrategy.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oracle.EntityFrameworkCore.Metadata;

#nullable disable

namespace EFCoreInheritanceStrategy.Migrations
{
    [DbContext(typeof(KisiContext))]
    partial class KisiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            OracleModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EFCoreInheritanceStrategy.Models.Kisi", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Soyad")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("ID");

                    b.ToTable("Kisiler");
                });

            modelBuilder.Entity("EFCoreInheritanceStrategy.Models.Musteri", b =>
                {
                    b.HasBaseType("EFCoreInheritanceStrategy.Models.Kisi");

                    b.Property<double>("Cari")
                        .HasColumnType("BINARY_DOUBLE");

                    b.ToTable("MUSTERILER", (string)null);
                });

            modelBuilder.Entity("EFCoreInheritanceStrategy.Models.Personel", b =>
                {
                    b.HasBaseType("EFCoreInheritanceStrategy.Models.Kisi");

                    b.Property<double>("Maas")
                        .HasColumnType("BINARY_DOUBLE");

                    b.ToTable("PERSONELLER", (string)null);
                });

            modelBuilder.Entity("EFCoreInheritanceStrategy.Models.Musteri", b =>
                {
                    b.HasOne("EFCoreInheritanceStrategy.Models.Kisi", null)
                        .WithOne()
                        .HasForeignKey("EFCoreInheritanceStrategy.Models.Musteri", "ID")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EFCoreInheritanceStrategy.Models.Personel", b =>
                {
                    b.HasOne("EFCoreInheritanceStrategy.Models.Kisi", null)
                        .WithOne()
                        .HasForeignKey("EFCoreInheritanceStrategy.Models.Personel", "ID")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
