using System;
using System.Text.RegularExpressions;

    public class Person
    {
        //fields
        private string name;
        private int age;
        private string email;

        //second constructor
        public Person(string name, int age)
            : this(name, age, null)
        {
        }

        //first constructor
        public Person(string name, int age, string email)
        {
            this.Name = name;
            this.Age = age;
            this.Email = email;
        }
        
        //property Name
        public string Name
        {
            get { return this.name; }
            set {
                    if (String.IsNullOrEmpty(value))
                    {
                        throw new ArgumentException("Name cannot be empty!");
                    }
                    this.name = value; 
                }
        }

        //property Age
        public int Age
        {
            get { return this.age; }
            set {
                    if (value < 1 || value > 100)
                    {
                        throw new ArgumentException("Invalid age! It should be in the range [1...100].");
                    }
                    this.age = value; 
                }
        }

        //property Email
        public string Email
        {
            get { return this.email; }
            set {
                //check if value is not null is matching regex    
                if (!String.IsNullOrEmpty(value) &&
                    !Regex.IsMatch(value, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase))
                    {
                        throw new ArgumentException("Invalid email!");
                    }
                    this.email = value; 
                }                
        }

        //Implement the ToString() method to enable printing persons at the console
        public override string ToString()
        {
            return string.Format("Person details: name: {0}, age: {1}", this.Name, this.Age) +
                                        (String.IsNullOrEmpty(this.Email) ? "" : ", email: " + this.Email);
        }

}
