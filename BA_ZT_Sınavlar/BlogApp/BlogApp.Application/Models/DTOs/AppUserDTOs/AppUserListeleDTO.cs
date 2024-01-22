using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Application.Models.DTOs.AppUserDTOs
{
	public class AppUserListeleDTO
	{
		public string Id { get; set; }
		public string Ad { get; set; }
		public string Soyad { get; set; }
		public string UserName { get; set; }
		public string Email { get; set; }
		public string PhoneNumber { get; set; }
	}
}
