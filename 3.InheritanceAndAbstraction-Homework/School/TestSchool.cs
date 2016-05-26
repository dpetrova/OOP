using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class TestSchool
    {
        static void Main()
        {
            List<Student> myStudents = new List<Student>
            {
                new Student("Minka", 640927, "excellent at hystory"),
                new Student("Dido", 645820),
                new Student("Hristo", 340981, "very badly behave yourself")
            };
            Student Pesho = new Student("Pesho", 123456, "very good at math");
            Student Gosho = new Student("Gosho", 356272);
            myStudents.Add(Pesho);
            myStudents.Add(Gosho);

            //foreach (var student in myClass)
            //{
            //    Console.WriteLine(student);
            //}

            List<Discipline> myDisciplines = new List<Discipline>
            {
                new Discipline("HTML&CSS", 10, myStudents, "3 times a week"),
                new Discipline("JavaScript", 8, myStudents),
                new Discipline("PHP", 12, myStudents, "2 times a week")
            };
            Discipline CSharp = new Discipline("C#", 10, myStudents, "once a week");           
            CSharp.AddStudent(new Student("Koko", 253789, "excellent at programming"));
            myDisciplines.Add(CSharp);

            //foreach (var discipline in myDisciplines)
            //{
            //    Console.WriteLine(discipline);
            //}      
     
            
            List<Teacher> myTeachers = new List<Teacher>
            {
                new Teacher("G.Kolev", myDisciplines),
                new Teacher("S.Nakov", myDisciplines, "CSharp professional"),
                new Teacher("M.Peshev", myDisciplines, "PHP professional")
            };

            //foreach (var teacher in myTeachers)
            //{
            //    Console.WriteLine(teacher);
            //}

            Class myClass = new Class("7-B", myTeachers, "Back-end development class");
            Console.WriteLine(myClass);
        }
    }
}
