using System;

namespace Bank
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

            if(_successor != null)
                _successor.HandleRequest(request);
        }
    }
}
