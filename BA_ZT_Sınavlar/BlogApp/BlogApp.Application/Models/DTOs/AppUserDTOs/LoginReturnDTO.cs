using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Application.Models.DTOs.AppUserDTOs
{
	public class LoginReturnDTO
	{
		public bool IsUser { get; set; }
		public bool IsAdmin { get; set; }
	}
}
