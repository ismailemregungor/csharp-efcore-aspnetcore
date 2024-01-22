using ASP.NETCOREMVCIntro.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NETCOREMVCIntro.Controllers
{
	public class VeriAlController : Controller
	{
		public IActionResult Index()
		{
			//1- QueryString (GET) (*)
			//2- Request.Form (POST)
			//3- IFormCollection (POST)
			//4- Parametre (POST)(**)
			//5- Model (POST) (***)
			//5.1- HTML Helper ile Model
			//5.2- Tag Helper ile Model


			return View();
		}

		public IActionResult QueryStringYakala()
		{
			return Content(Request.QueryString.Value);
		}

		public IActionResult ReqFormYakala()
		{
			//Tum form elemanlarını isimleri dogru yazılmalıdır...
			Urun urun = new Urun();
			urun.UrunID = int.Parse(Request.Form["id"]);
			urun.UrunAdi = Request.Form["ad"];
			urun.Fiyat = double.Parse(Request.Form["fiyat"]);

			return Content(urun.UrunID.ToString() + " " + urun.UrunAdi + " " + urun.Fiyat);
		}

		public IActionResult IFormCollecsionYakala(IFormCollection frm)
		{
			Urun urun = new Urun();
			urun.UrunID = int.Parse(frm["id"]);
			urun.UrunAdi = frm["ad"];
			urun.Fiyat = double.Parse(frm["fiyat"]);
			return Content(urun.UrunID.ToString() + " " + urun.UrunAdi + " " + urun.Fiyat);
		}

		public IActionResult ParametreYakala(int id, string ad, double fiyat)
		{
			/*
			 * Parametre olarak gelen değerler ile formda
			 * tanımlı olan değerler aynı olmalı.
			 * Esnek değil, çok fazla parametre olduğu durumlarda
			 * clean koda uymamış oluruz.
			 */
			return Content(id + " " + ad + " " + fiyat);
		}

		public IActionResult ModelKullanimi(Urun urun)
		{
			/*
			 * Normalde ModelBinder Urün sınıfının içerisindeki Property isimleri
			 * ile aynı olan name değerlerini otomatik olarak eşleştirir ve
			 * gerekli tip dönüşümünü yapar.
			 */
			return Content(urun.UrunID + " " + urun.UrunAdi + " " + urun.Fiyat);
		}
	}
}
