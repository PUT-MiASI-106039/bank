﻿namespace Bank.Interfaces
{
    public interface IAccountVisitor<T>
    {
        T Visit(AccountRegular account);
        T Visit(AccountVIP account);
    }
}
