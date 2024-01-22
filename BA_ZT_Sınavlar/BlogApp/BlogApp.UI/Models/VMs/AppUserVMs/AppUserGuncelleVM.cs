using System.ComponentModel;

namespace BlogApp.UI.Models.VMs.AppUserVMs
{
	public class AppUserGuncelleVM
	{
		public string Id { get; set; }

		[DisplayName("Ad")]
		public string Ad { get; set; }

		[DisplayName("Soyad")]
		public string Soyad { get; set; }

		[DisplayName("Email")]
		public string Email { get; set; }

		[DisplayName("Telefon No")]
		public string PhoneNumber { get; set; }

	}
}
