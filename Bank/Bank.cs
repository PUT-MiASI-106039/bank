using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Bank
    {
        private ICurrencyConverter _converter;

        public Bank(ICurrencyConverter converter)
        {
            this._converter = converter;
        }

        public List<Account> Accounts { get; set; }

        public List<IPerson> GetClients()
        {
            if (Accounts != null)
            {
                return Accounts.Select(a => a.Owner).Distinct().ToList();
            }

            return new List<IPerson>();
        }
    }
}
