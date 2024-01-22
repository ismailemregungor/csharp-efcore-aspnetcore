using ismailemregungorAlbumDukkani.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ismailemregungorAlbumDukkani.Config
{
    // Sanatci_CFG sınıfı, Sanatci sınıfının veritabanı eşlemesini yapılandırır.
    public class Sanatci_CFG : IEntityTypeConfiguration<Sanatci>
    {
        public void Configure(EntityTypeBuilder<Sanatci> builder)
        {
            builder.ToTable("SANATCILAR");

            builder.HasKey(s => s.SanatciID);

            builder.Property(s => s.SanatciID)
                .UseIdentityColumn(1, 1)
                .HasColumnName("SANATCI_ID");

            builder.Property(s => s.SanatciAdi)
                .IsRequired()
                .HasColumnName("SANATCI_ADI");
        }
    }
}
