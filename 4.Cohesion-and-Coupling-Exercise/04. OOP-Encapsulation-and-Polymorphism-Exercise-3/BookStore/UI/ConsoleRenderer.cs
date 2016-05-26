using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.UI
{
    using Interfaces;

    public class ConsoleRenderer : IRenderer
    {
        public void WriteLine(string message, params string[] parameters)
        {
            Console.WriteLine(message, parameters);
        }
    }
}
