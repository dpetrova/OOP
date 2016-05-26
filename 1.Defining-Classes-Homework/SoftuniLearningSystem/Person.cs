using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftuniLearningSystem
{
    using System.Diagnostics.Contracts;

    public abstract class Person
    {
        private string firstName;
        private string lastName;
        private int age;

        public Person(string fname, string lname)
            : this(fname, lname, 0)
        {
        }

        public Person(string fname, string lname, int age)
        {
            this.FirstName = fname;
            this.LastName = lname;
            this.Age = age;
        }

        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value;} 
        }

        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public override string ToString()
        {
            var details = String.Format("{0} {1} ({2} years old)", this.FirstName, this.LastName,
                                                            this.Age != 0 ? this.Age.ToString() : "N/A");
            return details;
        }
    }
}
