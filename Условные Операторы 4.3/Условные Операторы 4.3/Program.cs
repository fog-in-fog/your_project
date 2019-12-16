using System;

namespace Calendar
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите год н.э");
            var year = int.Parse(Console.ReadLine());
            var point = 0;
            if (year > 1983)
            {
                while (year > 1983)
                {
                    year -= 60;
                    point = year - 1923;
                }
            }
            else
            {
                while (year < 1983)
                {
                    year += 60;
                    point = year - 1983;
                }
            }
            var color = (point / 12) + 1;
            var animal = point % 12;
            switch (color)
            {
                case 1:
                    Console.Write("Зелено");
                    break;
                case 2:
                    Console.Write("Красно");
                    break;
                case 3:
                    Console.Write("Жёлто");
                    break;
                case 4:
                    Console.Write("Бело");
                    break;
                case 5:
                    Console.Write("Чёрно");
                    break;
                case 6:
                    Console.Write("Чёрно");
                    break;
            }
            switch (animal)
            {
                case 0:
                    Console.Write("й Свиньи");
                    Console.WriteLine();
                    Console.ReadKey();
                    break;
                case 1:
                    Console.Write("й Крысы");
                    Console.WriteLine();
                    Console.ReadKey();
                    break;
                case 2:
                    Console.Write("й Коровы");
                    Console.WriteLine();
                    Console.ReadKey();
                    break;
                case 3:
                    Console.Write("го Тигра");
                    Console.WriteLine();
                    Console.ReadKey();
                    break;
                case 4:
                    Console.Write("го Зайца");
                    Console.WriteLine();
                    Console.ReadKey();
                    break;
                case 5:
                    Console.Write("го Дракона");
                    Console.WriteLine();
                    Console.ReadKey();
                    break;
                case 6:
                    Console.Write("й Змеи");
                    Console.WriteLine();
                    Console.ReadKey();
                    break;
                case 7:
                    Console.Write("й Лошади");
                    Console.WriteLine();
                    Console.ReadKey();
                    break;
                case 8:
                    Console.Write("й Овцы");
                    Console.WriteLine();
                    Console.ReadKey();
                    break;
                case 9:
                    Console.Write("й Обезьяны");
                    Console.WriteLine();
                    Console.ReadKey();
                    break;
                case 10:
                    Console.Write("й Курицы");
                    Console.WriteLine();
                    Console.ReadKey();
                    break;
                case 11:
                    Console.Write("й Собаки");
                    Console.WriteLine();
                    Console.ReadKey();
                    break;
            }
        }
    }
}