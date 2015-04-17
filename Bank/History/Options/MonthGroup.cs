using Bank.History.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
