using ASPNETCOREMVCIdentityFilm.Data;
using ASPNETCOREMVCIdentityFilm.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ASPNETCOREMVCIdentityFilm.Controllers
{
    public class FilmController : Controller
    {
        private readonly FilmContext _filmContext;
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<AppRole> _roleManager;

        public FilmController(FilmContext filmContext, UserManager<AppUser> userManager, RoleManager<AppRole> roleManager)
        {
            _filmContext = filmContext;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        // Rol eklemek için yazdığımız action. Tekrar eklemek istersek public yapmak gerekir!
        private async Task<IActionResult> AddRoles()
        {
            await _roleManager.CreateAsync(new AppRole { Id = 1, Name = "Admin"});
            await _roleManager.CreateAsync(new AppRole { Id = 2, Name = "User" });
            return Content("İşlem Başarılı!");
        }
    }
}
