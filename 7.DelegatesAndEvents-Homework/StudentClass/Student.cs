using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentClass
{
    using System.Threading;

    public class Student
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string name;
        private int age;

        public Student(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                Run(nameof(this.Name), this.name, value);
                this.name = value;
            }
        }

        public int Age
        {
            get { return this.age; }
            set
            {
                Run(nameof(this.Age), this.age, value);
                this.age = value;
            }
        }

        public void Run(string propName, object oldValue, object newValue)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propName, oldValue, newValue));
            }

        }
    }
}
