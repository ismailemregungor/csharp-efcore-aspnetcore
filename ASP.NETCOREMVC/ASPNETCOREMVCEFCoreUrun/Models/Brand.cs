namespace ASPNETCOREMVCEFCoreUrun.Models
{
    public class Brand
    {
        public int BrandID { get; set; }
        public string Name { get; set; }
        public ICollection<Product>? Products { get; set; }
    }
}
