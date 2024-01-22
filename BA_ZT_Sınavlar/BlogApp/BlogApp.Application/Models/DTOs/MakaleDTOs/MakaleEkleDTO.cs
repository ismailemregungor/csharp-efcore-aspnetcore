using BlogApp.Application.Models.DTOs.KonuDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Application.Models.DTOs.MakaleDTOs
{
	public class MakaleEkleDTO
	{
		public string Baslik { get; set; }
		public string Detay { get; set; }
		public int KonuID { get; set; }
		public string AppUserID { get; set; }
		public List<KonuListeleDTO> Konular { get; set; }
	}
}
