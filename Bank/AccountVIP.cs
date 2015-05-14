using Bank.Interfaces;

namespace Bank
{
    public class AccountVIP : Account, IAccount
    {
        public AccountVIP(IPerson owner)
            : base(owner)
        {
                
        }

        public override string Accept(IAccountVisitor<string> visitor)
        {
            return visitor.Visit(this);
        }
    }
}
