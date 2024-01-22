using ismailemregungorAlbumDukkani.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ismailemregungorAlbumDukkani.Utilities;

namespace ismailemregungorAlbumDukkani.Config
{
    // Kullanici_CFG sınıfı, Kullanici sınıfının veritabanı eşlemesini yapılandırır.
    public class Kullanici_CFG : IEntityTypeConfiguration<Kullanici>
    {
        public void Configure(EntityTypeBuilder<Kullanici> builder)
        {
            builder.ToTable("KULLANICILAR");

            builder.HasKey(k => k.KullaniciID);

            builder.Property(k => k.KullaniciID)
                .UseIdentityColumn(1, 1)
                .HasColumnName("KULLANICI_ID");

            builder.Property(k => k.Ad)
                .HasColumnName("AD");

            builder.Property(k => k.Soyad)
                .HasColumnName("SOYAD");

            builder.Property(k => k.KullaniciAdi)
                .IsRequired()
                .HasColumnName("KULLANICI_ADI");

            builder.Property(k => k.Sifre)
                .IsRequired()
                .HasColumnName("SIFRE");

            builder.HasData(
                new Kullanici
                {
                    KullaniciID = 1,
                    Ad = "Admin123",
                    Soyad = "Admin123",
                    KullaniciAdi = "Admin123",
                    Sifre = Utility.HashPassword("Admin123")
                }
            );
        }
    }
}
