using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitArray
{
    class TestProgram
    {
        static void Main()
        {
            var number = new BitArray(8); // all bits are 0 by default
            number[7] = 1;
            Console.WriteLine(number);
        }
    }
}
