using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Account
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
    }
}
