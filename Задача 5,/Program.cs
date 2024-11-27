using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_5_
{
    internal class Program
    {
        /// <summary>
        /// Задача 5. Определить статический метод int Meters (int k, int m), который принимает два целых аргумента 
        /// (километры k, метры m) и возвращает количество метров. Используя этот метод, вычислить количество метров для расстояния:
        /// а) 3 км 40 м;б) 12 км 540 м.
        /// </summary>

        static int Meters(int k, int m)
        {
            return k * 1000 + m;
        }

        static void Main(string[] args)
        {
            int result1 = Meters(3, 40);
            int result2 = Meters(12, 540);

            Console.WriteLine($"Количество метров при 3 км 40 м = {result1}");
            Console.WriteLine($"Количество метров при 12 км 540 м = {result2}");

            Console.ReadLine();
        }
    }
}
