using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public interface IAccount
    {
        public void Income(int amount);

        public void Excome(int amount);
    }
}
