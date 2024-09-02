using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using models.services;

namespace services
{
    public interface IConversionRate
    {
        Task<decimal?> GetExchangeRateAsync(string baseCurrency, string targetCurrency);
    }

    public class ConversionRate : IConversionRate
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiKey;

        public ConversionRate(HttpClient httpClient, string apiKey)
        {
            _httpClient = httpClient;
            _apiKey = apiKey;
        }

        public async Task<decimal?> GetExchangeRateAsync(string baseCurrency, string targetCurrency)
        {
            var url = $"https://v6.exchangerate-api.com/v6/feb628771760a04e158f0340/latest/USD";
            var response = await _httpClient.GetAsync(url);

            if (!response.IsSuccessStatusCode)
                return null;

            var jsonResponse = await response.Content.ReadAsStringAsync();
            var exchangeRateResponse = JsonSerializer.Deserialize<ExchangeRateResponseModel>(jsonResponse);

            if (exchangeRateResponse?.Rates != null && exchangeRateResponse.Rates.TryGetValue(targetCurrency, out var rate))
            {
                return rate;
            }

            return null;
        }
    }
}
