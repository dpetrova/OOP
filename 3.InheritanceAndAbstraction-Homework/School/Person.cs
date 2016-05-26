using System;

namespace School
{
    public abstract class Person : IDetails
    {
        private string name;
        private string details;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The name cannot be empty");
                }
                this.name = value;
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

        public Person(string name, string details = null)
        {
            this.Name = name;
            this.Details = details;           
        }        


    }
}
