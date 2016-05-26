using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanStudentWorker
{
    class TestSystem
    {
        static void Main()
        {
            List<Student> classA = new List<Student> 
            {
                new Student ("Manol", "Ivanov", "aa53tref"),
                new Student ("Ivo", "Ganchev", "hfhf1234"),
                new Student ("Maia", "Petrova", "6452hhh"),
                new Student ("Gosho", "Goshev", "trg5566"),
                new Student ("Pesho", "Petrov", "888jghgf"),
                new Student ("Minka", "Mincheva", "yr7eg"),
                new Student ("Dido", "Ivanov", "8rbe34g7"),
                new Student ("Kiko", "Nachev", "hfgfdt2"),
                new Student ("Ralica", "Ineva", "758333d"),
                new Student ("Nina", "Sasheva", "jdh1122")                
            };

            var sortedStudents = classA.OrderBy(x => x.FacultyNumber);

            var divisionA = new List<Worker>
            {
                new Worker("Ivo", "Mishev", 100m, 8),
                new Worker ("Maria", "Petkova", 200m, 8),
                new Worker ("Gosho", "Minchev", 250m, 12),
                new Worker ("Petar", "Petrov", 300m, 10),
                new Worker ("Minka", "Ninova", 350.8m, 8),
                new Worker ("Krasimir", "Ivanov", 400m, 12),
                new Worker ("Kiril", "Nachev", 280.20m, 8),
                new Worker ("Ralica", "Bubeva", 290m, 10),
                new Worker ("Ninka", "Sasheva", 590.8m, 14),
                new Worker ("Ico", "Iliev", 335.89m, 10)
            };

            var sortedWorkers = divisionA.OrderByDescending(x => x.MoneyPerHour());
           
            var studentsAndWorkers = new List<Human>();
            studentsAndWorkers.AddRange(classA);
            studentsAndWorkers.AddRange(divisionA);

            var sortedHumans = studentsAndWorkers.OrderBy(x => x.FirstName).ThenBy(x => x.LastName);

            foreach (var human in sortedHumans)
            {
                Console.WriteLine(human);
            }

        }
    }
}
