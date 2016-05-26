using System;

namespace AsynchronousTimer
{
    class TestTimer
    {
        static void Main()
        {
            AsyncTimer timer1 = new AsyncTimer(method1, 500, 10);
            timer1.Start();

            AsyncTimer timer2 = new AsyncTimer(method2, 1000, 10);
            timer2.Start();
        }

        public static void method1(string str)
        {
            Console.Write(str);
        }

        public static void method2(string str)
        {
            Console.Beep();
        }
    }
}
