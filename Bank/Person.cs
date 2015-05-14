
using System;
using System.Collections.Generic;

namespace Bank
{
    public class Person : IPerson
    {
        public readonly Guid Id = new Guid();

        public string Name { get; set; }

        public List<Account> Accounts { get; set; }

        public Person()
        {
            Accounts = new List<Account>();
        }

    }
}
