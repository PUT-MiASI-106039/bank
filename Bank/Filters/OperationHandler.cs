using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public abstract class OperationHandler
    {
        protected OperationHandler _successor;

        public void SetSuccessor(OperationHandler successor)
        {
            this._successor = successor;
        }

        public abstract void HandleRequest(object request);
    }
}
