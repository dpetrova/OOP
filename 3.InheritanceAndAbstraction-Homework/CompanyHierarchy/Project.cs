using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy
{
    public class Project
    {
        private string name;
        private DateTime startDate;
        private string details;
        private ProjectState state;

        public Project(string name, DateTime startDate, ProjectState state)
            : this(name, startDate, null, state)
        {
        }

        public Project(string name, DateTime startDate, string details, ProjectState state = ProjectState.Open)
        {
            this.Name = name;
            this.StartDate = startDate;
            this.Details = details;
            this.State = state;
        }
        

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Project name cannot be null or empty.");
                }
                this.name = value;
            }
        }

        public DateTime StartDate
        {
            get
            {
                return this.startDate;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Start date cannot be empty.");
                }
                this.startDate = value;
            }
        }

        public string Details
        {
            get
            {
                return this.details;
            }
            set
            {
                this.details = value;
            }
        }

        public ProjectState State
        {
            get
            {
                return this.state;
            }
            set
            {
                if (value.GetType() != typeof(ProjectState))
                {
                    throw new FormatException("Invalid format project state.");
                }
                this.state = value;
            }
        }


        public ProjectState CloseProject()
        {
            return this.State = ProjectState.Closed;
        }

        public override string ToString()
        {
            string projectInfo = string.Format(", Project name: {0}/ Start date: {1}/ Details: {2}/ State: {3}\n",
                                                            this.Name, this.StartDate, this.Details, this.State);
            return projectInfo;
        }

    }
}
