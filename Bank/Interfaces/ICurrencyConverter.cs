﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public interface ICurrencyConverter
    {
        public int Convert(Currency from, Currency to, int amount);
    }
}
