using Microsoft.AspNetCore.Mvc;

namespace ASPNETCOREMVCArea.Areas.UyePanel.Controllers
{
    [Area("UyePanel")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
