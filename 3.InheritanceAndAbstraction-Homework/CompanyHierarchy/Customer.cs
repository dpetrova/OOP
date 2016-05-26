using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompanyHierarchy
{
    public class Customer : Person
    {
        private decimal purchaseAmount;

        public Customer(int id, string fname, string lname, decimal purchaseAmount)
            : base(id, fname, lname)
        {
            this.PurchaseAmount = purchaseAmount;
        }
    
        public decimal PurchaseAmount
        {
            get
            {
                return this.purchaseAmount;
            }
            set
            {
                this.purchaseAmount = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + " Purchase amount: " + this.PurchaseAmount;
        }
    }
}
