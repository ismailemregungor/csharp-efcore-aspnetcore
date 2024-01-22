
using ASPNETCOREWebApiDbFirstUrunApiClient;
using System.Net.Http.Json;

Console.WriteLine("UrunAPI Client!");

HttpClient client = new HttpClient();

string jsonData = client.GetStringAsync("http://localhost:5156/api/Urunlers").Result;

Console.WriteLine(jsonData);

var data = client.GetFromJsonAsync<List<Urun>>("http://localhost:5156/api/Urunlers").Result;

foreach (var item in data)
{
	Console.WriteLine(item);
}
