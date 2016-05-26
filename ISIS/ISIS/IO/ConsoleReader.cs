using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISIS.IO
{
    using Interfaces;

    class ConsoleReader : IInputReader
    {
        public string ReadLine()
        {
            string input = Console.ReadLine();
            return input;
        }
    }
}
