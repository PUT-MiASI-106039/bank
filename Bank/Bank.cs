using System;
using System.Collections.Generic;
using System.Linq;
using Bank.Interfaces;

namespace Bank
{
    public class Bank
    {
        private IMediator _mediator;
        private String _id;

        public Bank(ICurrencyConverter converter)
        {
        }

        public List<Account> Accounts { get; set; }

        public Bank(String id) { 
            
            _id = id; 
        }

        public List<IPerson> GetClients()
        {
            if (Accounts != null)
            {
                return Accounts.Select(a => a.Owner).Distinct().ToList();
            }

            return new List<IPerson>();
        }

        #region Mediator pattern

        public void RegisterMediator(IMediator mediator) { _mediator = mediator; }
        public String GetId() { return _id; }

        public void SendMoney(String id, int amount)
        {
            Console.WriteLine("Przesyłanie pieniędzy od {0} do {1}: {2}", _id, id, amount);
            _mediator.SendMoney(id, amount); // Rzeczywista komunikacja odbywa się za pośrednictwem mediatora!!!
        }

        public void ReciveMoeny(int amount)
        {
            Console.WriteLine("Pieniądze odebranane przez " + _id + ": " + amount);
        }

        #endregion
    }
}
