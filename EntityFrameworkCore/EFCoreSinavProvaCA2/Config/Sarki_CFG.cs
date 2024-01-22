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
    public class Sarki_CFG : IEntityTypeConfiguration<Sarki>
    {
        public void Configure(EntityTypeBuilder<Sarki> builder)
        {
            builder.ToTable("SARKILAR");

            builder.HasKey(s => s.SarkiID);

            builder.Property(x => x.SarkiID)
                .UseIdentityColumn(1, 1)
                .HasColumnName("SARKI_ID");

            builder.Property(s => s.SarkiAdi)
                .IsRequired()
                .HasMaxLength(200);
        }
    }
}
