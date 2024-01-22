using BlogApp.UI.Models.VMs.KonuVMs;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BlogApp.UI.Models.VMs.MakaleVMs
{
    public class MakaleEkleVM
    {
        [DisplayName("Başlık")]
        [Required(ErrorMessage = "Başlık giriniz!")]
        public string Baslik { get; set; }

        [DisplayName("Detay")]
        [Required(ErrorMessage = "Detay giriniz!")]
        public string Detay { get; set; }

        [DisplayName("Konu")]
        [Required(ErrorMessage = "Konu seçiniz!")]
        public int KonuID { get; set; }

        [DisplayName("Yazar")]
        public string AppUserID { get; set; }

        public List<KonuListeleVM>? Konular { get; set; }

    }
}
