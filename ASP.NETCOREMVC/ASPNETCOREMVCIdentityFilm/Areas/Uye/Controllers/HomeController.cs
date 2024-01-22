using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace ASPNETCOREMVCIdentityFilm.Areas.Uye.Controllers
{
    [Area("Uye")]
    [Authorize(Roles = "User, Admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
