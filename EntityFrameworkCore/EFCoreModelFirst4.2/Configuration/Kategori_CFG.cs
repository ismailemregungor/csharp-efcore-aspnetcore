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
    public class Kategori_CFG : IEntityTypeConfiguration<Kategori>
    {
        public void Configure(EntityTypeBuilder<Kategori> builder)
        {
            builder.ToTable("KATEGORILER");


            builder.Property(x => x.KategoriID).UseIdentityColumn(4, 1);

            builder.Property(x => x.KategoriID).HasColumnName("KATEGORI_ID");
            builder.Property(x => x.KategoriAdi)
                        .HasColumnName("KATEGORI_ADI")
                        .HasColumnType("NVARCHAR2")
                        .HasMaxLength(30)
                        .IsRequired(true);

            builder.HasData(
                new Kategori { KategoriID = 1, KategoriAdi = "Kırtasiye" },
                new Kategori { KategoriID = 2, KategoriAdi = "Elektronik" },
                  new Kategori { KategoriID = 3, KategoriAdi = "Tekstil" }
                );
        }
    }
}
