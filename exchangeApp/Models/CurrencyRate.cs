using System.Text.Json.Serialization;

namespace exchangeApp.Models;

public class CurrencyRate
{
    [JsonPropertyName("cc")]
    public string Cc { get; set; } // Код валюти, наприклад USD, EUR
    [JsonPropertyName("txt")]
    public string Txt { get; set; } // Назва валюти
    [JsonPropertyName("rate")]
    public double Rate { get; set; } // Курс
    [JsonPropertyName("exchangedate")]
    public string ExchangeDate { get; set; } // Дата курсу

}

/*"r030" : 12,
"txt" : "Алжирський динар",
"rate" : 0.31324,
"cc" : "DZD",
"exchangedate" : "20.05.2025"*/