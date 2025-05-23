using System.Text.Json;
using exchangeApp.Models;

namespace exchangeApp.Services;

public class CurrencyService
{
    private readonly HttpClient _httpClient;

    public CurrencyService()
    {
        _httpClient = new HttpClient();
    }

    public async Task<List<CurrencyRate>> GetRatesAsync()
    {
        var url = "https://bank.gov.ua/NBUStatService/v1/statdirectory/exchange?json";
        var response = await _httpClient.GetStringAsync(url);
        var rates = JsonSerializer.Deserialize<List<CurrencyRate>>(response);
        return rates;
    }

}