using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompanyHierarchy.Interfaces
{
    public interface IEmployee : IPerson
    {
        decimal Salary
        {
            get;
            set;
        }

        Department Department
        {
            get;
            set;
        }
    }
}
