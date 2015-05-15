using System;
using Bank.History.Abstract;

namespace Bank.History.Options
{
    public class OnlyRecognition : HistoryOptionAbstract
    {
        public override void GetHistory()
        {
            Console.WriteLine("Tylko uznania");
        }
    }
}
