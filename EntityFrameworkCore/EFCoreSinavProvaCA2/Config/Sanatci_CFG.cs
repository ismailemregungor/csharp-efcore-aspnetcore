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
    public class Sanatci_CFG : IEntityTypeConfiguration<Sanatci>
    {
        public void Configure(EntityTypeBuilder<Sanatci> builder)
        {
            builder.ToTable("SANATCILAR");

            builder.HasKey(s => s.SanatciID);

            builder.Property(x => x.SanatciID)
                .UseIdentityColumn(1, 1)
                .HasColumnName("SANATCI_ID");

            builder.Property(s => s.SanatciAdi)
                .IsRequired()
                .HasMaxLength(200);
        }
    }
}
