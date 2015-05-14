using Bank.Interfaces;

namespace Bank
{
    public class AccountRegular : Account, IAccount
    {
        public AccountRegular(IPerson owner)
            : base(owner)
        {

        }

        public override string Accept(IAccountVisitor<string> visitor)
        {
            return visitor.Visit(this);
        }
    }
}
