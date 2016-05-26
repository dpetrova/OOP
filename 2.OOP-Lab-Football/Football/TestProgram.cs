using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    class TestProgram
    {
        static void Main()
        {
            string line = Console.ReadLine();
            while (line != "End")
            {
                try
                {
                    LeagueManager.HandleInput(line);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                line = Console.ReadLine();
            }

        }
    }
}
