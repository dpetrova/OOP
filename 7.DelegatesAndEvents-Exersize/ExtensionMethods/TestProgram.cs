using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    using System.Runtime.InteropServices;

    class TestProgram
    {
        static void Main()
        {
            List<int> collection = new List<int>{1, 2, 3, 4, 6, 11, 3};

            //test FirstOrDefault
            Console.WriteLine(collection.FirstOrDefault(x => x > 7));
            Console.WriteLine(collection.FirstOrDefault(x => x < 0));
            
            //test TakeWhile
            Console.WriteLine(string.Join(", ", collection.TakeWhile(x => x < 10)));

            //test ForEach
            collection.ForEach(Console.WriteLine);
        }
    }
}
