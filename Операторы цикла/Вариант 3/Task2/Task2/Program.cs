using System;
using System.Globalization;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите n:");
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите последовательность через пробел:");
            var a = Console.ReadLine().Split(); // а - массив элементов последовательности типа string
            var ans = 1.0;
            foreach(var i in a)            
                ans *= double.Parse(i.Replace(",", "."), CultureInfo.InvariantCulture);
            
            Console.WriteLine(ans);
        }
    }
}
