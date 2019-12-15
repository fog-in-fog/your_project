using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Массивы
{
    class Program
    {
        static void Change(int[] mas)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Меняем знак каждого четного элемента");
            Console.ResetColor();
            foreach (int i in mas)
            {
                if (mas[i] / 2 != 0) mas[i] *= -1;
                Console.Write(mas[i] + " ");
            }

        }

        static void printMas(int[] mas)
        {

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Ряд Фиббоначи в строку");
            Console.ResetColor();
            foreach (int i in mas)
            {
                Console.Write(mas[i] + ";");
            }
        }

        static void Main(string[] args)
        {
            int size = 12;//размер массива 
            int[] mas = new int[size];//объявление массива с размером\ 

            Console.WriteLine("Введите первое число");
            int n_1 = int.Parse(Console.ReadLine());//ввод первого числа 

            Console.WriteLine("Введите второе число");
            int n_2 = int.Parse(Console.ReadLine());//ввод второго числа 

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Ряд Фиббоначи");
            Console.ResetColor();
            for (int i = 1; i <= size; ++i)
            {
                var n_3 = n_1 + n_2;
                Console.WriteLine("F{0}) {1}", i, n_1);
                n_1 = n_2;
                n_2 = n_3;
            }

            Console.WriteLine();
            printMas(mas);
            Console.WriteLine();
            Change(mas);

            Console.ReadKey();
        }
    }
}
    }
}
