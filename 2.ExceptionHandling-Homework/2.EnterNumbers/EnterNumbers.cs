using System;

class EnterNumbers
{
    static void Main()
    {
        int start = 1;
        int end = 100;
        int?[] nums = new int?[10];
        for (int i = 0; i < nums.Length; i++)
        {
            while (nums[i] == null)
            {
                nums[i] = ReadNumber(start, end);
            }
            start = (int)nums[i];
        }
        Console.WriteLine(string.Join(", ", nums));
    }

    public static int? ReadNumber(int start, int end)
    {
        string input = Console.ReadLine();
        int? number = null;
        try
        {
            number = int.Parse(input);
            if (number < start)
            {
                throw new ArgumentOutOfRangeException("Number should be in range [start...end]");
            }
            else if( number > end)
            {
                throw new ArgumentOutOfRangeException("The number must be greater than previous");
            }
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Exception thrown: {0}", ex.Message);
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine("Exception thrown: {0}", ex.Message);
        }
        catch (ArithmeticException ex)
        {
            Console.WriteLine("Exception thrown: {0}", ex.Message);
        }
        return number;
    }
}

