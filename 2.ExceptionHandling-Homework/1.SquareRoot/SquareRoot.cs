using System;

class SquareRoot
{
    static void Main()
    {
        string input = Console.ReadLine();
        try
        {
            int number = int.Parse(input);
            double squareRoot = Math.Sqrt(number);
            Console.WriteLine(squareRoot);
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Exception thrown: {0}", ex.Message);
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine("Exception thrown: {0}", ex.Message);
        }
        finally
        {
            Console.WriteLine("Good bye");
        }

    }
}