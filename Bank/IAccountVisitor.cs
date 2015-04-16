using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public interface IAccountVisitor<T>
    {
        T Visit(AccountRegular account);
        T Visit(AccountVIP account);
    }
}
