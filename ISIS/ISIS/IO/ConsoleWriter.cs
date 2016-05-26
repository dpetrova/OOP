using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISIS.IO
{
    using Interfaces;

    class ConsoleWriter : IOutputWriter
    {
        public void Print(string message)
        {
            Console.WriteLine(message);
        }
    }
}
