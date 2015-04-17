﻿using Bank.History.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
