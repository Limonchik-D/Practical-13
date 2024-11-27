using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_7
{
    internal class Program
    {
        /// <summary>
        /// Задача 7. Определить статический метод double Average (int m, int n),
        /// который вычисляет и возвращает среднее арифметическое всех целых от m до n включительно. 
        /// Используя этот метод, вычислить среднее арифметическое всех чисел: а) от 1 до 10; б) от 20 до 40; в) от a до b(a, b вводятся с клавиатуры).
        /// </summary>

        static double Average(int m, int n)
        {
            int sum = 0; //хранения суммы чисел
            int count = 0; //хранения количества чисел

            for (int i = m; i <= n; i++)
            {
                sum += i; 
                count++;   
            }

            return (double)sum / count;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Среднее арифметическое чисел от 1 до 10: " + Average(1, 10));

            Console.WriteLine("Среднее арифметическое чисел от 20 до 40: " + Average(20, 40));

            Console.Write("Введите число a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Среднее арифметическое чисел от {a} до {b}: " + Average(a, b));

            Console.ReadLine();
        }

    }
}
