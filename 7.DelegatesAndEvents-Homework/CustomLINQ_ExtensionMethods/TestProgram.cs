using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLINQ_ExtensionMethods
{
    using StudentClass;

    class TestProgram
    {
        static void Main()
        {
            //test WhereNot()
            List<int> nums = new List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            //filters ot even numbers, returns odds
            var filteredCollection = nums.WhereNot(x => x%2 == 0);
            Console.WriteLine(string.Join(", ", filteredCollection));


            //test Max
            var students = new List<Student>
            {
                new Student("Pesho", 3),
                new Student("Gosho", 2),
                new Student("Mariika", 7),
                new Student("Stamat", 5)
            };

            var older = students.Max(s => s.Age);
            Console.WriteLine(older);
        }
    }
}
