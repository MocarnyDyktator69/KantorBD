using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace KantorBD
{
    public class ExchangeRateParser
    {
        public Dictionary<string, decimal> ParseExchangeRates(string json, string fromCurrency)
        {
            var rates = new Dictionary<string, decimal>();
            var data = JObject.Parse(json);
            var rateData = data["conversion_rates"];

            if (rateData is JObject)
            {
                var rateDictionary = rateData.ToObject<Dictionary<string, decimal>>();

                foreach (var kvp in rateDictionary)
                {
                    rates[kvp.Key] = kvp.Value;
                }
            }

            return rates;
        }
    }
}
