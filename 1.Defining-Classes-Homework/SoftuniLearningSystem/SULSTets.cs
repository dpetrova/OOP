using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftuniLearningSystem
{
    class SULSTets
    {
        static void Main()
        {
            var trainerGosho = new JuniorTrainer("Gosho", "Goshev", 22);
            var trainerPesho = new JuniorTrainer("Pesho", "Petrov");
            var trainerAngelov = new SeniourTrainer("Ivan", "Angelov", 59);
            var trainerPopov = new SeniourTrainer("Petko", "Popov", 48);
            var studentMinka = new GraduateStudent("Minka", "Mincheva", 30, "ST75775534", 5.70);
            var studentGancho = new GraduateStudent("Gancho", "Mincheva", "ST2425332", 4.40);
            var studentDido = new OnlineStudent("Dean", "Dinkov", 32, "ST33333333", 3.00, "ASP.NET MVC");
            var studentMisho = new OnlineStudent("Mihail", "Mihailov", "ST4242121", 6.00, "PHP Web Development");
            var studentRadka = new OnsiteStudent("Radka", "Toteva", "ST75775534", 5.11, "Java Basics", 22);
            var studentIvo = new OnsiteStudent("Ivo", "Nikolov", "ST9999999", 4.98, "HTML&CSS", 4);

            var softuniClass = new List<Person>
                    {
                        trainerGosho,
                        trainerPesho,
                        trainerAngelov,
                        trainerPopov, 
                        studentMinka,
                        studentGancho,
                        studentDido,
                        studentMisho,
                        studentRadka,
                        studentIvo
                     };

            var currentStudents = softuniClass
                .Where(s => s is CurrentStudent)
                .Cast<CurrentStudent>()
                .ToList()
                .OrderByDescending(s => s.AverageGrade);
            

            foreach (var student in currentStudents)
            {
                Console.WriteLine(student);
            }

        }
    }
}
