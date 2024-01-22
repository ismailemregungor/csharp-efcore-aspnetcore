using ASPNETCOREMVCEFCoreUrun.Config;
using ASPNETCOREMVCEFCoreUrun.Models;
using Microsoft.EntityFrameworkCore;

namespace ASPNETCOREMVCEFCoreUrun.Data
{
    public class ProductContext : DbContext
    {
        //public ProductContext()
        //{

        //}

        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Brand> Brands { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    base.OnConfiguring(optionsBuilder);

        //    optionsBuilder.UseOracle("User Id = product; Password = product; Data Source = (DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = 127.0.0.1)(PORT = 1521)))(CONNECT_DATA = (SERVER = DEDICATED)(SID = orcl)))");
        //}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new Category_CFG());
            modelBuilder.ApplyConfiguration(new Brand_CFG());
            modelBuilder.ApplyConfiguration(new Product_CFG());
        }
    }
}
