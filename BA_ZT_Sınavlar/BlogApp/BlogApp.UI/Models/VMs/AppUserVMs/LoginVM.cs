using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BlogApp.UI.Models.VMs.AppUserVMs
{
	public class LoginVM
	{
		[DisplayName("Email")]
		[Required(ErrorMessage = "Email adresi girmek zorunludur!")]
		public string Email { get; set; }

		[DisplayName("Şifre")]
		[Required(ErrorMessage = "Şifre zorunludur!")]
		public string Password { get; set; }
	}
}
