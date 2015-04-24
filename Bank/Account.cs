using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public abstract class Account : IAccountVisitable<string>
    {
        private int _state;
        public int State
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
            this.Owner = owner;
            this.State = 0;
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
