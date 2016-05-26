using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompanyHierarchy
{
    using Interfaces;

    public abstract class Person : IPerson
    {
        private int id;
        private string firstName;
        private string lastName;

        public Person(int id, string fname, string lname)
        {
            this.Id = id;
            this.FirstName = fname;
            this.LastName = lname;
        }

        public int Id
        {
            get
            {
                return this.id;
            }
            set
            {
                if(value == null)
                {
                    throw new ArgumentNullException("Id cannot be null");
                }
                this.id = value;
            }
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be null or empty");
                }
                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be null or empty");
                }
                this.lastName = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Id: {0}, Name: {1} {2}", this.Id, this.FirstName, this.LastName);
        }
    }
}
