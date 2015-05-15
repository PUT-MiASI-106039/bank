using System;
using System.Collections.Generic;
using Bank.Interfaces;

namespace Bank
{
    public class Kir : IMediator
    {
        public List<Bank> BankList;

        private Dictionary<String, Bank> _bankDictionary = new Dictionary<String, Bank>();


        public Kir()
        {
            BankList = new List<Bank>();
        }

        #region Mediator Pattern

        public void AddBank(Bank k)
        {
            k.RegisterMediator(this);
            _bankDictionary.Add(k.GetId(), k);
        }

        public void SendMoney(String id, int amount)
        {
            _bankDictionary[id].ReciveMoeny(amount);
        }

        #endregion

    }
}
