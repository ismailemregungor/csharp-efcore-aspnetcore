using ASPNETCOREWebApiDbFirstUrunApiClient2.Models;
using ASPNETCOREWebApiDbFirstUrunApiClient2.Utility;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;


namespace ASPNETCOREWebApiDbFirstUrunApiClient2.Controllers
{
    public class HomeController : Controller
    {
        ServiceUtility service = new ServiceUtility("http://localhost:5156/api/Urunlers");
        public async Task<IActionResult> Index()
        {
            var urunler = await service.TumUrunlerAsync();
            return View(urunler);
        }

        public async Task<IActionResult> UrunEkle()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> UrunEkle(Urun urun)
        {
            await service.UrunEkleAsync(urun);
            return RedirectToAction("Index");
        }
    }
}