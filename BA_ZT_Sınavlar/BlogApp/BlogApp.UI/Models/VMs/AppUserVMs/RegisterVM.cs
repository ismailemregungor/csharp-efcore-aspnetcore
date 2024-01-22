using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BlogApp.UI.Models.VMs.AppUserVMs
{
	public class RegisterVM
	{
		[DisplayName("Email")]
		[Required(ErrorMessage = "Email giriniz!")]
		public string Email { get; set; }

		[DisplayName("Şifre")]
		[DataType(DataType.Password)]
		[StringLength(50, ErrorMessage = "Şifre max 50 min 3 karakter olmalıdır!", MinimumLength = 5)]
		[Required(ErrorMessage = "Şifre giriniz!")]
		public string Password { get; set; }

		[Required(ErrorMessage = "Şifre tekrarını giriniz!")]
		[DisplayName("Şifre Tekrarı:")]
		[DataType(DataType.Password)]
		[Compare("Password", ErrorMessage = "Girilen şifreler aynı olmak zorundadır!")]
		[StringLength(50, ErrorMessage = "Şifre max 50 min 3 karakter olmalıdır!", MinimumLength = 5)]
		public string ConfirmPassword { get; set; }
	}
}
