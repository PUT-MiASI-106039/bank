using System;
using System.Collections.Generic;
using Bank.History.Abstract;

namespace Bank.History.Basic
{
    public class HistoryBasic : HistoryAbstract
    {
        private List<Operation> _history = new List<Operation>();

        public void AddOperation(Operation o)
        {
            _history.Add(o);
        }

        public override void GetHistory()
        {
            Console.WriteLine("Wyświetlana jest pełna historia");
        }
    }
}
