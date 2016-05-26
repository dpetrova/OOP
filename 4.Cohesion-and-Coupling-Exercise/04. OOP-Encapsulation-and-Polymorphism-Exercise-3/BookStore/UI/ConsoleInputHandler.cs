using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.UI
{
    using Interfaces;

    public class ConsoleInputHandler : IInputHandler
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
