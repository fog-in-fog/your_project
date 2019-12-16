using System;


namespace УсловныеОператоры2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите символ, букву, цифру или пробел");
            string mmm = Console.ReadLine();
            char[] symbol = mmm.ToCharArray();
            if (char.IsDigit(symbol[0]))
                Console.WriteLine("{0} - число.", symbol[0]);
            else if (char.IsLower(symbol[0]))
                Console.WriteLine("{0} - строчная буква.", symbol[0]);
            else if (char.IsUpper(symbol[0]))
                Console.WriteLine("{0} - заглавная буква.", symbol[0]);
            else if (char.IsPunctuation(symbol[0]))
                Console.WriteLine("{0} - пунктуационный знак.", symbol[0]);
            else if (char.IsWhiteSpace(symbol[0]))
                Console.WriteLine("{0} - пробел.", symbol[0]);
            else
                Console.WriteLine(" {0} - специальный символ.", symbol[0]);
            Console.ReadKey();
        }
    }
}