using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ASPNETCOREMVCEFCoreUrun.Models;

namespace ASPNETCOREMVCEFCoreUrun.Config
{
    public class Product_CFG : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("PRODUCTS");
        }
    }
}
