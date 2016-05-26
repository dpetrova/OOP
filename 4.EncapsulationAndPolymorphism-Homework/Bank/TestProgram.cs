using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    using Interfaces;

    class TestProgram
    {
        public static void Main()
        {
            Customer misho = new IndividualCustomer("Misho Mishev", 7409128991);
            Customer actavis = new CompanyCustomer("Actavis", "BG9863535399");

            var accounts = new List<Account>()
            {
                new DepositAccount(misho, 2999.99m, 3.5),
                new LoanAccount(misho, 2999.99m, 4.0),
                new MortgageAccount(misho, 2999.99m, 1.5),
                new DepositAccount(actavis, 3000000.50m, 4.5),
                new LoanAccount(actavis, 3000000.50m, 5.0),
                new MortgageAccount(actavis, 3000000.50m, 2.5)
            };
            
            foreach (var account in accounts)
            {
                Console.WriteLine("--Customer:{0}--\nBalance: {1}\n {2} -> 3 months interest: {3}; 24 months interest: {4}",
                    account.Customer.Name, account.Balance, account.GetType().Name, account.CalculateInterest(3), account.CalculateInterest(24));
            }
        }
    }
}
