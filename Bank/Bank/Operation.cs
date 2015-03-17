using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public static class Operation
    {
        public static void Transfer(Account source, Account destiny, double amount)
        {
            if(amount > 0){

                source.State -= amount;
                destiny.State += amount;
            }
        }
    }
}
