using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftuniLearningSystem
{
    public class GraduateStudent : Student
    {
        public GraduateStudent(string fname, string lname, string number, double grade) 
            : base(fname, lname, number, grade)
        {
        }

        public GraduateStudent(string fname, string lname, int age, string number, double grade) 
            : base(fname, lname, age, number, grade)
        {
        }
    }
}
