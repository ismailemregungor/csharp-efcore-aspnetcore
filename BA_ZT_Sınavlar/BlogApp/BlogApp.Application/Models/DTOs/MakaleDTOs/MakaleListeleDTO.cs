using BlogApp.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Application.Models.DTOs.MakaleDTOs
{
	public class MakaleListeleDTO
	{
		public int MakaleID { get; set; }
		public string Baslik { get; set; }
		public string Detay { get; set; }
		public DateTime EklemeTarihi { get; set; }
		public AppUser AppUser { get; set; }
		public Konu Konu { get; set; }
	}
}
