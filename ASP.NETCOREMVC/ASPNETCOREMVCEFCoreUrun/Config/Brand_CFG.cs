using ASPNETCOREMVCEFCoreUrun.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace ASPNETCOREMVCEFCoreUrun.Config
{
    public class Brand_CFG : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.ToTable("BRANDS");
        }
    }
}
