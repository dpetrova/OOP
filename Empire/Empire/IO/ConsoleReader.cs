using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empire.Engine
{
    using Intefaces;

    public class ConsoleReader : IInputReader
    {
        public string ReadLine()
        {
            string input = Console.ReadLine();
            return input;
        }
    }
}
