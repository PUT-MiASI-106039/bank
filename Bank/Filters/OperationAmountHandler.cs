using System;

namespace Bank.Filters
{
    public class OperationAmountHandler : OperationHandler
    {
        private readonly int _maxAmount = 20000;// 20 000

        public override void HandleRequest(object request)
        {
            var amount = (int)request;

            if (amount >  20 * 1000)
            {
                Console.WriteLine("OperationAmountHandler amount is more than {0}", _maxAmount);
            }

            Successor.HandleRequest(request);
        }
    }
}
