using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftuniLearningSystem
{
    public class JuniorTrainer : Trainer
    {
        public JuniorTrainer(string fname, string lname, int age) : base(fname, lname, age)
        {
        }

        public JuniorTrainer(string fname, string lname) : base(fname, lname)
        {
        }
    }
}
