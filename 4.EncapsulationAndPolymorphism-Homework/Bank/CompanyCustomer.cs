using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bank
{
    public class CompanyCustomer : Customer
    {
        private string bulstad;

        public CompanyCustomer(string name, string bulstad): base(name)
        {
            this.Bulstad = bulstad;
        }
    
        public string Bulstad
        {
            get { return this.bulstad; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Bulstad cannot be empty");
                }
                this.bulstad = value;
            }
        }
    }
}
