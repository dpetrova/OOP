using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftuniLearningSystem
{
    public abstract class Student : Person
    {
        private string studentNumber;
        private double averageGrade;

        public Student(string fname, string lname, string number, double grade)
            : this(fname, lname, 0, number, grade)
        {
        }

        public Student(string fname, string lname, int age, string number, double grade)
            : base(fname, lname, age)
        {
            this.StudentNumber = number;
            this.AverageGrade = grade;
        }

        public string StudentNumber
        {
            get { return this.studentNumber; }
            set { this.studentNumber = value; }
        }

        public double AverageGrade
        {
            get { return this.averageGrade; }
            set { this.averageGrade = value; }
        }

        public override string ToString()
        {
            return "Student: " + base.ToString() + "; Student number: " + this.studentNumber +
                                                            "; Average grade: " + this.AverageGrade;
        }
    }
}
