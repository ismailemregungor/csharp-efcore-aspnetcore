using ASPNETCOREMVCIdentityFilm.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ASPNETCOREMVCIdentityFilm.Data
{
    // Artık Identity User; AppUser, IdentityRole; AppRole, Primary Key; int olacak diyoruz.
    public class FilmContext : IdentityDbContext<AppUser, AppRole, int>
    {
        public DbSet<Film> Filmler { get; set; }
        public FilmContext(DbContextOptions<FilmContext> options) : base(options)
        {

        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    base.OnConfiguring(optionsBuilder);

        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Film>().ToTable("FILMLER");
        }
    }
}
