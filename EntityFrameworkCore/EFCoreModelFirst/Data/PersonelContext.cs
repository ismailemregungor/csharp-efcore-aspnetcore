using EFCoreModelFirst.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreModelFirst.Data
{
    public class PersonelContext : DbContext
    {
        /*
         * Tasarım zamanı migration için, parametresiz default kurucu kullanmanız gerekmektedir.
         */
        public PersonelContext()
        {

        }
        public PersonelContext(DbContextOptions<PersonelContext> options) : base(options)
        {

        }

        // Personel tipinde Personeller isminde bir veri tabanı tablosu oluşacak.
        public DbSet<Personel> PERSONELLER { get; set; }
        public DbSet<Bolum> BOLUMLER { get; set; }
        public DbSet<Proje> PROJELER { get; set; }
        public DbSet<PersonelProje> PERSONELPROJELERI { get; set; }
        public DbSet<PersonelDetay> PERSONELDETAYLARI { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseOracle("User Id=personel; Password=personel; Data Source = (DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = 127.0.0.1)(PORT = 1521)))(CONNECT_DATA = (SERVER=DEDICATED)(SID = orcl)))");
        }
    }
}
