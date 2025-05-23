using System.Collections.ObjectModel;
using System.Threading.Tasks;
using exchangeApp.Models;
using exchangeApp.Services;

namespace exchangeApp.ViewModels;

public class MainPageViewModel
{
    public ObservableCollection<CurrencyRate> Rates { get; set; } = new();

    public async Task LoadRates()
    {
        var service = new CurrencyService();
        var rates = await service.GetRatesAsync();

        Rates.Clear();
        foreach (var rate in rates)
        {
            Rates.Add(rate);
        }
    }
}