using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Bank
    {
        public List<Account> Accounts { get; set; }

        public List<Person> Clients 
        { 
            get
            {
                return Accounts.Select(a => a.Owner).Distinct().ToList();
            }

            private set
            {
            }
        }
    }
}
