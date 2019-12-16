using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace УсловныеОператоры1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координату Х ");
            var x = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите координату Y ");
            var y = double.Parse(Console.ReadLine());

            Console.WriteLine(XY(x, y));
            Console.ReadKey();

        }

        static string XY(double x, double y)
        {

            if (x > 0 & y > 0)
                return "Точка находится в первой четверти координатной плоскости";
            else if (x < 0 & y > 0)
                return "Точка находится во второй четверти координатной плоскости";
            else if (x < 0 & y < 0)
                return "Точка находится в третьей четверти координатной плоскости";
            else if (x > 0 & y < 0)
                return "Точка находится в четвертой четверти координатной плоскости";
            else if (x == 0 & y != 0)
                return "Точка лежит на оси Y ";
            else if (y == 0 & x != 0)
                return "Точка лежит на оси X";
            else if (x == 0 & y == 0)
                return "Точка совпадает с началом координат";
            else
                return "Введены неверные значения";

        }
    }

}