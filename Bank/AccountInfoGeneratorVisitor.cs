using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class AccountInfoGeneratorVisitor : IAccountVisitor<string>
    {
        public string GetInfos(IEnumerable<Account> accounts)
        {
            string result = string.Empty;

            foreach (var account in accounts)
            {
                result += account.Accept(this);
            }

            return result;
        }


        public string Visit(AccountRegular account)
        {
            return string.Format("Type: Regular" + Environment.NewLine +
                                 "State: {0}" + Environment.NewLine, account.State);
        }

        public string Visit(AccountVIP account)
        {
            return string.Format("Type: VIP" + Environment.NewLine +
                                 "State: {0}" + Environment.NewLine, account.State);
        }
    }
}
