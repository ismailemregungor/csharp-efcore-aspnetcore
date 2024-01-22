using ASPNETCOREWebApiDbFirstUrunApiClient2.Models;

namespace ASPNETCOREWebApiDbFirstUrunApiClient2.Utility
{
    public class ServiceUtility
    {
        HttpClient _client = new HttpClient();

        private string _baseURL;

        public ServiceUtility(string baseURL)
        {
            _baseURL = baseURL;
        }
        public async Task<List<Urun>> TumUrunlerAsync(string? url = "")
        {
            return await _client.GetFromJsonAsync<List<Urun>>(_baseURL + url);
        }

        public async Task UrunEkleAsync(Urun urun, string? url = "")
        {
            await _client.PostAsJsonAsync<Urun>(_baseURL + url, urun);
        }
    }
}
