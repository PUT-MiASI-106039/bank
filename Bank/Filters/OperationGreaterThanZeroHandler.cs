using System;

namespace Bank.Filters
{
    public class OperationGreaterThanZeroHandler : OperationHandler
    {
        public override void HandleRequest(object request)
        {
            var amount = (int)request;

            if (amount <= 0)
            {
                Console.WriteLine("OperationGreaterThanZeroHandler: Amount is <= 0");
            }

            if(Successor != null)
                Successor.HandleRequest(request);
        }
    }
}
