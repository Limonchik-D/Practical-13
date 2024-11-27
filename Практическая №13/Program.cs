using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая__13
{
    internal class Program
    {
        /// <summary>
        /// Задача 1. Найти минимальную величину из двух целых переменных a, b, 
        /// используя вспомогательные методы (ввода аргументов, нахождения минимальной величины, вывода результата).
        /// </summary>

        static int Input(string message)
        {
            Console.Write(message);
            return Convert.ToInt32(Console.ReadLine());


        }
        static int Max(int x, int y)
        {
            return x > y ? x : y;
        }

        static void Output(int max)
        {
            Console.WriteLine(max);
        }

        static void Main(string[] args)
        {
            int x = Input("x= ");
            int y = Input("y= ");
            int max = Max(x, y);
            Console.WriteLine($"x = {max}");
            Console.ReadLine();


        }
    }
}
