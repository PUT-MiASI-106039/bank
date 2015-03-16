using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public static class CurrencyConverter
    {
        public static Dictionary<Currency, double> BuyPrices = new Dictionary<Currency,double>();

        public static Dictionary<Currency, double> SellPrices = new Dictionary<Currency, double>();

        public static float Convert(Currency from, Currency to, double amount) 
        {
            return 0;
        }

    }
}
