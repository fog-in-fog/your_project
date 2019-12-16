using System;

namespace Test
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите значение Х");
            var x = double.Parse(Console.ReadLine());
            FunctionValue(x);
        }

        static void FunctionValue(double x)
        {
            if (x > 2)
            {
                Console.WriteLine("f(x) = 2");
                Console.ReadKey();
            }
            else if (x > 0 && x <= 2)
            {
                Console.WriteLine("f(x) = 0");
                Console.ReadKey();
            }
            else
            {
                var value = -3 * x;
                Console.WriteLine("f(x) = {0}", value);
                Console.ReadKey();
            }
        }
    }
}