using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftuniLearningSystem
{
    public class OnlineStudent : CurrentStudent
    {
        public OnlineStudent(string fname, string lname, string number, double grade, string course) 
            : base(fname, lname, number, grade, course)
        {
        }

        public OnlineStudent(string fname, string lname, int age, string number, double grade, string course) 
            : base(fname, lname, age, number, grade, course)
        {
        }
    }
}
