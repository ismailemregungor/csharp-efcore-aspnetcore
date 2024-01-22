using System.ComponentModel.DataAnnotations.Schema;

namespace ASPNETCOREMVCEFCoreUrun.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string? Description { get; set; }
        public string? ImagePath { get; set; }
        [NotMapped]
        public IFormFile? Image { get; set; }
        public int BrandID { get; set; }
        public Brand? Brand { get; set; }
        public int CategoryID { get; set; }
        public Category? Category { get; set; }
    }
}
