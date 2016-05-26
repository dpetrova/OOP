using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompanyHierarchy
{
    public class Developer : Employee
    {
        private List<Project> projects;

        public Developer(int id, string fname, string lname, decimal salary, Department department, List<Project> projects) 
            : base(id, fname, lname, salary, department)
        {
            this.Projects = projects;
        }
    
        public List<Project> Projects
        {
            get
            {
                return this.projects;
            }
            set
            {
                this.projects = value;
            }
        }

        public override string ToString()
        {
            string developerInfo = base.ToString();
            developerInfo += "\nProjects: ";
            developerInfo += string.Join("; ", Projects.Select(x => x.ToString()));
            return developerInfo;
        }
    }
}
