using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class KIR
    {
        public List<Bank> bankList;

        public KIR()
        {
            bankList = new List<Bank>();
        }

        public void ReceiveTransfers(IEnumerable<Operation> operations)
        {
            //TODO:
        }

        public void SendTransfers(IEnumerable<Operation> operations)
        {
            //TOOD:
        }
    }
}
