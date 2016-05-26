using System;


namespace Bank
{
    using Interfaces;

    public abstract class Account : IAccount
    {
        private Customer customer;
        private decimal balance;
        private double interestRate;

        protected Account(Customer customer, decimal balance, double interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public Customer Customer
        {
            get { return this.customer; }
            protected set { this.customer = value; }
        }

        public decimal Balance
        {
            get { return this.balance; }
            protected set
            {
                if (value.GetType().Name != "Decimal")
                {
                    throw new FormatException("Invalid format value!");
                }
                this.balance = value;
            }
        }

        public double InterestRate
        {
            get { return this.interestRate; }
            protected set
            {
                if (value.GetType().Name != "Double")
                {
                    throw new ArgumentException("Invalid format value!");
                }
                this.interestRate = value;
            }
        }

        public virtual decimal CalculateInterest(int months)
        {
            decimal interest = this.Balance * (decimal)(1 + this.InterestRate * months);
            return interest;
        }

    }
}
