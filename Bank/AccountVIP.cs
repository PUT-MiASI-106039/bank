using Bank.Interfaces;

namespace Bank
{
    public class AccountVip : Account, IAccount
    {
        public AccountVip(IPerson owner)
            : base(owner)
        {
                
        }

        public override string Accept(IAccountVisitor<string> visitor)
        {
            return visitor.Visit(this);
        }
    }
}
