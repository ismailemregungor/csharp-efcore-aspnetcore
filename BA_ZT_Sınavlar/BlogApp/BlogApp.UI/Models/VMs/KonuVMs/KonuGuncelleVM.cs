using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BlogApp.UI.Models.VMs.KonuVMs
{
    public class KonuGuncelleVM
    {
        public int KonuID { get; set; }

        [DisplayName("Konu Adı")]
        [Required(ErrorMessage = "Konu adı giriniz!")]
        public string KonuAdi { get; set; }
    }
}
