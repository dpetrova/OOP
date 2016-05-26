using System;


namespace School
{
    public class Student : Person, IDetails
    {
        private int uniqueClassNumber;


        public int UniqueClassNumber
        {
            get
            {
                return this.uniqueClassNumber;
            }
            set
            {
                if(uniqueClassNumber == null)
                {
                    throw new ArgumentNullException("The class number cannot be empty.");
                }
                this.uniqueClassNumber = value;
            }
        }

        public Student(string name, int uniqueNumber, string details = null): base(name, details)
        {
            this.UniqueClassNumber = uniqueNumber;
        }

        public override string ToString()
        {
            string studentInfo = string.Format("Student: {0}; Unique class number: {1}; Details: {2}",
                                                                        this.Name, this.UniqueClassNumber, this.Details);
            return studentInfo;
        }
    }
}
