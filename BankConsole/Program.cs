using Bank;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            IKernel kernel = new StandardKernel();
            kernel.Bind<ICurrencyConverter>().To<CurrencyConverter>();
            kernel.Bind<IPerson>().To<Person>();
            kernel.Bind<IAccount>().To<AccountVIP>();

            var bank = new Bank.Bank(kernel.Get<ICurrencyConverter>());
            var card = new CreditCard(kernel.Get<IAccount>());

            //Visitor
            List<Account> accounts = new List<Account>()
            {
                new AccountVIP() { State = 15 },
                new AccountRegular() { State = 16 }
            };

            var visitor = new AccountInfoGeneratorVisitor();

            Console.WriteLine(visitor.GetInfos(accounts));



            //Chain of responsibility
            OperationHandler handler1 = new OperationAmountHandler();
            OperationHandler handler2 = new OperationGreaterThanZeroHandler();

            handler1.SetSuccessor(handler2);

            int[] amounts = new int[] { -5, 10, 20, 20001 };

            foreach (var amount in amounts)
            {
                handler1.HandleRequest(amount);
            }

            Console.ReadKey();
        }
    }
}
