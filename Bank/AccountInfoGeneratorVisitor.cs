using System;
using System.Collections.Generic;
using System.Linq;
using Bank.Interfaces;

namespace Bank
{
    public class AccountInfoGeneratorVisitor : IAccountVisitor<string>
    {
        public string GetInfos(IEnumerable<Account> accounts)
        {
            return accounts.Aggregate(string.Empty, (current, account) => current + account.Accept(this));
        }


        public string Visit(AccountRegular account)
        {
            return string.Format("Type: Regular" + Environment.NewLine +
                                 "State: {0}" + Environment.NewLine, account.State);
        }

        public string Visit(AccountVip account)
        {
            return string.Format("Type: VIP" + Environment.NewLine +
                                 "State: {0}" + Environment.NewLine, account.State);
        }
    }
}
