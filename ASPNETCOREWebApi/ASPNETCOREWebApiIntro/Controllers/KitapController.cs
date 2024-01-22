using ASPNETCOREWebApiIntro.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static System.Reflection.Metadata.BlobBuilder;

namespace ASPNETCOREWebApiIntro.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class KitapController : ControllerBase
	{
		static List<Kitap> _kitaplar = new List<Kitap> 
		{
			new Kitap {KitapID = 1, KitapAdi = "Denemeler", Fiyat = 100, Yazar = "Montaigne"},
			new Kitap {KitapID = 2, KitapAdi = "Davincinin Şifresi", Fiyat = 125, Yazar = "Dan Brown"},
			new Kitap {KitapID = 3, KitapAdi = "Empati", Fiyat = 150, Yazar = "Adam Faver"},
			new Kitap {KitapID = 4, KitapAdi = "Suç ve Ceza", Fiyat = 175, Yazar = " Dosteyevski"},
		};

		[HttpGet("GetAllBooks")]
		public IActionResult TumKitaplar()
		{
			return Ok(_kitaplar);
		}

		[HttpGet("GetById")]
		public async Task<IActionResult> KitapBul(int id)
		{
			return id == 0 ? BadRequest("Kitap Bulunamadı") : Ok(_kitaplar.FirstOrDefault(b => b.KitapID == id));
		}

		[HttpPost("CreateBook")]
		public IActionResult KitapEkle(Kitap kitap)
		{
			_kitaplar.Add(kitap);
			return Ok();
		}

		[HttpPut("UpdateBook")]
		public IActionResult KitapGuncelle(Kitap kitap)
		{
			var guncellenecekKitap = _kitaplar.Find(x=>x.KitapID == kitap.KitapID);
			if (guncellenecekKitap == null)
			{
				return BadRequest("Kitap Bulunamadı");
			}
			guncellenecekKitap.KitapAdi = kitap.KitapAdi;
			guncellenecekKitap.Fiyat = kitap.Fiyat;
			guncellenecekKitap.Yazar = kitap.Yazar;
			return Ok();
		}

		[HttpDelete("DeleteBook")]
		public IActionResult KitapSil(int id)
		{
			var silinecekKitap = _kitaplar.Find(x => x.KitapID == id);
			if (silinecekKitap == null)
			{
				return BadRequest("Kitap Bulunamadı");
			}
			_kitaplar.Remove(silinecekKitap);
			return Ok();
		}
	}
}
