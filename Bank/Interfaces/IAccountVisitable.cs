namespace Bank.Interfaces
{
    public interface IAccountVisitable<T>
    {
        T Accept(IAccountVisitor<T> visitor);
    }
}
