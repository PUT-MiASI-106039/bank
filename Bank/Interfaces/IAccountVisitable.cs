using Bank.Interfaces;

namespace Bank
{
    public interface IAccountVisitable<T>
    {
        T Accept(IAccountVisitor<T> visitor);
    }
}
