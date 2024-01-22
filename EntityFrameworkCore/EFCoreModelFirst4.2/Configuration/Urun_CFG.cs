using EFCoreModelFirst4._2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreModelFirst4._2.Configuration
{
    public class Urun_CFG : IEntityTypeConfiguration<Urun>
    {
        public void Configure(EntityTypeBuilder<Urun> builder)
        {
            builder.ToTable("URUNLER");
            builder.Property(x => x.UrunID).HasColumnName("URUN_ID");
            builder.Property(x => x.UrunAdi).HasColumnName("URUN_ADI");
            builder.Property(x => x.Fiyat).HasColumnName("FIYAT");
            builder.Property(x => x.KategoriID).HasColumnName("KATEGORI_ID");
        }
    }
}
