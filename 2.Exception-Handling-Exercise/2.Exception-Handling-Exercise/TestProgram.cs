using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Exception_Handling_Exercise
{
    class TestProgram
    {
        static void Main()
        {
            var validPerson = new Person("Petar", "Petrov", 22);
            Console.WriteLine(validPerson);

            try
            {
                var emptyFname = new Person(String.Empty, "Petrov", 22);
                Console.WriteLine(emptyFname);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Exception thrown: {0}", ex.Message);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Exception thrown: {0}", ex.Message);
            }

            try
            {
                var emptyLname = new Person("Petar", String.Empty, 22);
                Console.WriteLine(emptyLname);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Exception thrown: {0}", ex.Message);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Exception thrown: {0}", ex.Message);
            }

            try
            {
                var invalidAge = new Person("Petar", "Petrov", -1);
                Console.WriteLine(invalidAge);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Exception thrown: {0}", ex.Message);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Exception thrown: {0}", ex.Message);
            }

        }
    }
}
