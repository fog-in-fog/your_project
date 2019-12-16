using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Математические_Формулы
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите переменную x: ");

            var x = Convert.ToDouble(Console.ReadLine());
            var Result = Math.Sqrt((2*x+Math.Sin(Math.Abs(3*x)))/ 3.56);
            Console.WriteLine("Результат вычислений = " + Result);
            Console.ReadKey();
        }
    }
}
