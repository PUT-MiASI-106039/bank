using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class History
    {
        private List<Operation> _history = new List<Operation>();

        public void AddOperation(Operation o)
        {
            _history.Add(o);
        }

        public IEnumerable<Operation> GetHistory()
        {
            return _history.OrderBy(o => o.DateTime);
        }
    }
}
