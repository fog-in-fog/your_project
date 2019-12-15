using System;
using System.Globalization;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число a:");
            var a = double.Parse(Console.ReadLine().Replace(",", "."), CultureInfo.InvariantCulture);
            //меняем запятую меняем на точку(если запятая есть) и парсим в дабл
            //это универнсальное решение, без этого на разных компах будет работать по разному
            var sum = 0.0;
            var n = 1;
            
            while (sum <= a)            
                sum += 1.0 / n++;                               
                        
            Console.WriteLine(n);            
        }
    }
}
