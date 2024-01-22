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
    public class Yayinevi_CFG : IEntityTypeConfiguration<Yayinevi>
    {
        public void Configure(EntityTypeBuilder<Yayinevi> builder)
        {
            builder.ToTable("YAYINEVLERI");

            builder.Property(x => x.YayinEviID)
                .UseIdentityColumn(1, 1)
                .HasColumnName("YAYINEVI_ID");

            builder.Property(x => x.YayineviAdi)
             .HasColumnName("YAYINEVI_ADI")
             .HasMaxLength(200)
             .IsRequired();

            builder.Property(x => x.Adres)
             .HasColumnName("ADRES")
             .IsRequired(false);


            //builder.HasData(
            //    new Yayinevi { YayinEviID = 1, YayineviAdi = "Alfa", Adres = "Kadıkoy" },
            //    new Yayinevi { YayinEviID = 2, YayineviAdi = "Is Bankasi Yayinlari", Adres = "Sisli" },
            //    new Yayinevi { YayinEviID = 3, YayineviAdi = "Gama", Adres = "Besiktas" },
            //    new Yayinevi { YayinEviID = 4, YayineviAdi = "Beta", Adres = "Beyoglu" },
            //    new Yayinevi { YayinEviID = 5, YayineviAdi = "Delta", Adres = "Atasehir" },
            //    new Yayinevi { YayinEviID = 6, YayineviAdi = "Epsilon", Adres = "Uskudar" },
            //    new Yayinevi { YayinEviID = 7, YayineviAdi = "Zeta", Adres = "Kagithane" },
            //    new Yayinevi { YayinEviID = 8, YayineviAdi = "Eta", Adres = "Maltepe" },
            //    new Yayinevi { YayinEviID = 9, YayineviAdi = "Theta", Adres = "Bakirkoy" },
            //    new Yayinevi { YayinEviID = 10, YayineviAdi = "Iota", Adres = "Avcilar" },
            //    new Yayinevi { YayinEviID = 11, YayineviAdi = "Kappa", Adres = "Bahcelievler" },
            //    new Yayinevi { YayinEviID = 12, YayineviAdi = "Lambda", Adres = "Gungoren" },
            //    new Yayinevi { YayinEviID = 13, YayineviAdi = "Mu", Adres = "Esenler" },
            //    new Yayinevi { YayinEviID = 14, YayineviAdi = "Nu", Adres = "Sancaktepe" },
            //    new Yayinevi { YayinEviID = 15, YayineviAdi = "Xi", Adres = "Sultanbeyli" }
            //);

            //builder.HasData(new Yayinevi { YayinEviID = 1, YayineviAdi = "Alfa", Adres = "Kadıkoy" });
            //builder.HasData(new Yayinevi { YayinEviID = 2, YayineviAdi = "Is Bankasi Yayinlari", Adres = "Sisli" });
            //builder.HasData(new Yayinevi { YayinEviID = 3, YayineviAdi = "Gama", Adres = "Besiktas" });
            //builder.HasData(new Yayinevi { YayinEviID = 4, YayineviAdi = "Beta", Adres = "Beyoglu" });
            //builder.HasData(new Yayinevi { YayinEviID = 5, YayineviAdi = "Delta", Adres = "Atasehir" });
            //builder.HasData(new Yayinevi { YayinEviID = 6, YayineviAdi = "Epsilon", Adres = "Uskudar" });
            //builder.HasData(new Yayinevi { YayinEviID = 7, YayineviAdi = "Zeta", Adres = "Kagithane" });
            //builder.HasData(new Yayinevi { YayinEviID = 8, YayineviAdi = "Eta", Adres = "Maltepe" });
            //builder.HasData(new Yayinevi { YayinEviID = 9, YayineviAdi = "Theta", Adres = "Bakirkoy" });
            //builder.HasData(new Yayinevi { YayinEviID = 10, YayineviAdi = "Iota", Adres = "Avcilar" });
            //builder.HasData(new Yayinevi { YayinEviID = 11, YayineviAdi = "Kappa", Adres = "Bahcelievler" });
            //builder.HasData(new Yayinevi { YayinEviID = 12, YayineviAdi = "Lambda", Adres = "Gungoren" });
            //builder.HasData(new Yayinevi { YayinEviID = 13, YayineviAdi = "Mu", Adres = "Esenler" });
            //builder.HasData(new Yayinevi { YayinEviID = 14, YayineviAdi = "Nu", Adres = "Sancaktepe" });
            //builder.HasData(new Yayinevi { YayinEviID = 15, YayineviAdi = "Xi", Adres = "Sultanbeyli" });

            //builder.HasData(
            //    new Yayinevi { YayineviAdi = "Alfa", Adres = "Kadıkoy" },
            //    new Yayinevi { YayineviAdi = "Is Bankasi Yayinlari", Adres = "Sisli" },
            //    new Yayinevi { YayineviAdi = "Gama", Adres = "Besiktas" },
            //    new Yayinevi { YayineviAdi = "Beta", Adres = "Beyoglu" },
            //    new Yayinevi { YayineviAdi = "Delta", Adres = "Atasehir" },
            //    new Yayinevi { YayineviAdi = "Epsilon", Adres = "Uskudar" },
            //    new Yayinevi { YayineviAdi = "Zeta", Adres = "Kagithane" },
            //    new Yayinevi { YayineviAdi = "Eta", Adres = "Maltepe" },
            //    new Yayinevi { YayineviAdi = "Theta", Adres = "Bakirkoy" },
            //    new Yayinevi { YayineviAdi = "Iota", Adres = "Avcilar" },
            //    new Yayinevi { YayineviAdi = "Kappa", Adres = "Bahcelievler" },
            //    new Yayinevi { YayineviAdi = "Lambda", Adres = "Gungoren" },
            //    new Yayinevi { YayineviAdi = "Mu", Adres = "Esenler" },
            //    new Yayinevi { YayineviAdi = "Nu", Adres = "Sancaktepe" },
            //    new Yayinevi { YayineviAdi = "Xi", Adres = "Sultanbeyli" }
            //);
        }
    }
}
