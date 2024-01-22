using EFCoreSinavProvaCA1.Enums;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFCoreSinavProvaCA1.Models;

namespace EFCoreSinavProvaCA1.Config
{
    public class Kitap_CFG : IEntityTypeConfiguration<Kitap>
    {
        public void Configure(EntityTypeBuilder<Kitap> builder)
        {
            builder.ToTable("KITAPLAR");

            builder.Property(x => x.KitapID)
                .UseIdentityColumn(1, 1)
                .HasColumnName("KITAP_ID");

            builder.Property(x => x.KitapAdi)
             .HasColumnName("KITAP_ADI")
             .HasMaxLength(200)
             .IsRequired();

            builder.Property(x => x.StokAdedi)
             .HasColumnName("STOK_ADEDI")
             .IsRequired(true);

            builder.Property(x => x.Fiyat)
             .HasColumnName("FIYAT")
             .IsRequired();

            builder.Property(x => x.KitapDurumu)
             .HasColumnName("KITAP_DURUMU")
             .IsRequired(true).HasDefaultValue(KitapDurumu.Aktif);

            builder.Property(x => x.EklemeTarih)
            .HasColumnName("EKLEME_TARIHI")
            .IsRequired();

            //builder.HasData(
            //    new Kitap { KitapID = 1, KitapAdi = "Varoluş", StokAdedi = 30, Fiyat = 150.00, KitapDurumu = KitapDurumu.Pasif, EklemeTarih = new DateTime(2023, 1, 1), YayinEviID = 1 },
            //    new Kitap { KitapID = 2, KitapAdi = "Zamanın Kısa Tarihi", StokAdedi = 15, Fiyat = 80.00, KitapDurumu = KitapDurumu.Aktif, EklemeTarih = new DateTime(2023, 1, 2), YayinEviID = 2 },
            //    new Kitap { KitapID = 3, KitapAdi = "Bilinmeyen Bir Kadının Mektubu", StokAdedi = 20, Fiyat = 90.00, KitapDurumu = KitapDurumu.Aktif, EklemeTarih = new DateTime(2023, 1, 3), YayinEviID = 3 },
            //    new Kitap { KitapID = 4, KitapAdi = "Suç ve Ceza", StokAdedi = 25, Fiyat = 120.00, KitapDurumu = KitapDurumu.Aktif, EklemeTarih = new DateTime(2023, 1, 4), YayinEviID = 4 },
            //    new Kitap { KitapID = 5, KitapAdi = "1984", StokAdedi = 18, Fiyat = 110.00, KitapDurumu = KitapDurumu.Pasif, EklemeTarih = new DateTime(2023, 1, 5), YayinEviID = 5 },
            //    new Kitap { KitapID = 6, KitapAdi = "Yüzüklerin Efendisi", StokAdedi = 12, Fiyat = 200.00, KitapDurumu = KitapDurumu.Aktif, EklemeTarih = new DateTime(2023, 1, 6), YayinEviID = 6 },
            //    new Kitap { KitapID = 7, KitapAdi = "Dönüşüm", StokAdedi = 22, Fiyat = 85.00, KitapDurumu = KitapDurumu.Aktif, EklemeTarih = new DateTime(2023, 1, 7), YayinEviID = 7 },
            //    new Kitap { KitapID = 8, KitapAdi = "Savaş ve Barış", StokAdedi = 17, Fiyat = 160.00, KitapDurumu = KitapDurumu.Pasif, EklemeTarih = new DateTime(2023, 1, 8), YayinEviID = 8 },
            //    new Kitap { KitapID = 9, KitapAdi = "Karamazov Kardeşler", StokAdedi = 28, Fiyat = 140.00, KitapDurumu = KitapDurumu.Aktif, EklemeTarih = new DateTime(2023, 1, 9), YayinEviID = 9 },
            //    new Kitap { KitapID = 10, KitapAdi = "Alice Harikalar Diyarında", StokAdedi = 14, Fiyat = 75.00, KitapDurumu = KitapDurumu.Aktif, EklemeTarih = new DateTime(2023, 1, 10), YayinEviID = 10 },
            //    new Kitap { KitapID = 11, KitapAdi = "Sefiller", StokAdedi = 21, Fiyat = 130.00, KitapDurumu = KitapDurumu.Pasif, EklemeTarih = new DateTime(2023, 1, 11), YayinEviID = 11 },
            //    new Kitap { KitapID = 12, KitapAdi = "Harry Potter ve Felsefe Taşı", StokAdedi = 13, Fiyat = 95.00, KitapDurumu = KitapDurumu.Aktif, EklemeTarih = new DateTime(2023, 1, 12), YayinEviID = 12 },
            //    new Kitap { KitapID = 13, KitapAdi = "Yabancı", StokAdedi = 24, Fiyat = 110.00, KitapDurumu = KitapDurumu.Pasif, EklemeTarih = new DateTime(2023, 1, 13), YayinEviID = 13 },
            //    new Kitap { KitapID = 14, KitapAdi = "Kırmızı Pazartesi", StokAdedi = 19, Fiyat = 88.00, KitapDurumu = KitapDurumu.Aktif, EklemeTarih = new DateTime(2023, 1, 14), YayinEviID = 14 },
            //    new Kitap { KitapID = 15, KitapAdi = "Simyacı", StokAdedi = 16, Fiyat = 70.00, KitapDurumu = KitapDurumu.Aktif, EklemeTarih = new DateTime(2023, 1, 15), YayinEviID = 15 },
            //    new Kitap { KitapID = 16, KitapAdi = "Yeni Kitap 16", StokAdedi = 30, Fiyat = 150.00, KitapDurumu = KitapDurumu.Pasif, EklemeTarih = new DateTime(2023, 1, 16), YayinEviID = 1 },
            //    new Kitap { KitapID = 17, KitapAdi = "Yeni Kitap 17", StokAdedi = 15, Fiyat = 80.00, KitapDurumu = KitapDurumu.Aktif, EklemeTarih = new DateTime(2023, 1, 17), YayinEviID = 2 },
            //    new Kitap { KitapID = 18, KitapAdi = "Yeni Kitap 18", StokAdedi = 20, Fiyat = 90.00, KitapDurumu = KitapDurumu.Aktif, EklemeTarih = new DateTime(2023, 1, 18), YayinEviID = 3 },
            //    new Kitap { KitapID = 19, KitapAdi = "Yeni Kitap 19", StokAdedi = 25, Fiyat = 120.00, KitapDurumu = KitapDurumu.Aktif, EklemeTarih = new DateTime(2023, 1, 19), YayinEviID = 4 },
            //    new Kitap { KitapID = 20, KitapAdi = "Yeni Kitap 20", StokAdedi = 18, Fiyat = 110.00, KitapDurumu = KitapDurumu.Pasif, EklemeTarih = new DateTime(2023, 1, 20), YayinEviID = 5 }

            //);
        }
    }
}
