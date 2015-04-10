using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Bank.Tests
{
    [TestClass()]
    public class CurrencyConverterTests
    {
        [TestMethod()]
        public void ConvertTest()
        {
            CurrencyConverter.Prices[Currency.PLN] = 1;
            CurrencyConverter.Prices[Currency.USD] = 3.89;

            for (double i = -100; i < 100; i += 0.001)
            {
                double actual = CurrencyConverter.Convert(Currency.PLN, Currency.USD, i);
                double expected = i / 3.89;

                Assert.AreEqual(expected, actual);
            }
        }
    }
}
