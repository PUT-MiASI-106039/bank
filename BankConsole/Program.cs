using Bank;
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
            List<Account> accounts = new List<Account>()
            {
                new AccountVIP() { State = 15 },
                new AccountRegular() { State = 15 }
            };

            var visitor = new AccountInfoGeneratorVisitor();

            Console.WriteLine(visitor.GetInfos(accounts));

            Console.ReadKey();
        }
    }
}
