using System;

public class PrintPersons
{
    static void Main()
    {
        Console.Write("Enter a name: ");
        string name = Console.ReadLine();

        Console.Write("Enter an age: ");
        string ageAsString = Console.ReadLine();
        int age;
        bool isInt = int.TryParse(ageAsString, out age);
        if (isInt)
        {
            age = int.Parse(ageAsString);
        }    
        
        Console.Write("Enter an email: ");
        string email = Console.ReadLine();

        try
            {
                if (email != null)
                {
                    Person person = new Person(name, age, email);
                    Console.WriteLine(person.ToString());
                }
                else
                {
                    Person person = new Person(name, age);
                    Console.WriteLine(person.ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Cannot create person object: " + ex);
            }
        
    }

}

