using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Animals
{
    public class Tomcat : Cat
    {
         public Tomcat(string name, int age): base(name, age, Gender.Male)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("I am tomcat, miauuuuuuuuuu!");
        }
    }
}
