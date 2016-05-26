using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Animals
{
    public abstract class Animal : ISoundProducible
    {
        private string name;
        private int age;
        private Gender gender;

        public Animal(string name, int age, Gender gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be empty.");
                }
                this.name = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if(value == null || value < 0)
                {
                    throw new ArgumentException("Age cannot be empty or negative.");
                }
                if(value.GetType() != typeof(int))
                {
                    throw new FormatException("Invalid format age.");
                }
                this.age = value;
            }
        }

        public Gender Gender
        {
            get
            {
                return this.gender;
            }
            set
            {
                if (value.GetType() != typeof(Gender))
                {
                    throw new FormatException("Invalid format gender.");
                }
                this.gender = value;
            }
        }
        

        public abstract void ProduceSound();
        

        public override string ToString()
        {
            return string.Format("Name: {0}, Age: {1}, Gender: {2}", this.Name, this.Age, this.Gender);
        }
    }
}
