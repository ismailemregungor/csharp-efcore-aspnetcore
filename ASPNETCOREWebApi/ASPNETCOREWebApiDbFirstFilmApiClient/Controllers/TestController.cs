using ASPNETCOREWebApiDbFirstFilmApiClient.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ASPNETCOREWebApiDbFirstFilmApiClient.Controllers
{
    public class TestController : Controller
    {
        static string jwt = null;

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(Login login)
        {
            HttpClient httpClient = new HttpClient();
            var response = await httpClient.PostAsJsonAsync("http://localhost:5225/api/Login", login);

            jwt = "Bearer " + await response.Content.ReadAsStringAsync();
            return Content("Token: " + jwt);
        }

        [HttpGet]
        public async Task<IActionResult> GetFilms()
        {
            HttpClient httpClient = new HttpClient();

            // Önemli
            httpClient.DefaultRequestHeaders.Clear();
            httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
            httpClient.DefaultRequestHeaders.Add("Authorization", jwt);

            string strJSON =  await httpClient.GetStringAsync("http://localhost:5225/api/Filmlers");

            var filmler = JsonConvert.DeserializeObject<List<Film>>(strJSON);

            return View(filmler);
        }
    }
}
