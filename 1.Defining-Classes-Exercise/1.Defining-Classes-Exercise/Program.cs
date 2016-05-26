using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Defining_Classes_Exercise
{
    class Program
    {
        static void Main()
        {
            Dog unnamed = new Dog();
            unnamed.Breed = "melez";
            unnamed.Bark();

            Dog sharo = new Dog("Sharo", "pincher");
            sharo.Bark();
        }
    }
}
