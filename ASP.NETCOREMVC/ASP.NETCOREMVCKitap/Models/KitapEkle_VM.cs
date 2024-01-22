using Microsoft.AspNetCore.Mvc.Rendering;

namespace ASP.NETCOREMVCKitap.Models
{
	public class KitapEkle_VM
	{
        public Kitap Kitap { get; set; }
        public SelectList Kategoriler { get; set; }
        public SelectList Yazarlar { get; set; }
    }
}
