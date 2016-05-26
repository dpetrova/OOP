using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Exception_Handling_Exercise
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;

        public Person(string fname, string lname, int age)
        {
            this.FirstName = fname;
            this.LastName = lname;
            this.Age = age;
        }

        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("value", "First Name cannot be null or empty!");
                }
                this.firstName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("value", "Last Name cannot be null or empty!");
                }
                this.lastName = value;
            }
        }

        public int Age
        {
            get { return this.age; }
            set
            {
                if (value < 0 || value > 120)
                {
                    throw new ArgumentOutOfRangeException("value", "Age should be in the range [1...120].");
                }
                this.age = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Person details: {0} {1}, age: {2}", 
                                                            this.FirstName, this.LastName, this.Age);
        }

    }
}
