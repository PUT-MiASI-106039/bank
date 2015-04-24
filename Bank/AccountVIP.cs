﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class AccountVIP : Account, IAccount
    {
        public override string Accept(IAccountVisitor<string> visitor)
        {
            return visitor.Visit(this);
        }
    }
}
