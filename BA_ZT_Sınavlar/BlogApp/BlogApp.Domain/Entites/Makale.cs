using BlogApp.Domain.Entites.Abstract;
using BlogApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Domain.Entites
{
	public class Makale : IBaseEntity
	{
		public int MakaleID { get; set; }
		public string Baslik { get; set; }
		public string Detay { get; set; }

		public DateTime EklemeTarihi { get; set; } = DateTime.Now;
		public DateTime? GuncellemeTarihi { get; set; }
		public DateTime? SilmeTarihi { get; set; }
		public KayitDurumu KayitDurumu { get; set; } = KayitDurumu.Aktif;

		public int KonuID { get; set; }
		public Konu Konu { get; set; }

		public string AppUserID { get; set; }
		public AppUser AppUser { get; set; }

	}
}
