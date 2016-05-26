using System;


namespace HumanStudentWorker
{
    public abstract class Human
    {
        private string firstName;
        private string lastName;

        public Human(string fname, string lname)
        {
            this.FirstName = fname;
            this.LastName = lname;
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
                    throw new ArgumentNullException("The name cannot be null or empty.");
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
                    throw new ArgumentNullException("The name cannot be null or empty.");
                }
                this.lastName = value;
            }
        }
        

        public override string ToString()
        {
            return string.Format("Name: {0} {1}", this.FirstName, this.LastName);
        }
    }
}
