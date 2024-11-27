using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_3
{
    internal class Program
    {
        /// <summary>
        /// Задача 3. Найти s=min(a, b) + min(c, d),
        /// используя вспомогательные функции (ввода аргументов, нахождения минимальной величины, вывода результата).
        /// </summary>

        static int Input(string message)
        {
            Console.Write(message);
            return Convert.ToInt32(Console.ReadLine());
        }

        static int Minimum(int x, int y)
        {
            return x < y ? x : y;
        }

        static void Main(string[] args)
        {
            int a = Input("a = ");
            int b = Input("b = ");
            int c = Input("c = ");
            int d = Input("d = ");

            int min = Minimum(a, b);
            int secondmin = Minimum(d, c);
            int result = min + secondmin;
            Console.WriteLine($"s = {min} + {secondmin} = {result}");

            Console.ReadKey();
        }
    }
}
