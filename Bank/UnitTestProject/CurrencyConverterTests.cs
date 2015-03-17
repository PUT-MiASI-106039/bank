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

            for (int i = 0; i < 100; i++)
            {
                var value = CurrencyConverter.Convert(Currency.PLN, Currency.USD, i);

                Assert.Equals(value, i * 3.89);
            }

            //Assert.Fail();
        }
    }
}
