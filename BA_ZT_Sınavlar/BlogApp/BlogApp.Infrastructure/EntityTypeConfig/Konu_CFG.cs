using BlogApp.Domain.Entites;
using BlogApp.Domain.Enums;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Infrastructure.EntityTypeConfig
{
	public class Konu_CFG : IEntityTypeConfiguration<Konu>
	{
		public void Configure(EntityTypeBuilder<Konu> builder)
		{
			builder.ToTable("KONULAR");

			builder.Property(x => x.KonuID).UseIdentityColumn(6, 1);

			builder.HasData(
				new Konu
				{
					KonuID = 1,
					KonuAdi = "Ekonomi",
					EklemeTarihi = DateTime.Now,
					KayitDurumu = KayitDurumu.Aktif
				},
				new Konu
				{
					KonuID = 2,
					KonuAdi = "Bilim",
					EklemeTarihi = DateTime.Now,
					KayitDurumu = KayitDurumu.Aktif
				},
				new Konu
				{
					KonuID = 3,
					KonuAdi = "Teknoloji",
					EklemeTarihi = DateTime.Now,
					KayitDurumu = KayitDurumu.Aktif
				},
				new Konu
				{
					KonuID = 4,
					KonuAdi = "Sağlık",
					EklemeTarihi = DateTime.Now,
					KayitDurumu = KayitDurumu.Aktif
				},
				new Konu
				{
					KonuID = 5,
					KonuAdi = "Tarih",
					EklemeTarihi = DateTime.Now,
					KayitDurumu = KayitDurumu.Aktif
				});
		}
	}
}
