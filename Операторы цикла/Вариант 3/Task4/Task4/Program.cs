using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            var a = long.Parse(Console.ReadLine());
            var i = (int)Math.Log10(a) + 1;
            var maxValue = -1;
            var maxValueIndex = -1;
            while (a >= 1)
            {
                if (a % 10 >= maxValue)
                {
                    maxValue = (int)(a % 10);
                    maxValueIndex = i;
                }
                i--;
                a /= 10;
            }
            Console.WriteLine(maxValueIndex);
        }
    }
}
