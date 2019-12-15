using System;
using System.Globalization;

namespace Task5
{
    class Program
    {
        static double F(double a, double b, double c, double x)
        {
            return x * x * x + a * x * x + b * x + c;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите a:");
            var a = double.Parse(Console.ReadLine().Replace(",", "."), CultureInfo.InvariantCulture);
            Console.WriteLine("Введите b:");
            var b = double.Parse(Console.ReadLine().Replace(",", "."), CultureInfo.InvariantCulture);
            Console.WriteLine("Введите c:");
            var c = double.Parse(Console.ReadLine().Replace(",", "."), CultureInfo.InvariantCulture);
            Console.WriteLine("Введите Эпсилон:");
            var E = double.Parse(Console.ReadLine().Replace(",", "."), CultureInfo.InvariantCulture);
            // эти длинные преобразования нужны, чтобы не было ошибок при числах с запятой или точкой
            //например 1.23 1,23

            var n = 1;
            while (F(a, b, c, -n) > 0) n++;
            var rightIndex = 0.0;
            var leftIndex = (double)-n;
            var middle = 0.0;
            while (rightIndex - leftIndex > E)//в цикле деление отрезка пополам
            {
                middle = (rightIndex + leftIndex) / 2;                
                if (F(a, b, c, middle) > 0)
                    rightIndex = middle;
                else
                    leftIndex = middle;
            }
            Console.WriteLine((rightIndex + leftIndex) / 2);
        }
    }
}
