using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace ASPNETCOREWebApiIntro.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class BaslangicController : ControllerBase
	{
		[HttpGet("Test")]
		public string Test1()
		{
			return "Web API Test";
		}

		[HttpGet("Deneme")]
		public string Deneme()
		{
			return "Web API Deneme";
		}

		[HttpPost("VeriAl")]
		public void VeriAl(string mesaj)
		{
			
		}

		[HttpGet("TumSehirler")]
		public List<string> TumSehirler()
		{
			return new List<string>() { "İstanbul", "Ankara", "Kocaeli", "Afyon" };
		}

		[HttpGet("Test2")]
		public HttpResponseMessage Test2()
		{
			return new HttpResponseMessage(HttpStatusCode.OK);
		}

		[HttpGet("Test3")]
		public IActionResult Test3()
		{
			return Unauthorized();
		}

		[HttpGet("Test4")]
		public IActionResult Test4()
		{
			return BadRequest();
		}
	}
}
