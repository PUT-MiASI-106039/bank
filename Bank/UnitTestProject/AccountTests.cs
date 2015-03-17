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
    public class AccountTests
    {
        [TestMethod()]
        public void IncomeTest()
        {
            Account account = new Account();
            account.State = 500;

            account.Income(50);

            Assert.AreEqual(550, account.State);
        }

        [TestMethod()]
        public void ExcomeTest()
        {
            Account account = new Account();
            account.State = 500;

            account.Excome(50);

            Assert.AreEqual(450, account.State);
        }
    }
}
