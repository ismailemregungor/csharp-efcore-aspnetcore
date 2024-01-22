using EFCoreSinavProvaCA2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreSinavProvaCA2.Config
{
    public class Album_CFG : IEntityTypeConfiguration<Album>
    {
        public void Configure(EntityTypeBuilder<Album> builder)
        {
            builder.ToTable("ALBUMLER");

            builder.HasKey(a => a.AlbumID);

            builder.Property(x => x.AlbumID)
                .UseIdentityColumn(1, 1)
                .HasColumnName("ALBUM_ID");

            builder.Property(a => a.AlbumAdi)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(a => a.YayimTarihi)
                .IsRequired();
        }
    }
}
