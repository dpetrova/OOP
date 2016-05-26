using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bank.Interfaces
{
    public interface IAccount
    {
        decimal CalculateInterest(int months);
    }
}
