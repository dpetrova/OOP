using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bank
{
    using Interfaces;

    public class DepositAccount : Account, IDeposit, IWithdraw
    {
        public DepositAccount(Customer customer, decimal balance, double interestRate)
            : base(customer, balance, interestRate)
        {
        }

        public override decimal CalculateInterest(int months)
        {
            if (this.Balance < 1000)
            {
                return 0;
            }
            return base.CalculateInterest(months);
        }

        public void Deposit(decimal amount)
        {
            this.Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            this.Balance -= amount;
        }
    }
}
