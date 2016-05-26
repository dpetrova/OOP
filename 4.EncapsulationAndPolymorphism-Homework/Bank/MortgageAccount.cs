using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bank
{
    using Interfaces;

    public class MortgageAccount : Account, IDeposit
    {
        public MortgageAccount(Customer customer, decimal balance, double interestRate)
            : base(customer, balance, interestRate)
        {
        }

        public override decimal CalculateInterest(int months)
        {
            if (this.Customer is IndividualCustomer)
            {
                if (months > 6)
                {
                    return base.CalculateInterest(months - 6);
                }
                return 0;
            }
            else if (this.Customer is CompanyCustomer)
            {
                if (months <= 12)
                {
                    return base.CalculateInterest(months) / 2;
                }
                else
                {
                    return base.CalculateInterest(12)/2 + base.CalculateInterest(months - 12);
                }
            }
            return base.CalculateInterest(months);
        }

        public void Deposit(decimal amount)
        {
            this.Balance += amount;
        }
    }
}
