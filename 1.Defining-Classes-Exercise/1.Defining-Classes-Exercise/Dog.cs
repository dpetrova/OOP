﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Defining_Classes_Exercise
{
    public class Dog
    {
        public Dog() : this(null, null)
        {
        }

        public Dog(string name, string breed)
        {
            this.Name = name;
            this.Breed = breed;
        }

        public string Name { get; set; }

        public string Breed { get; set; }

        public void Bark()
        {
            Console.WriteLine("{0} ({1}) said: Bau-bau-bau!", this.Name ?? "[unnamed dog]", this.Breed ?? "[unknown breed]");
        }
    }
}
