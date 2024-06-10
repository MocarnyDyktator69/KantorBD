using System.Net.Http;
using System.Threading.Tasks;

namespace KantorBD
{
    public class ExchangeRateService
    {
        private static readonly HttpClient client = new HttpClient();
        private string apiUrl = "https://v6.exchangerate-api.com/v6/b9f4c7090a7d9ee239826cc5/latest/";

        public async Task<string> GetExchangeRatesAsync(string fromCurrency)
        {
            HttpResponseMessage response = await client.GetAsync(apiUrl + fromCurrency);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
    }
}
