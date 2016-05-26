using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompanyHierarchy
{
    public class SalesEmployee : Employee
    {
        private List<Sale> sales;

        public SalesEmployee(int id, string fname, string lname, Department department, decimal salary, List<Sale> sales)
            : base(id, fname, lname, salary, department)
        {
            this.Sales = sales;
        }
    
        public List<Sale> Sales
        {
            get
            {
                return this.sales;
            }
            set
            {
                this.sales = value;
            }
        }

        public override string ToString()
        {
            string salesEmployeeInfo = base.ToString();
            salesEmployeeInfo += "\nSales: ";
            salesEmployeeInfo += string.Join("; ", this.Sales.Select(x => x.ToString()));
            return salesEmployeeInfo;
        }
    }
}
