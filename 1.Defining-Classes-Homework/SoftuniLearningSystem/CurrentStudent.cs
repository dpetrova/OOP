using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftuniLearningSystem
{
    public class CurrentStudent : Student
    {
        private string currentCourse;

        public CurrentStudent(string fname, string lname, string number, double grade, string course)
            : this(fname, lname, 0, number, grade, course)
        {
        }

        public CurrentStudent(string fname, string lname, int age, string number, double grade, string course) 
            : base(fname, lname, age, number, grade)
        {
            this.CurrentCourse = course;
        }

        public string CurrentCourse
        {
            get { return this.currentCourse; }
            set { this.currentCourse = value; }
        }
    }
}
