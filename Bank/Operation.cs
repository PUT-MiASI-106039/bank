using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Operation
    {
        public static void Transfer(Account source, Account destiny, int amount)
        {
            if (amount > 0)
            {
                source.State -= amount;
                destiny.State += amount;
            }
        }

        private Account _source;
        public Account Source
        {
            get
            {
                return _source;
            }

            private set
            {
                if (value != _source)
                {
                    _source = value;
                }
            }
        }

        private Account _destiny;
        public Account Destiny
        {
            get
            {
                return _destiny;
            }

            private set
            {
                if (value != _destiny)
                {
                    _destiny = value;
                }
            }
        }

        private DateTime _dateTime;
        public DateTime DateTime
        {
            get
            {
                return _dateTime;
            }

            private set
            {
                if (value != _dateTime)
                {
                    _dateTime = value;
                }
            }
        }

        public Operation(Account source, Account destiny)
        {
            this.DateTime = DateTime.Now;
            this.Source = source;
            this.Destiny = destiny;
        }

    }
}
