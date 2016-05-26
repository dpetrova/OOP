using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftuniLearningSystem
{
    public class SeniourTrainer : Trainer
    {
        public SeniourTrainer(string fname, string lname, int age) : base(fname, lname, age)
        {
        }

        public SeniourTrainer(string fname, string lname) : base(fname, lname)
        {
        }

        public void CreateCourse(string courseName)
        {
            Console.WriteLine("The course {0} has been deleted", courseName);
        }
    }
}
