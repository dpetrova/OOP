using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class TestAnimals
    {
        static void Main()
        {
            var animals = new List<Animal>
            {
                new Dog("Sharo", 3, Gender.Male),
                new Dog("Vihar", 4, Gender.Male),
                new Dog("Sivka", 6, Gender.Female),
                new Frog("Kekeritza", 1, Gender.Female),
                new Cat("Maza", 6, Gender.Female),
                new Kitten("Mishkana", 3),
                new Tomcat("Tomas", 10)
            };

            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
                animal.ProduceSound();
            }

            var groupedByKind = animals
                .GroupBy(a => a is Cat ? typeof(Cat) : a.GetType())
                .Select(a => new
                {
                    GroupName = a.Key,
                    AverageAge = a.ToList().Average(x => x.Age)
                })
                .ToList();

            groupedByKind.ForEach(Console.WriteLine);
        }
    }
}
