using BlogApp.Domain.Entites;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Infrastructure.EntityTypeConfig
{
	public class AppUser_CFG : IEntityTypeConfiguration<AppUser>
	{
		public void Configure(EntityTypeBuilder<AppUser> builder)
		{
			var superUserId = "b79b4f50-e3b6-40a5-9b08-6f608b4f30d0";  // SuperUser için sabit bir GUID

			var superUser = new AppUser()
			{
				Id = superUserId,
				Ad = "Deneme1",
				Soyad = "Deneme1",
				Email = "deneme1@gmail.com",
				NormalizedEmail = "DENEME1@GMAIL.COM",
				UserName = "deneme1",
				NormalizedUserName = "DENEME1",
				SecurityStamp = Guid.NewGuid().ToString(),
				ConcurrencyStamp = Guid.NewGuid().ToString(),
				EmailConfirmed = false,
			};

			PasswordHasher<AppUser> hasher = new PasswordHasher<AppUser>();
			superUser.PasswordHash = hasher.HashPassword(superUser, "Deneme.1");

			builder.HasData(superUser);
		}
	}
}
