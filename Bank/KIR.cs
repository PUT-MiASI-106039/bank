using System;
using System.Collections.Generic;
using Bank.Interfaces;

namespace Bank
{
    public class KIR : IMediator
    {
        public List<Bank> bankList;

        private Dictionary<String, Bank> bankDictionary = new Dictionary<String, Bank>();


        public KIR()
        {
            bankList = new List<Bank>();
        }

        #region Mediator Pattern

        public void AddBank(Bank k)
        {
            k.RegisterMediator(this);
            bankDictionary.Add(k.getId(), k);
        }

        public void SendMoney(String id, int amount)
        {
            bankDictionary[id].ReciveMoeny(amount);
        }

        #endregion

    }
}
