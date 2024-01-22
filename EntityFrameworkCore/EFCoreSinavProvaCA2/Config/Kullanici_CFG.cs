using EFCoreSinavProvaCA2.Models;
using EFCoreSinavProvaCA2.Utilities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreSinavProvaCA2.Config
{
    public class Kullanici_CFG : IEntityTypeConfiguration<Kullanici>
    {
        public void Configure(EntityTypeBuilder<Kullanici> builder)
        {
            // Veritabanı tablosunun adını belirtir.
            builder.ToTable("KULLANICILAR");

            // Tablonun anahtarını (primary key) belirtir.
            builder.HasKey(k => k.KullaniciID);

            // KullaniciID sütununun yapılandırmasını belirtir.
            builder.Property(x => x.KullaniciID)
                .UseIdentityColumn(1, 1) // Otomatik artan sütun olarak yapılandırır.
                .HasColumnName("KULLANICI_ID"); // Sütunun adını belirtir.

            // Ad sütununun yapılandırmasını belirtir.
            builder.Property(k => k.Ad)
                .IsRequired() // Zorunlu alan olduğunu belirtir.
                .HasMaxLength(50); // Maksimum karakter uzunluğunu sınırlar.

            // Soyad sütununun yapılandırmasını belirtir.
            builder.Property(k => k.Soyad)
                .IsRequired() // Zorunlu alan olduğunu belirtir.
                .HasMaxLength(50); // Maksimum karakter uzunluğunu sınırlar.

            // KullaniciAdi sütununun yapılandırmasını belirtir.
            builder.Property(k => k.KullaniciAdi)
                .IsRequired() // Zorunlu alan olduğunu belirtir.
                .HasMaxLength(50); // Maksimum karakter uzunluğunu sınırlar.

            // Sifre sütununun yapılandırmasını belirtir.
            builder.Property(k => k.Sifre)
                .IsRequired(); // Zorunlu alan olduğunu belirtir.

            // Örnek veri eklemek için kullanılır (Şifre hash'lenmiş olarak ekleniyor).
            builder.HasData(
                new Kullanici
                {
                    KullaniciID = 1,
                    Ad = "Admin-1",
                    Soyad = "Admin-1",
                    KullaniciAdi = "Admin-1",
                    Sifre = Utility.HashPassword("Admin-1") // Şifre hash'leniyor
                }
            );
        }
    }
}
