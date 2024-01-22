using BlogApp.Domain.Entites;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogApp.Infrastructure.EntityTypeConfig;

namespace BlogApp.Infrastructure.Context
{
	public class BlogContext : IdentityDbContext<AppUser, AppRole, string>
	{
		public BlogContext()
		{

		}

		public BlogContext(DbContextOptions<BlogContext> options) : base(options)
		{

		}

		public DbSet<Konu> Konular { get; set; }
		public DbSet<Makale> Makaleler { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			base.OnConfiguring(optionsBuilder);

			optionsBuilder.UseOracle("User Id = blogapp1; Password = blogapp1; Data Source = (DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = 127.0.0.1)(PORT = 1521)))(CONNECT_DATA = (SERVER = DEDICATED)(SID = orcl)))");
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.ApplyConfiguration(new Konu_CFG());
			modelBuilder.ApplyConfiguration(new Makale_CFG());
			modelBuilder.ApplyConfiguration(new AppUser_CFG());
			modelBuilder.ApplyConfiguration(new AppRole_CFG());

			// Sabit GUID'ler
			var adminRoleId = "0e765f44-e69b-4588-ba19-b9e0a667b7d6";
			var userId = "b79b4f50-e3b6-40a5-9b08-6f608b4f30d0";

			// Kullanıcı-Rol ilişkisi
			modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
			{
				UserId = userId,
				RoleId = adminRoleId
			});
		}
	}
}
