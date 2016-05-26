using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Animals
{
    public class Kitten : Cat
    {
        public Kitten(string name, int age): base(name, age, Gender.Female)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("I am kitten, mmmmmmmmmiau!");
        }
    }
}
