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
    public class CreditCardsTests
    {
        [TestMethod()]
        public void ExcomeTest()
        {
            Account account = new Account();
            account.State = 500.0;

            CreditCards creditCard = new CreditCards(account);

            creditCard.Limit = 41.00;
            creditCard.Excome(21.00);

            Assert.AreEqual(479.00, account.State);
        }
    }
}
