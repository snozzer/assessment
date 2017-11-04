// A Hello World! program in C#.
using System;
namespace TestApp
{
    class Test
    {
        static void Main()
        {
            int a;
            int b;
            int c, d;

            a = 1;
            b = 2;
            c = 0;
            d = 0;

            while (c < 4000000)
            {
                c = a + b;

                if (c % 2 == 0)
                {
                    d = d + c;
                }

                a = b;
                b = c;

            }

            // Keep the console window open in debug mode.
            Console.WriteLine(d);
            Console.ReadKey();
        }
    }
}