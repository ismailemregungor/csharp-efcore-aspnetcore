using BlogApp.Domain.Entites.Abstract;
using BlogApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Domain.Entites
{
	public class Konu : IBaseEntity
	{
		public int KonuID { get; set; }
		public string KonuAdi { get; set; }

		public DateTime EklemeTarihi { get; set; } = DateTime.Now;
		public DateTime? GuncellemeTarihi { get; set; }
		public DateTime? SilmeTarihi { get; set; }
		public KayitDurumu KayitDurumu { get; set; } = KayitDurumu.Aktif;

		public ICollection<Makale> Makaleler { get; set; }
	}
}
