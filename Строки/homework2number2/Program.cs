using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2number3
{
    class Program
    {
        static void Main()
        {
           Console.Write("Введите Вашу эллектронную почту: ");
            var email = Console.ReadLine();
            var index = email.IndexOf('@');
            var mailBox = email.Substring(0, index);
            var mailservice = email.Substring(index + 1);




            //Console.WriteLine ("Ваш почтовый ящик " + mailBox + " находятся на сервисе " + mailservice);
            Console.WriteLine($"Ваш почтовый ящик {mailBox} находится на сервисе {mailservice}"); // метод string.format


            Console.ReadKey();

            
                
        }
    }
}
