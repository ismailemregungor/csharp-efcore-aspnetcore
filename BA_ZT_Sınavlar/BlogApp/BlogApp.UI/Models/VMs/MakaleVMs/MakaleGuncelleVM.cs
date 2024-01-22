using BlogApp.Domain.Entites;
using BlogApp.UI.Models.VMs.KonuVMs;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BlogApp.UI.Models.VMs.MakaleVMs
{
    public class MakaleGuncelleVM
    {
        public int MakaleID { get; set; }

        [DisplayName("Başlık")]
        [Required(ErrorMessage = "Başlık giriniz!")]
        public string Baslik { get; set; }

        [DisplayName("Detay")]
        [Required(ErrorMessage = "Detay giriniz!")]
        public string Detay { get; set; }

        [DisplayName("Konu")]
        [Required(ErrorMessage = "Konu seçiniz!")]

        public int KonuID { get; set; }
        public Konu? Subject { get; set; }

        [DisplayName("Yazar")]
        public string AppUserID { get; set; }

        public AppUser? AppUser { get; set; }

        public List<KonuListeleVM>? Konular { get; set; }

        public DateTime? EklemeTarihi { get; set; }
    }
}
