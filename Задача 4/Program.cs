using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_4
{
    internal class Program
    {
        /// <summary>
        /// Задача 4. Определить статический метод int Seconds (int h, int m, int s), 
        /// который принимает три целых аргумента (часы h, минуты m и секунды s) и возвращает количество секунд,
        /// прошедших с начала дня. Используя этот метод, вычислить количество секунд, прошедших с начала дня при: а) 0 ч 40 мин 20 с; б) 3 ч 10 мин 50 с.
        /// </summary>

        static int Seconds(int h, int m, int s)
        {
            return h * 3600 + m * 60 + s; //в секундах
        }

        static void Main(string[] args)
        {
            int result1 = Seconds(0, 40, 20);
            int result2 = Seconds(3, 10, 50);

            Console.WriteLine($"Кол-во секунд при 0 ч 40 мин 20 с = {result1} секунд");
            Console.WriteLine($"Кол-во секунд при 3 ч 10 мин 50 с = {result2} секунд");

            Console.ReadLine();
        }
    }
}
