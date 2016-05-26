using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bank
{
    using Interfaces;

    public class LoanAccount : Account, IDeposit
    {
        public LoanAccount(Customer customer, decimal balance, double interestRate)
            : base(customer, balance, interestRate)
        {
        }

        public override decimal CalculateInterest(int months)
        {
            if (this.Customer is IndividualCustomer)
            {
                if (months > 3)
                {
                    return base.CalculateInterest(months - 3);
                }
            }
            else if (this.Customer is CompanyCustomer)
            {
                if (months > 2)
                {
                    return base.CalculateInterest(months - 2);
                }
            }
            return 0;
        }

        public void Deposit(decimal amount)
        {
            this.Balance = +amount;
        }
    }
}
