using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public Account()
        {
            this.State = 0.0;
        }

        public void Income(double amount)
        {
            //TODO: implemetacja

            State += amount;
        }

        public void Excome(double amount)
        {
            //TODO: implementacjas

            State -= amount;
        }

        private Person _owner;
        public Person Owner
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
