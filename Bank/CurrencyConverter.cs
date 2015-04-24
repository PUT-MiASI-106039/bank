using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class CurrencyConverter : ICurrencyConverter
    {
        public static readonly Currency MainCurrency = Currency.PLN;

        public static Dictionary<Currency, int> Prices = new Dictionary<Currency, int>();

        public int Convert(Currency from, Currency to, int amount)
        {
            if (Prices.ContainsKey(from)
              && Prices.ContainsKey(to))
            {
                int fromMianCurrencyValue = Prices[from] * amount;        
                return fromMianCurrencyValue / Prices[to];
            }

            return 0;
        }

    }
}
