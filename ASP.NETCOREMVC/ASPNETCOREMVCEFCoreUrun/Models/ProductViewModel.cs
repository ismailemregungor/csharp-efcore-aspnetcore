using Microsoft.AspNetCore.Mvc.Rendering;

namespace ASPNETCOREMVCEFCoreUrun.Models
{
    public class ProductViewModel
    {
        public Product Product { get; set; }
        public SelectList Brands { get; set; }
        public SelectList Categories { get; set; }
    }

}
