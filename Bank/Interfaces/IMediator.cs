using System;

namespace Bank.Interfaces
{
    public interface IMediator
    {
        void SendMoney(String id, int amount);
    }
}
