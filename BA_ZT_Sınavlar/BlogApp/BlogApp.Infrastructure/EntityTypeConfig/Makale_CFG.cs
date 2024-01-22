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
	public class Makale_CFG : IEntityTypeConfiguration<Makale>
	{
		public void Configure(EntityTypeBuilder<Makale> builder)
		{
			builder.ToTable("MAKALELER");
		}
	}
}
