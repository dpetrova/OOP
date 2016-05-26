using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterestCalculator
{
    public delegate decimal CalculateInterest(decimal sum, decimal interest, int years);

    public class InterestCalculator
    {
        private decimal money;
        private decimal interest;
        private CalculateInterest deleg;
        private int years;

        public InterestCalculator(decimal money, decimal interest, int years, CalculateInterest deleg)
        {
            this.years = years;
            this.deleg = deleg;
            this.interest = interest;
            this.money = money;
        }

        public override string ToString()
        {
            return string.Format("{0:F4}", this.deleg(this.money, this.interest, this.years));
        }

        public static decimal GetSimpleInterest(decimal sum, decimal interest, int years)
        {
            return sum * (1 + interest * years);
        }

        public static decimal GetCompoundInterest(decimal sum, decimal interest, int years)
        {
            return sum * (decimal)Math.Pow((double)(1 + interest / 12), years * 12);
        }
    }
}
