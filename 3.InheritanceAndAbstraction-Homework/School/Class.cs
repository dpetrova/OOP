using System;
using System.Collections.Generic;
using System.Linq;


namespace School
{
    public class Class : IDetails
    {
        private string uniqueTextIdentifier;
        private List<Teacher> teachers;
        private string details;

        public string UniqueTextIdentifier
        {
            get { return this.uniqueTextIdentifier; }
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The text identifier cannot be empty.");
                }
                this.uniqueTextIdentifier = value;
            }
        }

        public List<Teacher> Teachers
        {
            get { return this.teachers; }
            set { this.teachers = value; }
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

        public Class(string textIdentifier, List<Teacher> teachers, string details = null)
        {
            this.UniqueTextIdentifier = textIdentifier;
            this.Teachers = teachers;
            this.Details = details;
        }

        public void AddTeacher(Teacher teacher)
        {
            this.Teachers.Add(teacher);
        }

        public override string ToString()
        {
            string classInfo = string.Format("Unique text identifier: {0} \nDetails: {1}\n", this.UniqueTextIdentifier, this.Details);
            classInfo += string.Join(", ", this.Teachers.Select(x => x.ToString()).ToArray());
            return classInfo;
        }
    }
}
