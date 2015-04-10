using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class CreditCards
    {
        private Account _account;

        private double _limit;
        public double Limit
        {
            get
            {
                return this._limit;
            }

            set
            {
                if (_limit != value)
                {
                    this._limit = value;
                }
            }
        }

        public CreditCards(Account account)
        {
            this._account = account;
            this.Limit = 0.0;
        }

        public void Excome(double amount)
        {
            if (amount <= Limit)
            {
                this._account.Excome(amount);
            }
        }

    }
}
