using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public static class CurrencyConverter
    {
        //public static Currency MainCurrency = Currency.PLN;

        public static Dictionary<Currency, double> Prices = new Dictionary<Currency, double>();

        //public static Dictionary<Currency, double> SellPrices = new Dictionary<Currency, double>();

        public static double Convert(Currency from, Currency to, double amount)
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
