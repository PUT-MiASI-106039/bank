namespace Bank
{
    public interface ICurrencyConverter
    {
        int Convert(Currency from, Currency to, int amount);
    }
}
