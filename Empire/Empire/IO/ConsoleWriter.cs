using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empire.Engine
{
    using Intefaces;

    public class ConsoleWriter : IOutputWriter
    {
        public void Print(string message)
        {
            Console.WriteLine(message);
        }
    }
}
