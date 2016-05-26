using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompanyHierarchy.Interfaces
{
    public interface IManager : IEmployee
    {
        List<Employee> Employees
        {
            get;
            set;
        }
    }
}
