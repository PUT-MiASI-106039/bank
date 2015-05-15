using Bank.Interfaces;

namespace Bank
{
    public abstract class Account : IAccountVisitable<string>
    {
        private double _state;
        public double State
        {
            get
            {
                return _state;
            }
            set
            {
                if (value != _state)
                {
                    _state = value;
                }
            }
        }

        public Account(IPerson owner)
        {
            Owner = owner;
            State = 0;
        }

        public void Income(int amount)
        {
            //TODO: implemetacja

            State += amount;
        }

        public void Excome(int amount)
        {
            //TODO: implementacjas

            State -= amount;
        }

        private IPerson _owner;
        public IPerson Owner
        {
            get
            {
                return _owner;
            }

            set
            {
                if(value != _owner)
                {
                    _owner = value;
                }
            }
        }

        public abstract string Accept(IAccountVisitor<string> visitor);
    }
}
