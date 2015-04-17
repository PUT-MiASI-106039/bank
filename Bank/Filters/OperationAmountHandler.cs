﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class OperationAmountHandler : OperationHandler
    {
        private readonly int maxAmount = 20000;// 20 000

        public override void HandleRequest(object request)
        {
            var amount = (int)request;

            if (amount >  20 * 1000)
            {
                Console.WriteLine("OperationAmountHandler amount is more than {0}", maxAmount);
            }

            _successor.HandleRequest(request);
        }
    }
}
