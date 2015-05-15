using System;
using Bank.History.Abstract;

namespace Bank.History.Options
{
    public class MonthGroup : HistoryOptionAbstract
    {
        public override void GetHistory()
        {
            Console.WriteLine("Grupowanie po miesiącach");
        }
    }
}
