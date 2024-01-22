using System.ComponentModel;

namespace BlogApp.UI.Models.VMs.KonuVMs
{
    public class KonuListeleVM
    {
        public int KonuID { get; set; }

        [DisplayName("Konu Adı")]
        public string KonuAdi { get; set; }
    }
}
