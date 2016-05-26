using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftuniLearningSystem
{
    public class OnsiteStudent : CurrentStudent
    {
        private int numberOfVisits;

        public OnsiteStudent(string fname, string lname, string number, double grade, string course, int visits)
            : this(fname, lname, 0, number, grade, course, visits)
        {
        }

        public OnsiteStudent(string fname, string lname, int age, string number, double grade, string course, int visits)
            : base(fname, lname, age, number, grade, course)
        {
            this.NumberOfVisits = visits;
        }

        public int NumberOfVisits
        {
            get { return this.numberOfVisits; }
            set { this.numberOfVisits = value; }
        }

        public override string ToString()
        {
            return base.ToString() + "; Visits: " + this.NumberOfVisits;
        }
    }
}
