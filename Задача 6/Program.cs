using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_6
{
    internal class Program
    {
        /// <summary>
        /// Задача 6. Определить статический метод void Numbers (int n), который выводит на экран четные числа от 2 до числа n.
        /// Используя этот метод, вывести на экран четные числа:
        /// а) от 2 до 20; б) от 2 до 50; в) от 2 до m(m вводится с клавиатуры).
        /// </summary>

        static void Numbers(int n)
        {
            for (int i = 2; i <= n; i++) 
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Чётные числа от 2 до 20");
            Numbers(20);

            Console.WriteLine("\nЧётные числа от 2 до 50");
            Numbers(50);

            Console.Write("\nВведите число m = ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"\nЧётные числа от 2 до {m}");
            Numbers(m);

            Console.ReadLine();

        }
    }
}
