using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestCalculator
{
    class TestInterestCalculator
    {
        static void Main()
        {
            CalculateInterest d1 = new CalculateInterest(InterestCalculator.GetSimpleInterest);
            InterestCalculator simpleInterest = new InterestCalculator(2500m, 0.072m, 15, d1);
            Console.WriteLine(simpleInterest);

            CalculateInterest d2 = new CalculateInterest(InterestCalculator.GetCompoundInterest);
            InterestCalculator compoundInterest = new InterestCalculator(500m, 0.056m, 10, d2);
            Console.WriteLine(compoundInterest);
        }
    }
}
