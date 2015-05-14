using System;
using System.Collections.Generic;
using System.Linq;
using Bank.Interfaces;

namespace Bank
{
    public class Bank
    {
        private IMediator _mediator;
        private String id;
        private ICurrencyConverter _converter;

        public Bank(ICurrencyConverter converter)
        {
            _converter = converter;
        }

        public List<Account> Accounts { get; set; }

        public Bank(String id) { 
            
            this.id = id; 
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
        public String getId() { return id; }

        public void SendMoney(String id, int amount)
        {
            Console.WriteLine("Przesyłanie pieniędzy od " + this.id + " do " + id + ": " + amount);
            _mediator.SendMoney(id, amount); // Rzeczywista komunikacja odbywa się za pośrednictwem mediatora!!!
        }

        public void ReciveMoeny(int amount)
        {
            Console.WriteLine("Pieniądze odebranane przez " + id + ": " + amount);
        }

        #endregion
    }
}
