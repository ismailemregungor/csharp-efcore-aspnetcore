using ismailemregungorAlbumDukkani.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ismailemregungorAlbumDukkani.Config
{
    // Album_CFG sınıfı, Album sınıfının veritabanı eşlemesini yapılandırır.
    public class Album_CFG : IEntityTypeConfiguration<Album>
    {
        public void Configure(EntityTypeBuilder<Album> builder)
        {
            builder.ToTable("ALBUMLER");

            builder.HasKey(a => a.AlbumID);

            builder.Property(a => a.AlbumID)
                .UseIdentityColumn(1, 1)
                .HasColumnName("ALBUM_ID");

            builder.Property(a => a.AlbumAdi)
                .HasColumnName("ALBUM_ADI");

            builder.Property(a => a.YayimTarihi)
                .HasColumnName("YAYIM_TARİHİ");

            builder.Property(a => a.YayimTarihi)
                .HasColumnName("YAYIM_TARİHİ");

            builder.Property(a => a.Fiyat)
                .HasColumnName("ALBUM_FİYATI");

            builder.Property(a => a.IndirimOrani)
                .HasColumnName("INDIRIM_ORANI");

            builder.Property(a => a.AlbumDurumu)
                .HasColumnName("ALBUM_DURUMU");
        }
    }
}
