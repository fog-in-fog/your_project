using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите b: ");
            var b = int.Parse(Console.ReadLine());
            long ans = 0;

            for (int i = 1; i <= b; i++)
                ans += 2 * i * i;
            for (int i = b + 1; i <= b * b; i++)
                ans += i * i;
            
            Console.WriteLine("Ответ: " + ans.ToString());
            Console.ReadKey();
           
        }
    }
}
