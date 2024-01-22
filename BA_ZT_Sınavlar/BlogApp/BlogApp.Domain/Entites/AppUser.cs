using BlogApp.Domain.Entites.Abstract;
using BlogApp.Domain.Enums;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Domain.Entites
{
	public class AppUser : IdentityUser, IBaseEntity
	{
		public string Ad { get; set; }
		public string Soyad { get; set; }

		public DateTime EklemeTarihi { get; set; } = DateTime.Now;
		public DateTime? GuncellemeTarihi { get; set; }
		public DateTime? SilmeTarihi { get; set; }
		public KayitDurumu KayitDurumu { get; set; } = KayitDurumu.Aktif;

		public ICollection<Makale> Makaleler { get; set; }
	}
}
