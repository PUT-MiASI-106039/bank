using System;
using Bank.History.Abstract;

namespace Bank.History.Options
{
    public class GroupViaAccount : HistoryOptionAbstract
    {
        public override void GetHistory()
        {
            Console.WriteLine("Grupowanie po kontach");
        }
    }
}
