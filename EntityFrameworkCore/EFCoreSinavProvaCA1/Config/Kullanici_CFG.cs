using EFCoreSinavProvaCA1.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreSinavProvaCA1.Config
{
    public class Kullanici_CFG : IEntityTypeConfiguration<Kullanici>
    {
        public void Configure(EntityTypeBuilder<Kullanici> builder)
        {
            builder.ToTable("KULLANICILAR");

            builder.Property(x => x.KullaniciID)
                .UseIdentityColumn(1, 1)
                .HasColumnName("KULLANICI_ID");

            builder.Property(x => x.Ad)
             .HasColumnName("AD")
             .HasMaxLength(20)
             .IsRequired();

            builder.Property(x => x.Soyad)
            .HasColumnName("SOYAD")
            .HasMaxLength(20)
            .IsRequired();

            builder.Property(x => x.KullaniciAdi)
             .HasColumnName("KULLANICI_ADI")
             .HasMaxLength(20)
             .IsRequired(true);

            builder.Property(x => x.Sifre)
            .HasColumnName("SIFRE")
            .HasMaxLength(100)
            .IsRequired(true);

            // builder.HasData(new Kullanici { KullaniciID = 1, Ad = "Emre", Soyad = "Güngör", KullaniciAdi = "cevdo", Sifre = Utilities.Utility.SifreMD5("cev_123") });

            builder.HasData(new Kullanici { KullaniciID = 1, Ad = "Emre", Soyad = "Güngör", KullaniciAdi = "admin", Sifre = "admin" });

        }
    }
}
