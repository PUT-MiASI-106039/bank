namespace Bank.Interfaces
{
    public interface ICurrencyConverter
    {
        int Convert(Currency from, Currency to, int amount);
    }
}
