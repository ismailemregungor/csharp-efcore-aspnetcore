using EFCoreModelFirst3.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreModelFirst3.Data
{
    public class OkulContext : DbContext
    {
        public OkulContext()
        {

        }

        public OkulContext(DbContextOptions<OkulContext> options) : base(options)
        {

        }

        public DbSet<Ogrenci> Ogrenciler { get; set; }
        public DbSet<Ders> Dersler { get; set; }
        public DbSet<Egitmen> Egitmenler { get; set; }
        public DbSet<OgrenciDers> OgrenciDersleri { get; set; }
        public DbSet<EgitmenDers> EgitmenDersleri { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseOracle("User Id=okul; Password=okul; Data Source = (DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = 127.0.0.1)(PORT = 1521)))(CONNECT_DATA = (SERVER=DEDICATED)(SID = orcl)))");
        }
    }
}
