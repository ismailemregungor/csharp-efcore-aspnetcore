using ASP.NETCOREMVCIntro.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ASP.NETCOREMVCIntro.Controllers
{
	public class VeriGonderController : Controller
	{
		/*
		 *	1-ViewData:  ViewData kullanırken tip dönüşümü yapmak gerekir.
			2-ViewBag *: ViewBag dynamic olarak çalıştığından tip dönüşümüne çoğu zaman gerek yok.
			3-TempData : Farklı controller veya aksiyonlar arası geçiçi olarak veri transferi için kullanılır.
						 İlk kullanımdan sonra silinir. Silinmesini istemiyorsak; Keep() metodu kullanılır.
			4-Model ***: 
			5-ViewModel **:
		 */
		public IActionResult Index()
		{
			ViewData["Mesaj"] = "Merhaba ViewData";
			ViewBag.Message = "Merhaba ViewBag";

			Urun urun = new Urun()
			{
				UrunID = 1,
				UrunAdi = "Defter",
				Fiyat = 45
			};

			ViewData["urun1"] = urun;
			ViewBag.Product1 = urun;

			//Veriler koleksiyon olursa?

			List<Urun> list = new List<Urun>() 
			{
				new Urun() {UrunID = 1, UrunAdi = "Defter", Fiyat = 45},
                new Urun() {UrunID = 2, UrunAdi = "Kalem", Fiyat = 55},
                new Urun() {UrunID = 3, UrunAdi = "Silgi", Fiyat = 13},
            };

			ViewData["liste1"] = list;
			ViewBag.List1 = list;

			ViewData["test"] = list;
			return View();
		}

		public IActionResult Temp_Data()
		{
            TempData["testValue"] = "test123";
			TempData.Keep("testValue");
            return View();
		}

        public IActionResult Test()
        {
			string data = TempData["testValue"].ToString();
			return Content("Test" + data);
        }

        public IActionResult ModelKullan()
        {
			// Model tekbir nesne ise:
			//Urun urun = new Urun()
			//{
			//    UrunID = 1,
			//    UrunAdi = "Defter",
			//    Fiyat = 45
			//};

			//Model bir koleksiyon ise:

			List<Urun> list = new List<Urun>()
			{
				new Urun() {UrunID = 1, UrunAdi = "Defter", Fiyat = 45},
				new Urun() {UrunID = 2, UrunAdi = "Kalem", Fiyat = 55},
				new Urun() {UrunID = 3, UrunAdi = "Silgi", Fiyat = 13},
			};

			return View(list);
        }

		//public IActionResult ViewModelKullan()
		//{
		//	//View model kullanmadan önce

		//	KitapEkleVM kitapEkleVM = new KitapEkleVM();
		//	kitapEkleVM.Kategoriler = new SelectList(KitapDB.Kategoriler, "KategoriID", "KategoriAdi");
		//	kitapEkleVM.Yazarlar = new SelectList(KitapDB.Yazarlar, "YazarID", "YazarAdi");
		//	return View(kitapEkleVM);
		//}
	}
}
