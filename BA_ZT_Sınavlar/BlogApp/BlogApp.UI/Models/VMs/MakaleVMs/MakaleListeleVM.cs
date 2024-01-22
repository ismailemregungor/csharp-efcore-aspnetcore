using BlogApp.Domain.Entites;
using System.ComponentModel;

namespace BlogApp.UI.Models.VMs.MakaleVMs
{
    public class MakaleListeleVM
    {
        public int MakaleID { get; set; }

        [DisplayName("Başlık")]
        public string Baslik { get; set; }

        [DisplayName("Detay")]
        public string Detay { get; set; }

        [DisplayName("Ekleme Tarihi")]
        public DateTime EklemeTarihi { get; set; }

        public AppUser AppUser { get; set; }
        public Konu Konu { get; set; }

    }
}
