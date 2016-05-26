using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompanyHierarchy
{
    using Interfaces;

    public class Manager : Employee, IManager
    {
        private List<Employee> employees;

        public Manager(int id, string fname, string lname, decimal salary, Department department, List<Employee> employees)
            : base(id, fname, lname, salary, department)
        {
            this.Employees = employees;
        }

        public List<Employee> Employees
        {
            get
            {
                return this.employees;
            }
            set
            {
                this.employees = value;
            }
        }

        public override string ToString()
        {
            string managerInfo = base.ToString();
            managerInfo += "\nEmployees: ";
            managerInfo += string.Join("; ", this.Employees.Select(x => x.ToString()));
            return managerInfo;
        }
    }
}
