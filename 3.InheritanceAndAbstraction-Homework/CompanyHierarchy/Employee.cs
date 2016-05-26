using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompanyHierarchy
{
    using Interfaces;

    public abstract class Employee : Person, IEmployee
    {
        private decimal salary;
        private Department department;

        public Employee(int id, string fname, string lname, decimal salary, Department department): base(id, fname, lname)
        {
            this.Salary = salary;
            this.Department = department;
        }

        public decimal Salary
        {
            get
            {
                return this.salary;
            }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentOutOfRangeException("Salary cannot be empty or negative value.");
                }
                this.salary = value;
            }
        }

        public Department Department
        {
            get
            {
                return this.department;
            }
            set
            {
                if (value.GetType() != typeof(Department))
                {
                    throw new FormatException("Invalid format department.");
                }
                this.department = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + "; salary: " + this.Salary + "; department: " + this.Department;                
        }
    }
}
