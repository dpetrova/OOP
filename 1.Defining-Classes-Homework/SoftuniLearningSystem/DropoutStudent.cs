using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftuniLearningSystem
{
    public class DropoutStudent : Student
    {
        private string dropoutReason;

        public DropoutStudent(string fname, string lname, string number, double grade)
            : this(fname, lname, 0, number, grade, null)
        {
        }

        public DropoutStudent(string fname, string lname, int age, string number, double grade, string reason) 
            : base(fname, lname, age, number, grade)
        {
            this.DropoutReason = reason;
        }

        public string DropoutReason
        {
            get { return this.dropoutReason; }
            set { this.dropoutReason = value; }
        }

        public string Reapply()
        {
            var details = String.Format("First Name: {0}\n" +
                                        "Last Name: {1}\n" +
                                        "Age: {2}\n",
                                        "Student number: {3}\n",
                                        "Average grade: {4}\n",
                                        "Dropout reson: {5}\n",
                                         this.FirstName,
                                         this.LastName,
                                         this.Age,
                                         this.StudentNumber,
                                         this.AverageGrade,
                                         this.DropoutReason ?? "N/A");

            return details;
        }

        public override string ToString()
        {
            return Reapply();
        }
    }
}
