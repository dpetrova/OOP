using System;

namespace HumanStudentWorker
{
    public class Student : Human
    {
        private string facultyNumber;

        public Student(string fname, string lname, string fnumber)
            : base(fname, lname)
        {
            this.FacultyNumber = fnumber;
        }

        public string FacultyNumber
        {
            get
            {
                return this.facultyNumber;
            }
            set
            {
                if(value.Length < 5 || value.Length > 10)
                {
                    throw new ArgumentOutOfRangeException("Invalid faulty number. It should be [5...10] characters");
                }
                this.facultyNumber = value;
            }
        }
        

        public override string ToString()
        {
            return base.ToString() + string.Format("; Faculty number: {0}", this.FacultyNumber);
        }
    }
}
