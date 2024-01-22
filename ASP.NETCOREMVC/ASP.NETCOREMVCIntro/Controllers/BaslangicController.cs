using Microsoft.AspNetCore.Mvc;

namespace ASP.NETCOREMVCIntro.Controllers
{
	public class BaslangicController : Controller
	{
		//public IActionResult Index()
		//{

		//    return View();
		//}

		public string Index()
		{

			return "Merhaba MVC....";
		}

		public string Detay()
		{

			return "Detaylar....";
		}

		public string Html()
		{

			return "<h1>Merhaba MVC</h1>";
		}

		public IActionResult Yaz()
		{

			return Content("Yaz .....");
		}

		public IActionResult SayfaGoster()
		{

			return View();
		}

	}
}
