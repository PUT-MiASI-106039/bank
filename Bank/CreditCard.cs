using Bank.Interfaces;

namespace Bank
{
    public class CreditCard
    {
        private IAccount _account;

        private int _limit;
        public int Limit
        {
            get
            {
                return _limit;
            }

            set
            {
                if (_limit != value)
                {
                    _limit = value;
                }
            }
        }

        public CreditCard(IAccount account)
        {
            _account = account;
            Limit = 0;
        }

        public void Excome(int amount)
        {
            if (amount <= Limit)
            {
                _account.Excome(amount);
            }
        }

    }
}
