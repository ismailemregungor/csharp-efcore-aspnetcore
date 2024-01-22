using BlogApp.Domain.Entites;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Infrastructure.EntityTypeConfig
{
	public class AppRole_CFG : IEntityTypeConfiguration<AppRole>
	{
		public void Configure(EntityTypeBuilder<AppRole> builder)
		{
			// Sabit GUID'ler
			var adminRoleId = "0e765f44-e69b-4588-ba19-b9e0a667b7d6"; // Admin rolü için sabit bir GUID
			var userRoleId = "e64f5d2b-64b8-45f8-9f68-1150a68b97f7";  // Kullanıcı rolü için sabit bir GUID

			// Roller
			builder.HasData(
				new AppRole { Id = adminRoleId, Name = "Admin", NormalizedName = "ADMIN" },
				new AppRole { Id = userRoleId, Name = "Uye", NormalizedName = "UYE" }
			);
		}
	}
}
