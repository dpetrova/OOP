using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    class TestGenericList
    {
        static void Main()
        {
            var myList = new GenericList<int>();
            //print empty list
            Console.WriteLine(myList);

            //test Add and Resize
            myList.Add(1);
            myList.Add(2);
            myList.Add(7);
            myList.Add(11);
            myList.Add(23);
            myList.Add(22);
            myList.Add(33);
            myList.Add(45);
            myList.Add(84);
            myList.Add(16);
            myList.Add(76);
            myList.Add(90);
            myList.Add(99);
            myList.Add(19);
            myList.Add(34);
            myList.Add(71);
            myList.Add(21);
            myList.Add(100);
            Console.WriteLine(myList);

            //test RemoveAt
            myList.RemoveAt(0); //at valid position
            Console.WriteLine(myList);
            //myList.RemoveAt(-1); //at invalid position
            //Console.WriteLine(myList);
            
            //test AccessAt
            Console.WriteLine(myList.AccessAt(3)); //at valid position
            //Console.WriteLine(myList.AccessAt(50)); //at invalid position

            //test InsertAt
            myList.InsertAt(200, 30);
            Console.WriteLine(myList);
            myList.InsertAt(999, 0);
            Console.WriteLine(myList);
            myList.InsertAt(111, 10);
            Console.WriteLine(myList);
            //myList.InsertAt(222, -3);
            //Console.WriteLine(myList);

            //test Clear
            //myList.Clear();
            //Console.WriteLine(myList);

            //test Find
            Console.WriteLine(myList.Find(200));
            Console.WriteLine(myList.Find(-2));

            //test Contain
            Console.WriteLine(myList.Contain(200));
            Console.WriteLine(myList.Contain(-200));

            //test Min
            Console.WriteLine(myList.Min());

            //test Max
            Console.WriteLine(myList.Max());

            //test Version
            Type type = typeof(GenericList<>);
            object[] allAttributes = type.GetCustomAttributes(typeof(VersionAttribute), false);
            Console.WriteLine("GenericsList's version is {0}", ((VersionAttribute)allAttributes[0]).Version);
        }
    }
}
