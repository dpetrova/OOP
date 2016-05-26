using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop
{
    class TestProgram
    {
        static void Main()
        {
            var book = new Book("Pod Igoto", "Ivan Vazov", 15.90m);

            var goldenBook = new GoldenEditionBook("Tutun", "Dimitar Dimov", 22.90m);

            Console.WriteLine(book);
            Console.WriteLine(goldenBook);
        }
    }
}
