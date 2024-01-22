using Microsoft.AspNetCore.Mvc;

namespace ASPNETCOREMVCStateManagement.Controllers
{
    public class StateManagementController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreateCookie()
        {
            // Yaşam Süresi verilmemiş Cookie
            // Response.Cookies.Append("cerezos", "Hello Cookie!");

            // Yaşam Süresi verilmiş Cookie
            Response.Cookies.Append("cerezos", "Hello Cookie!", new CookieOptions { Expires=DateTime.Now.AddDays(15)});
            return Content("Created a cookie");
        }

        public IActionResult ReadCookie()
        {
            return Content("Value = " + Request.Cookies["cerezos"]);
        }

        public IActionResult CreateSession()
        {
            HttpContext.Session.SetString("Mesaj", "Hello Session!");
            return Content("Created a session" + DateTime.Now.ToLongTimeString());
        }
        public IActionResult ReadSession()
        {
            string value = HttpContext.Session.GetString("Mesaj");
            return Content("Value = " + value);
        }
    }
}
