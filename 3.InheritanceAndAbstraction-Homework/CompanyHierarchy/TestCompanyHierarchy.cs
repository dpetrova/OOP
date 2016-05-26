using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy
{
    class TestCompanyHierarchy
    {
        static void Main()
        {
            var projects = new List<Project>
            {
                new Project("PR-1289", new DateTime(2015, 2, 23), "customers' study ", ProjectState.Open),
                new Project("PR-0132", new DateTime(2014, 3, 15), "iprove annual sales", ProjectState.Closed),
                new Project("PR-9809", new DateTime(2015, 10, 20), "new product development")
            };

            var sales = new List<Sale>
            {
                new Sale("SL-9280", new DateTime(2015, 6, 1), 300.5m),
                new Sale("SL-7777", new DateTime(2015, 3, 20), 590.8m),
                new Sale("SL-5342", new DateTime(2105, 4, 14), 999.99m)
            };

            var team = new List<Employee>
            {
                new SalesEmployee(823738, "Mincho", "Praznikov", Department.Sales, 2999.99m, sales),
                new Developer(273890, "Isak", "Nuton", 8000.00m, Department.Production, projects)
            };
            
            var employees = new List<Employee>
            {
                new Manager(182939, "Bate", "Goiko", 5900.00m, Department.Marketing, team),
                new SalesEmployee(777777, "Penka", "Papazova", Department.Sales, 1500.80m, sales),
                new Developer(273890, "Albert", "Einstein", 10000.00m, Department.Marketing, projects)
            };

            employees.ForEach(x => Console.WriteLine(x));
        }
    }
}
