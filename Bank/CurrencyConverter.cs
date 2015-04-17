using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public static class CurrencyConverter
    {
        public static readonly Currency MainCurrency = Currency.PLN;

        public static Dictionary<Currency, int> Prices = new Dictionary<Currency, int>();

        public static double Convert(Currency from, Currency to, int amount)
        {
            if (Prices.ContainsKey(from)
              && Prices.ContainsKey(to))
            {
                double fromMianCurrencyValue = Prices[from] * amount;        
                return fromMianCurrencyValue / Prices[to];
            }

            return 0;
        }

    }
}
