using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class CreditCards
    {
        private double _limit;

        private Account account;

        public double Limit
        {
            get
            {
                return this._limit;
            }

            set
            {
                this._limit = value;
            }
        }

        public CreditCards(Account account)
        {
            this.account = account;
        }

        public void Income(double amount)
        {

            account.State += amount;
        }

        public void Excome(double amount)
        {

            account.State -= amount;
        }

    }
}
